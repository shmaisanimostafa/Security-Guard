using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Security_Guard.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserIdToGuid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2024, 12, 28, 12, 18, 35, 875, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2024, 12, 28, 12, 18, 35, 875, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2024, 12, 28, 12, 18, 35, 875, DateTimeKind.Local).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2024, 12, 28, 12, 18, 35, 875, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2024, 12, 28, 12, 18, 35, 875, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2024, 12, 28, 12, 18, 35, 875, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 12, 18, 35, 875, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 12, 18, 35, 875, DateTimeKind.Local).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 12, 18, 35, 875, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 12, 18, 35, 875, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 12, 18, 35, 875, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 12, 18, 35, 875, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 12, 18, 35, 875, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 12, 18, 35, 875, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 12, 18, 35, 875, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 0,
                column: "Time",
                value: new DateTime(2024, 12, 28, 12, 18, 35, 875, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 12, 28, 12, 18, 35, 875, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 12, 28, 12, 18, 35, 875, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 12, 28, 12, 18, 35, 875, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 12, 28, 12, 18, 35, 875, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 12, 28, 12, 18, 35, 875, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2024, 12, 28, 12, 18, 35, 875, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2024, 12, 28, 12, 18, 35, 875, DateTimeKind.Local).AddTicks(1018));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2024, 12, 28, 12, 16, 29, 251, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2024, 12, 28, 12, 16, 29, 251, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2024, 12, 28, 12, 16, 29, 251, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2024, 12, 28, 12, 16, 29, 251, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2024, 12, 28, 12, 16, 29, 251, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2024, 12, 28, 12, 16, 29, 251, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 12, 16, 29, 251, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 12, 16, 29, 251, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 12, 16, 29, 251, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 12, 16, 29, 251, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 12, 16, 29, 251, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 12, 16, 29, 251, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 12, 16, 29, 251, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 12, 16, 29, 251, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 12, 16, 29, 251, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 0,
                column: "Time",
                value: new DateTime(2024, 12, 28, 12, 16, 29, 251, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 12, 28, 12, 16, 29, 251, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 12, 28, 12, 16, 29, 251, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 12, 28, 12, 16, 29, 251, DateTimeKind.Local).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 12, 28, 12, 16, 29, 251, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 12, 28, 12, 16, 29, 251, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2024, 12, 28, 12, 16, 29, 251, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2024, 12, 28, 12, 16, 29, 251, DateTimeKind.Local).AddTicks(7600));
        }
    }
}
