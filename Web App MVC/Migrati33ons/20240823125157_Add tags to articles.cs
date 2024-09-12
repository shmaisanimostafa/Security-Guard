using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Security_Guard.Migrations
{
    /// <inheritdoc />
    public partial class Addtagstoarticles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Articles");

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleTags",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleTags", x => new { x.ArticleId, x.TagId });
                    table.ForeignKey(
                        name: "FK_ArticleTags_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PublishDate", "Summary" },
                values: new object[] { new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7226), "A brief summary of the article" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PublishDate", "Summary" },
                values: new object[] { new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7235), "A brief summary of the article" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PublishDate", "Summary" },
                values: new object[] { new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7239), "A brief summary of the article" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PublishDate", "Summary" },
                values: new object[] { new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7242), "A brief summary of the article" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PublishDate", "Summary" },
                values: new object[] { new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7245), "A brief summary of the article" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PublishDate", "Summary" },
                values: new object[] { new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7248), "A brief summary of the article" });

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7064), "ambiguous" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 0,
                column: "Time",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Security" },
                    { 2, "Antivirus" },
                    { 3, "Privacy" }
                });

            migrationBuilder.InsertData(
                table: "ArticleTags",
                columns: new[] { "ArticleId", "TagId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleTags_TagId",
                table: "ArticleTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleTags");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PublishDate", "Summary", "Tags" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5243), "A brief summary on the article", "[]" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PublishDate", "Summary", "Tags" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5253), "A brief summary on the article", "[]" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PublishDate", "Summary", "Tags" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5264), "A brief summary on the article", "[]" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PublishDate", "Summary", "Tags" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5269), "A brief summary on the article", "[]" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PublishDate", "Summary", "Tags" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5275), "A brief summary on the article", "[]" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PublishDate", "Summary", "Tags" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5280), "A brief summary on the article", "[]" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "DisLikeCount", "ImageURL", "IsFeatured", "LikeCount", "PublishDate", "Rating", "ReadCount", "SourceURL", "Summary", "Tags", "Title" },
                values: new object[] { 7, "> Hi \n # What do you have today \n \"Good\" `Morning`  ", 0, "file://C:/Users/shmai/source/repos/Security_Guard/wwwroot/Neighbors/Dr.Web.png", false, 0, new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5259), 5, 0, "https://www.drweb.com/", "A brief summary on the article", "[]", "Markdown" });

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5161), "ambigious" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 0,
                column: "Time",
                value: new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5403));
        }
    }
}
