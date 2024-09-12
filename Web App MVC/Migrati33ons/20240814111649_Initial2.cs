using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Security_Guard.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmEmail",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishDate",
                value: new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5259));

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
                column: "DateTime",
                value: new DateTime(2024, 8, 14, 4, 16, 48, 58, DateTimeKind.Local).AddTicks(5161));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConfirmEmail",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishDate",
                value: new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 0,
                column: "Time",
                value: new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4127));
        }
    }
}
