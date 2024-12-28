using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Security_Guard.Migrations
{
    /// <inheritdoc />
    public partial class likedislike : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserArticleInteractions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    Interaction = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserArticleInteractions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserArticleInteractions_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserArticleInteractions_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2024, 12, 28, 11, 21, 29, 292, DateTimeKind.Local).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2024, 12, 28, 11, 21, 29, 292, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2024, 12, 28, 11, 21, 29, 292, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2024, 12, 28, 11, 21, 29, 292, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2024, 12, 28, 11, 21, 29, 292, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2024, 12, 28, 11, 21, 29, 292, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 11, 21, 29, 291, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 11, 21, 29, 291, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 11, 21, 29, 291, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 11, 21, 29, 291, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 11, 21, 29, 291, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 11, 21, 29, 291, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 11, 21, 29, 291, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 11, 21, 29, 291, DateTimeKind.Local).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 12, 28, 11, 21, 29, 291, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 0,
                column: "Time",
                value: new DateTime(2024, 12, 28, 11, 21, 29, 291, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 12, 28, 11, 21, 29, 291, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 12, 28, 11, 21, 29, 291, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 12, 28, 11, 21, 29, 291, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 12, 28, 11, 21, 29, 291, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 12, 28, 11, 21, 29, 291, DateTimeKind.Local).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2024, 12, 28, 11, 21, 29, 291, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2024, 12, 28, 11, 21, 29, 291, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.CreateIndex(
                name: "IX_UserArticleInteractions_ArticleId",
                table: "UserArticleInteractions",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserArticleInteractions_UserId1",
                table: "UserArticleInteractions",
                column: "UserId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserArticleInteractions");

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
        }
    }
}
