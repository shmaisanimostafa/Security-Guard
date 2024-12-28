using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Security_Guard.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserIdToGuid222 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserArticleInteractions_AspNetUsers_UserId1",
                table: "UserArticleInteractions");

            migrationBuilder.DropIndex(
                name: "IX_UserArticleInteractions_UserId1",
                table: "UserArticleInteractions");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "UserArticleInteractions");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserArticleInteractions",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

            migrationBuilder.CreateIndex(
                name: "IX_UserArticleInteractions_UserId",
                table: "UserArticleInteractions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserArticleInteractions_AspNetUsers_UserId",
                table: "UserArticleInteractions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserArticleInteractions_AspNetUsers_UserId",
                table: "UserArticleInteractions");

            migrationBuilder.DropIndex(
                name: "IX_UserArticleInteractions_UserId",
                table: "UserArticleInteractions");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "UserArticleInteractions",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "UserArticleInteractions",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_UserArticleInteractions_UserId1",
                table: "UserArticleInteractions",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserArticleInteractions_AspNetUsers_UserId1",
                table: "UserArticleInteractions",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
