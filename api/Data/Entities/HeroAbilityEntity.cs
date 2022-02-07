using HeronApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HeronApi.Data.Entities;

public static class HeroAbilityIds {
  public static Guid SleepDart = new Guid("e8f50d2c-513b-4b0d-923b-448233a54d61");
  public static Guid BioticGrenade = new Guid("33977acb-67f7-47d2-967e-355a18195efc");
  public static Guid NanoBoost = new Guid("e80bf53b-65a9-4189-9a21-393fcdacd494");
}

public record HeroAbilityEntity(Guid Id, Guid HeroId, string Name, string Description, bool IsUltimate) : HeroAbility(Id, HeroId, Name, Description, IsUltimate) {
  public HeroEntity? Hero { get; set; }
}
public class HeroAbilityEntityTypeConfiguration : IEntityTypeConfiguration<HeroAbilityEntity> {

  public void Configure(EntityTypeBuilder<HeroAbilityEntity> builder) {

    builder.HasData(
      new { Id = HeroAbilityIds.SleepDart, HeroId = HeroIds.Ana, Name = "Sleep Dart", IsUltimate = false, Description = "Fires a dart that puts an enemy to sleep." },
      new { Id = HeroAbilityIds.BioticGrenade, HeroId = HeroIds.Ana, Name = "Biotic Grenade", IsUltimate = false, Description = "Throws a grenade that heals and increses healing on allies, while damaging and preventing healing on enemies." },
      new { Id = HeroAbilityIds.NanoBoost, HeroId = HeroIds.Ana, Name = "Nano Boost", IsUltimate = true, Description = "Increases an ally's damge, while reducing damage taken." }
    );
  }
}