using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Security_Guard.Migrations
{
    /// <inheritdoc />
    public partial class hello : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "Body2", "ImgURL", "Rating", "Title", "URL" },
                values: new object[] { 7, "> Hi \n # What do you have today \n \"Good\" `Morning`  ", "Say Something as Body2", "https://wallpaperaccess.com/full/2081980.jpg", 5, "Markdown", "https://www.drweb.com/" });

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 8, 9, 9, 53, 49, 824, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 8, 9, 9, 53, 49, 824, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 8, 9, 9, 53, 49, 824, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 8, 9, 9, 53, 49, 824, DateTimeKind.Local).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 8, 9, 9, 53, 49, 824, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 8, 9, 9, 53, 49, 824, DateTimeKind.Local).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 8, 9, 9, 53, 49, 824, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 8, 9, 9, 53, 49, 824, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 8, 9, 9, 53, 49, 824, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 0,
                column: "Time",
                value: new DateTime(2024, 8, 9, 9, 53, 49, 824, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 8, 9, 9, 53, 49, 824, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 8, 9, 9, 53, 49, 824, DateTimeKind.Local).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 8, 9, 9, 53, 49, 824, DateTimeKind.Local).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 8, 9, 9, 53, 49, 824, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 8, 9, 9, 53, 49, 824, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2024, 8, 9, 9, 53, 49, 824, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2024, 8, 9, 9, 53, 49, 824, DateTimeKind.Local).AddTicks(2171));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 7, 31, 14, 12, 54, 834, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 7, 31, 14, 12, 54, 834, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 7, 31, 14, 12, 54, 834, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 7, 31, 14, 12, 54, 834, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 7, 31, 14, 12, 54, 834, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 7, 31, 14, 12, 54, 834, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 7, 31, 14, 12, 54, 834, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 7, 31, 14, 12, 54, 834, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 7, 31, 14, 12, 54, 834, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 0,
                column: "Time",
                value: new DateTime(2024, 7, 31, 14, 12, 54, 834, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 7, 31, 14, 12, 54, 834, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 7, 31, 14, 12, 54, 834, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 7, 31, 14, 12, 54, 834, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 7, 31, 14, 12, 54, 834, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 7, 31, 14, 12, 54, 834, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2024, 7, 31, 14, 12, 54, 834, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2024, 7, 31, 14, 12, 54, 834, DateTimeKind.Local).AddTicks(6679));
        }
    }
}
