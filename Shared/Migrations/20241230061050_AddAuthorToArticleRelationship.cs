using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Security_Guard.Migrations
{
    /// <inheritdoc />
    public partial class AddAuthorToArticleRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorId",
                table: "Articles",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "PublishDate" },
                values: new object[] { "283f0143-db7d-4602-986e-3797bcba4f69", new DateTime(2024, 12, 30, 8, 10, 49, 228, DateTimeKind.Local).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "PublishDate" },
                values: new object[] { "283f0143-db7d-4602-986e-3797bcba4f69", new DateTime(2024, 12, 30, 8, 10, 49, 228, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "PublishDate" },
                values: new object[] { "283f0143-db7d-4602-986e-3797bcba4f69", new DateTime(2024, 12, 30, 8, 10, 49, 228, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "PublishDate" },
                values: new object[] { "283f0143-db7d-4602-986e-3797bcba4f69", new DateTime(2024, 12, 30, 8, 10, 49, 228, DateTimeKind.Local).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "PublishDate" },
                values: new object[] { "283f0143-db7d-4602-986e-3797bcba4f69", new DateTime(2024, 12, 30, 8, 10, 49, 228, DateTimeKind.Local).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "PublishDate" },
                values: new object[] { "283f0143-db7d-4602-986e-3797bcba4f69", new DateTime(2024, 12, 30, 8, 10, 49, 228, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 12, 30, 8, 10, 49, 228, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 12, 30, 8, 10, 49, 228, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 12, 30, 8, 10, 49, 228, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 12, 30, 8, 10, 49, 228, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 12, 30, 8, 10, 49, 228, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 12, 30, 8, 10, 49, 228, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 12, 30, 8, 10, 49, 228, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 12, 30, 8, 10, 49, 228, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 12, 30, 8, 10, 49, 228, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 0,
                column: "Time",
                value: new DateTime(2024, 12, 30, 8, 10, 49, 228, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 12, 30, 8, 10, 49, 228, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 12, 30, 8, 10, 49, 228, DateTimeKind.Local).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 12, 30, 8, 10, 49, 228, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 12, 30, 8, 10, 49, 228, DateTimeKind.Local).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 12, 30, 8, 10, 49, 228, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2024, 12, 30, 8, 10, 49, 228, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2024, 12, 30, 8, 10, 49, 228, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.CreateIndex(
                name: "IX_Articles_AuthorId",
                table: "Articles",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_AspNetUsers_AuthorId",
                table: "Articles",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_AspNetUsers_AuthorId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_AuthorId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "AuthorId",
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
