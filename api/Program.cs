using HeronApi.Data;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<HeronDBContext>(options =>
  options.UseNpgsql(connectionString));

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
  .AddEntityFrameworkStores<HeronDBContext>();

builder.Services.Configure<HeronDBContext>(c => c.Database.Migrate());

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

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.MapHealthChecks("/healthz");
// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();