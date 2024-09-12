using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Security_Guard.Migrations
{
    /// <inheritdoc />
    public partial class phishingEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhishingEmails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    EmailMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PredictedClass = table.Column<int>(type: "int", nullable: false),
                    ConfidenceScore = table.Column<float>(type: "real", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserFeedback = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReClassification = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhishingEmails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhishingEmails_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2024, 9, 9, 18, 47, 33, 839, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2024, 9, 9, 18, 47, 33, 839, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2024, 9, 9, 18, 47, 33, 839, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2024, 9, 9, 18, 47, 33, 839, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2024, 9, 9, 18, 47, 33, 839, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2024, 9, 9, 18, 47, 33, 839, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 9, 9, 18, 47, 33, 839, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 9, 9, 18, 47, 33, 839, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 9, 9, 18, 47, 33, 839, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 9, 9, 18, 47, 33, 839, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 9, 9, 18, 47, 33, 839, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 9, 9, 18, 47, 33, 839, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 9, 9, 18, 47, 33, 839, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 9, 9, 18, 47, 33, 839, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 9, 9, 18, 47, 33, 839, DateTimeKind.Local).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 0,
                column: "Time",
                value: new DateTime(2024, 9, 9, 18, 47, 33, 839, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 9, 9, 18, 47, 33, 839, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 9, 9, 18, 47, 33, 839, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 9, 9, 18, 47, 33, 839, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 9, 9, 18, 47, 33, 839, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 9, 9, 18, 47, 33, 839, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2024, 9, 9, 18, 47, 33, 839, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2024, 9, 9, 18, 47, 33, 839, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.CreateIndex(
                name: "IX_PhishingEmails_UserId",
                table: "PhishingEmails",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhishingEmails");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 0,
                column: "Time",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4467));
        }
    }
}
