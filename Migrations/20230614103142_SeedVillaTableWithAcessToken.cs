using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTableWithAcessToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AcessToken",
                table: "VillaAPI",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcessToken", "Created_at" },
                values: new object[] { "", new DateTime(2023, 6, 14, 16, 1, 41, 928, DateTimeKind.Local).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AcessToken", "Created_at" },
                values: new object[] { "", new DateTime(2023, 6, 14, 16, 1, 41, 928, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AcessToken", "Created_at" },
                values: new object[] { "", new DateTime(2023, 6, 14, 16, 1, 41, 928, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AcessToken", "Created_at" },
                values: new object[] { "", new DateTime(2023, 6, 14, 16, 1, 41, 928, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AcessToken", "Created_at" },
                values: new object[] { "", new DateTime(2023, 6, 14, 16, 1, 41, 928, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AcessToken", "Created_at" },
                values: new object[] { "", new DateTime(2023, 6, 14, 16, 1, 41, 928, DateTimeKind.Local).AddTicks(4585) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcessToken",
                table: "VillaAPI");

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_at",
                value: new DateTime(2023, 6, 14, 10, 49, 18, 70, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_at",
                value: new DateTime(2023, 6, 14, 10, 49, 18, 70, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_at",
                value: new DateTime(2023, 6, 14, 10, 49, 18, 70, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_at",
                value: new DateTime(2023, 6, 14, 10, 49, 18, 70, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_at",
                value: new DateTime(2023, 6, 14, 10, 49, 18, 70, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created_at",
                value: new DateTime(2023, 6, 14, 10, 49, 18, 70, DateTimeKind.Local).AddTicks(2528));
        }
    }
}
