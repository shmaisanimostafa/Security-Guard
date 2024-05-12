using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Security_Guard_API.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 4, 6, 17, 48, 2, 265, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 4, 6, 17, 48, 2, 265, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 4, 6, 17, 48, 2, 265, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 4, 6, 17, 48, 2, 265, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 4, 6, 17, 48, 2, 265, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 4, 6, 17, 48, 2, 265, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 4, 6, 17, 48, 2, 265, DateTimeKind.Local).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 4, 6, 17, 48, 2, 265, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 4, 6, 17, 48, 2, 265, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "IsAi", "Sender", "Text", "Time" },
                values: new object[,]
                {
                    { 0, false, "Mostafa", "Hello", new DateTime(2024, 4, 6, 17, 48, 2, 265, DateTimeKind.Local).AddTicks(4396) },
                    { 1, true, "AI", "Hi", new DateTime(2024, 4, 6, 17, 48, 2, 265, DateTimeKind.Local).AddTicks(4400) },
                    { 2, false, "Mostafa", "How are you?", new DateTime(2024, 4, 6, 17, 48, 2, 265, DateTimeKind.Local).AddTicks(4403) },
                    { 3, true, "AI", "I'm fine", new DateTime(2024, 4, 6, 17, 48, 2, 265, DateTimeKind.Local).AddTicks(4407) },
                    { 4, false, "Mostafa", "Good", new DateTime(2024, 4, 6, 17, 48, 2, 265, DateTimeKind.Local).AddTicks(4410) },
                    { 5, true, "AI", "Bye", new DateTime(2024, 4, 6, 17, 48, 2, 265, DateTimeKind.Local).AddTicks(4413) },
                    { 6, false, "Mostafa", "Bye", new DateTime(2024, 4, 6, 17, 48, 2, 265, DateTimeKind.Local).AddTicks(4416) },
                    { 7, true, "AI", "Goodbye", new DateTime(2024, 4, 6, 17, 48, 2, 265, DateTimeKind.Local).AddTicks(4419) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 0);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 4, 6, 17, 20, 49, 674, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 4, 6, 17, 20, 49, 674, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 4, 6, 17, 20, 49, 674, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 4, 6, 17, 20, 49, 674, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 4, 6, 17, 20, 49, 674, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 4, 6, 17, 20, 49, 674, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 4, 6, 17, 20, 49, 674, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 4, 6, 17, 20, 49, 674, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 4, 6, 17, 20, 49, 674, DateTimeKind.Local).AddTicks(9483));
        }
    }
}
