using HeronApi.Data.Entities;
using HeronApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public record HeroUpdateEntity(Guid Id, Guid HeroAbilityId, Guid ReleaseId, string DeveloperComments, string ChangeNotes) : HeroUpdate(Id, HeroAbilityId, ReleaseId, DeveloperComments, ChangeNotes) {
  public HeroAbilityEntity? HeroAbility { get; set; }
  public ReleaseEntity? Release { get; set; }
}
public class HeroUpdateEntityTypeConfiguration : IEntityTypeConfiguration<HeroUpdateEntity> {

  public void Configure(EntityTypeBuilder<HeroUpdateEntity> builder) {

    builder.HasData(
      new { Id = new Guid("c4fe85c7-d7ea-4c4e-b25b-182504a96b0f"), ReleaseId = ReleaseIds.Jan25_22, HeroAbilityId = HeroAbilityIds.BioticGrenade, DeveloperComments = "A generic developer comment 1", ChangeNotes = "Change from 45 to 50 healing" },
      new { Id = new Guid("4cd59c55-4d11-44fa-9108-6a63564baaee"), ReleaseId = ReleaseIds.Jan25_22, HeroAbilityId = HeroAbilityIds.BioticGrenade, DeveloperComments = "A generic developer comment 2", ChangeNotes = "Change from 40 to 45 healing" },
      new { Id = new Guid("7d473fdd-3b07-4f4a-997d-5963f91e1ced"), ReleaseId = ReleaseIds.Jan25_22, HeroAbilityId = HeroAbilityIds.NanoBoost, DeveloperComments = "A generic developer comment 3", ChangeNotes = "Increase charge time from 4s to 5s" }
    );
  }
}