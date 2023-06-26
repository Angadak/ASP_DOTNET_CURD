using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VillaAPI",
                columns: new[] { "Id", "Aminety", "Created_at", "Description", "Name", "Occupancy", "Rate", "Uupdated_at", "image", "sqrt" },
                values: new object[,]
                {
                    { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "!Loremasdfghjkl;qwertyuiozxcvbnm,asdfghjkqwertyuio", "Royal villa", 10, 200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 550 },
                    { 2, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "!Loremasdfghjkl;qwertyuiozxcvbnm,asdfghjkqwertyuio", "luxary  villa", 10, 200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 550 },
                    { 3, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "!Loremasdfghjkl;qwertyuiozxcvbnm,asdfghjkqwertyuio", "Ancient villa", 10, 200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 550 },
                    { 4, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "!Loremasdfghjkl;qwertyuiozxcvbnm,asdfghjkqwertyuio", "palace villa", 10, 200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 550 },
                    { 5, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "!Loremasdfghjkl;qwertyuiozxcvbnm,asdfghjkqwertyuio", "water villa", 10, 200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 550 },
                    { 6, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "!Loremasdfghjkl;qwertyuiozxcvbnm,asdfghjkqwertyuio", "fire villa", 10, 200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 550 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
