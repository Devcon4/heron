using HeronApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public static class ReleaseIds {
  public static Guid Jan25_22 = new Guid("2261cae5-98f8-48d9-bcc8-b798b2e269c2");
}

public record ReleaseEntity(Guid Id, string Title, DateTime ReleaseDate) : Release(Id, Title, ReleaseDate) { }
public class ReleaseEntityTypeConfiguration : IEntityTypeConfiguration<ReleaseEntity> {

  public void Configure(EntityTypeBuilder<ReleaseEntity> builder) {

    builder.HasData(
      new { Id = ReleaseIds.Jan25_22, Title = "OVERWATCH RETAIL PATCH NOTES - JANUARY 25, 2022", ReleaseDate = new DateTime(2022, 1, 25, 0, 0, 0, DateTimeKind.Utc) }
    );
  }
}