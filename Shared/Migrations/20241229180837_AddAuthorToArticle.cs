using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Security_Guard.Migrations
{
    /// <inheritdoc />
    public partial class AddAuthorToArticle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "PublishDate" },
                values: new object[] { "", new DateTime(2024, 12, 29, 20, 8, 36, 436, DateTimeKind.Local).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "PublishDate" },
                values: new object[] { "John Doe", new DateTime(2024, 12, 29, 20, 8, 36, 436, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "PublishDate" },
                values: new object[] { "", new DateTime(2024, 12, 29, 20, 8, 36, 436, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "PublishDate" },
                values: new object[] { "", new DateTime(2024, 12, 29, 20, 8, 36, 436, DateTimeKind.Local).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "PublishDate" },
                values: new object[] { "", new DateTime(2024, 12, 29, 20, 8, 36, 436, DateTimeKind.Local).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "PublishDate" },
                values: new object[] { "", new DateTime(2024, 12, 29, 20, 8, 36, 436, DateTimeKind.Local).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 12, 29, 20, 8, 36, 435, DateTimeKind.Local).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 12, 29, 20, 8, 36, 435, DateTimeKind.Local).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 12, 29, 20, 8, 36, 435, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 12, 29, 20, 8, 36, 435, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 12, 29, 20, 8, 36, 435, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 12, 29, 20, 8, 36, 435, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 12, 29, 20, 8, 36, 436, DateTimeKind.Local).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 12, 29, 20, 8, 36, 436, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 12, 29, 20, 8, 36, 436, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 0,
                column: "Time",
                value: new DateTime(2024, 12, 29, 20, 8, 36, 436, DateTimeKind.Local).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 12, 29, 20, 8, 36, 436, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 12, 29, 20, 8, 36, 436, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 12, 29, 20, 8, 36, 436, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 12, 29, 20, 8, 36, 436, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 12, 29, 20, 8, 36, 436, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2024, 12, 29, 20, 8, 36, 436, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2024, 12, 29, 20, 8, 36, 436, DateTimeKind.Local).AddTicks(310));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Articles");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2024, 12, 28, 14, 5, 12, 801, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2024, 12, 28, 14, 5, 12, 801, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2024, 12, 28, 14, 5, 12, 801, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2024, 12, 28, 14, 5, 12, 801, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2024, 12, 28, 14, 5, 12, 801, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2024, 12, 28, 14, 5, 12, 801, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 14, 5, 12, 801, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 14, 5, 12, 801, DateTimeKind.Local).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 14, 5, 12, 801, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 14, 5, 12, 801, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 14, 5, 12, 801, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 14, 5, 12, 801, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 14, 5, 12, 801, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 14, 5, 12, 801, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 14, 5, 12, 801, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 0,
                column: "Time",
                value: new DateTime(2024, 12, 28, 14, 5, 12, 801, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 12, 28, 14, 5, 12, 801, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 12, 28, 14, 5, 12, 801, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 12, 28, 14, 5, 12, 801, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 12, 28, 14, 5, 12, 801, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 12, 28, 14, 5, 12, 801, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2024, 12, 28, 14, 5, 12, 801, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2024, 12, 28, 14, 5, 12, 801, DateTimeKind.Local).AddTicks(8623));
        }
    }
}
