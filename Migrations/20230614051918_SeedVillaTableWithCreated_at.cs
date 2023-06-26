using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTableWithCreated_at : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_at",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_at",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_at",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_at",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_at",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created_at",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
