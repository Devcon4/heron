using System.Reflection;
using HeronApi.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HeronApi.Data;

public class HeronDBContext : IdentityDbContext {

  public HeronDBContext(DbContextOptions<HeronDBContext> options) : base(options) { }
  protected override void OnModelCreating(ModelBuilder modelBuilder) {
    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  }
  public DbSet<HeroEntity> Heroes { get; set; } = default !;
  public DbSet<HeroAbilityEntity> HeroAblities { get; set; } = default !;
  public DbSet<HeroUpdateEntity> HeroUpdates { get; set; } = default !;
  public DbSet<ReleaseEntity> Releases { get; set; } = default !;
}