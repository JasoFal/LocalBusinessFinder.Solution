using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalBusinessLookup.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "DateAdded", "Description", "Name", "Type" },
                values: new object[] { 1, new DateTime(2024, 7, 5, 17, 29, 37, 392, DateTimeKind.Utc).AddTicks(2889), "BBQ of all forms!", "Jim's Roadhouse", "Restaurant" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "DateAdded", "Description", "Name", "Type" },
                values: new object[] { 2, new DateTime(2024, 7, 5, 17, 29, 37, 392, DateTimeKind.Utc).AddTicks(2891), "We got all kinds of tools!", "Terry's Tools", "Shop" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "DateAdded", "Description", "Name", "Type" },
                values: new object[] { 3, new DateTime(2024, 7, 5, 17, 29, 37, 392, DateTimeKind.Utc).AddTicks(2891), "Don't step foot in the place.", "Parker's Place", "Place" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3);
        }
    }
}
