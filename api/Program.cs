using HeronApi.Data;
using HeronApi.utils;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<HeronDBContext>(options =>
  options.UseNpgsql(connectionString));

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
  .AddEntityFrameworkStores<HeronDBContext>();

builder.Services.Configure<RouteOptions>(options => {
  options.LowercaseUrls = true;
  options.LowercaseQueryStrings = true;
});

builder.Services.AddHealthChecks();

// Add services to the container.
builder.Services.AddMediatR(typeof(Program));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Host.UseSerilog((ctx, lc) => lc.ReadFrom.Configuration(ctx.Configuration));

var app = builder.Build();

using(var scope = app.Services.CreateScope()) {
  var services = scope.ServiceProvider;

  var context = services.GetRequiredService<HeronDBContext>();
  context.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
  app.UseSwagger();
  app.UseSwaggerUI();
  app.UseSerilogRequestLogging(options
                => options.EnrichDiagnosticContext = RequestLogEnricher.EnrichFromRequest);
}

app.MapHealthChecks("/healthz");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

Log.Information("Starting web host");
app.Run();