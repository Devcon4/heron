using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Data.Migrations
{
    public partial class CreateHeroAbilityTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HeroAblities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    HeroId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    IsUltimate = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroAblities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeroAblities_Heroes_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "HeroAblities",
                columns: new[] { "Id", "Description", "HeroId", "IsUltimate", "Name" },
                values: new object[,]
                {
                    { new Guid("33977acb-67f7-47d2-967e-355a18195efc"), "Throws a grenade that heals and increses healing on allies, while damaging and preventing healing on enemies.", new Guid("13d7bac1-6962-46d8-b4e5-664d1ed7d0a1"), false, "Biotic Grenade" },
                    { new Guid("e80bf53b-65a9-4189-9a21-393fcdacd494"), "Increases an ally's damge, while reducing damage taken.", new Guid("13d7bac1-6962-46d8-b4e5-664d1ed7d0a1"), true, "Nano Boost" },
                    { new Guid("e8f50d2c-513b-4b0d-923b-448233a54d61"), "Fires a dart that puts an enemy to sleep.", new Guid("13d7bac1-6962-46d8-b4e5-664d1ed7d0a1"), false, "Sleep Dart" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeroAblities_HeroId",
                table: "HeroAblities",
                column: "HeroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroAblities");
        }
    }
}
