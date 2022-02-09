using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Data.Migrations
{
    public partial class SeedTestReleases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Releases",
                columns: new[] { "Id", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("0577db42-37f3-4445-bf6d-e0e3ab24fea9"), new DateTime(2021, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc), "OVERWATCH RETAIL PATCH NOTES - JANUARY 25, 2022" },
                    { new Guid("2ea849bb-335c-4d50-bf23-52fd52acd457"), new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc), "OVERWATCH RETAIL PATCH NOTES - JANUARY 25, 2022" },
                    { new Guid("403e0c1b-f8a1-4180-84dc-f55b48e89f62"), new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Utc), "OVERWATCH RETAIL PATCH NOTES - JANUARY 25, 2022" },
                    { new Guid("70127cd1-c31f-49ec-a450-5ccde6dedcb7"), new DateTime(2021, 12, 3, 0, 0, 0, 0, DateTimeKind.Utc), "OVERWATCH RETAIL PATCH NOTES - JANUARY 25, 2022" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Releases",
                keyColumn: "Id",
                keyValue: new Guid("0577db42-37f3-4445-bf6d-e0e3ab24fea9"));

            migrationBuilder.DeleteData(
                table: "Releases",
                keyColumn: "Id",
                keyValue: new Guid("2ea849bb-335c-4d50-bf23-52fd52acd457"));

            migrationBuilder.DeleteData(
                table: "Releases",
                keyColumn: "Id",
                keyValue: new Guid("403e0c1b-f8a1-4180-84dc-f55b48e89f62"));

            migrationBuilder.DeleteData(
                table: "Releases",
                keyColumn: "Id",
                keyValue: new Guid("70127cd1-c31f-49ec-a450-5ccde6dedcb7"));
        }
    }
}
