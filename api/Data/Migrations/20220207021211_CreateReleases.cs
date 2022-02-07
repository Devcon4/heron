using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Data.Migrations {
  public partial class CreateReleases : Migration {
    protected override void Up(MigrationBuilder migrationBuilder) {
      migrationBuilder.CreateTable(
        name: "Releases",
        columns : table => new {
          Id = table.Column<Guid>(type: "uuid", nullable : false),
            Title = table.Column<string>(type: "text", nullable : false),
            ReleaseDate = table.Column<DateTime>(type: "timestamp with time zone", nullable : false)
        },
        constraints : table => {
          table.PrimaryKey("PK_Releases", x => x.Id);
        });

      migrationBuilder.InsertData(
        table: "Releases",
        columns : new [] { "Id", "ReleaseDate", "Title" },
        values : new object[] { new Guid("2261cae5-98f8-48d9-bcc8-b798b2e269c2"), new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), "OVERWATCH RETAIL PATCH NOTES - JANUARY 25, 2022" });
    }

    protected override void Down(MigrationBuilder migrationBuilder) {
      migrationBuilder.DropTable(
        name: "Releases");
    }
  }
}