using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Data.Migrations
{
    public partial class CreateHeroUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HeroUpdates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    HeroAbilityId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReleaseId = table.Column<Guid>(type: "uuid", nullable: false),
                    DeveloperComments = table.Column<string>(type: "text", nullable: false),
                    ChangeNotes = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroUpdates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeroUpdates_HeroAblities_HeroAbilityId",
                        column: x => x.HeroAbilityId,
                        principalTable: "HeroAblities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroUpdates_Releases_ReleaseId",
                        column: x => x.ReleaseId,
                        principalTable: "Releases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "HeroUpdates",
                columns: new[] { "Id", "ChangeNotes", "DeveloperComments", "HeroAbilityId", "ReleaseId" },
                values: new object[,]
                {
                    { new Guid("4cd59c55-4d11-44fa-9108-6a63564baaee"), "Change from 40 to 45 healing", "A generic developer comment 2", new Guid("33977acb-67f7-47d2-967e-355a18195efc"), new Guid("2261cae5-98f8-48d9-bcc8-b798b2e269c2") },
                    { new Guid("7d473fdd-3b07-4f4a-997d-5963f91e1ced"), "Increase charge time from 4s to 5s", "A generic developer comment 3", new Guid("e80bf53b-65a9-4189-9a21-393fcdacd494"), new Guid("2261cae5-98f8-48d9-bcc8-b798b2e269c2") },
                    { new Guid("c4fe85c7-d7ea-4c4e-b25b-182504a96b0f"), "Change from 45 to 50 healing", "A generic developer comment 1", new Guid("33977acb-67f7-47d2-967e-355a18195efc"), new Guid("2261cae5-98f8-48d9-bcc8-b798b2e269c2") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeroUpdates_HeroAbilityId",
                table: "HeroUpdates",
                column: "HeroAbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroUpdates_ReleaseId",
                table: "HeroUpdates",
                column: "ReleaseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroUpdates");
        }
    }
}
