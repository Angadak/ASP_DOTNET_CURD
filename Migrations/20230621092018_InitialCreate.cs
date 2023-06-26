using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "image",
                table: "VillaAPI",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "VillaAPI",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Aminety",
                table: "VillaAPI",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AcessToken",
                table: "VillaAPI",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_at",
                value: new DateTime(2023, 6, 21, 14, 50, 18, 211, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_at",
                value: new DateTime(2023, 6, 21, 14, 50, 18, 211, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_at",
                value: new DateTime(2023, 6, 21, 14, 50, 18, 211, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_at",
                value: new DateTime(2023, 6, 21, 14, 50, 18, 211, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_at",
                value: new DateTime(2023, 6, 21, 14, 50, 18, 211, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created_at",
                value: new DateTime(2023, 6, 21, 14, 50, 18, 211, DateTimeKind.Local).AddTicks(4495));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "image",
                table: "VillaAPI",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "VillaAPI",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aminety",
                table: "VillaAPI",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AcessToken",
                table: "VillaAPI",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_at",
                value: new DateTime(2023, 6, 14, 16, 1, 41, 928, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_at",
                value: new DateTime(2023, 6, 14, 16, 1, 41, 928, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_at",
                value: new DateTime(2023, 6, 14, 16, 1, 41, 928, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_at",
                value: new DateTime(2023, 6, 14, 16, 1, 41, 928, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_at",
                value: new DateTime(2023, 6, 14, 16, 1, 41, 928, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "VillaAPI",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created_at",
                value: new DateTime(2023, 6, 14, 16, 1, 41, 928, DateTimeKind.Local).AddTicks(4585));
        }
    }
}
