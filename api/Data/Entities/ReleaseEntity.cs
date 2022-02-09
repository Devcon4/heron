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
      new { Id = ReleaseIds.Jan25_22, Title = "OVERWATCH RETAIL PATCH NOTES - JANUARY 25, 2022", ReleaseDate = new DateTime(2022, 1, 25, 0, 0, 0, DateTimeKind.Utc) },
      new { Id = new Guid("0577db42-37f3-4445-bf6d-e0e3ab24fea9"), Title = "OVERWATCH RETAIL PATCH NOTES - JANUARY 25, 2022", ReleaseDate = new DateTime(2021, 12, 21, 0, 0, 0, DateTimeKind.Utc) },
      new { Id = new Guid("70127cd1-c31f-49ec-a450-5ccde6dedcb7"), Title = "OVERWATCH RETAIL PATCH NOTES - JANUARY 25, 2022", ReleaseDate = new DateTime(2021, 12, 3, 0, 0, 0, DateTimeKind.Utc) },
      new { Id = new Guid("2ea849bb-335c-4d50-bf23-52fd52acd457"), Title = "OVERWATCH RETAIL PATCH NOTES - JANUARY 25, 2022", ReleaseDate = new DateTime(2021, 11, 8, 0, 0, 0, DateTimeKind.Utc) },
      new { Id = new Guid("403e0c1b-f8a1-4180-84dc-f55b48e89f62"), Title = "OVERWATCH RETAIL PATCH NOTES - JANUARY 25, 2022", ReleaseDate = new DateTime(2021, 9, 17, 0, 0, 0, DateTimeKind.Utc) }
    );
  }
}