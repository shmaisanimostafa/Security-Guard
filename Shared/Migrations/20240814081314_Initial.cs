using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Security_Guard.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReadCount = table.Column<int>(type: "int", nullable: false),
                    LikeCount = table.Column<int>(type: "int", nullable: false),
                    DisLikeCount = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    SourceURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ConfirmEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSubscribed = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAi = table.Column<bool>(type: "bit", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScanId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThreatLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "DisLikeCount", "ImageURL", "IsFeatured", "LikeCount", "PublishDate", "Rating", "ReadCount", "SourceURL", "Summary", "Tags", "Title" },
                values: new object[,]
                {
                    { 1, "Do you want to see the sea? This your best Hotel", 0, "file://C:/Users/shmai/source/repos/Security%20Guard/wwwroot/Neighbors/Bitdefender.png", false, 0, new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4028), 3, 0, "https://www.bitdefender.com/", "A brief summary on the article", "[]", "Bitdefender" },
                    { 2, "The best for the best. The place where you can exercise your hiking and other sports.", 0, "file://C:/Users/shmai/source/repos/Security_Guard/wwwroot/Neighbors/Dr.Web.png", false, 0, new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4033), 5, 0, "https://www.drweb.com/", "A brief summary on the article", "[]", "Dr.Web" },
                    { 3, "Sleep for cheap. Cheapest Hotel you may ever found", 0, "https://c4.wallpaperflare.com/wallpaper/813/904/915/hotel-new-york-statue-of-liberty-in-las-vegas-nevada-usa-hd-desktop-wallpaper-1920%C3%971200-wallpaper-preview.jpg", false, 0, new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4040), 4, 0, "https://www.eset.com/", "A brief summary on the article", "[]", "eset" },
                    { 4, "Do you want to see the sea? This your best Hotel", 0, "https://wallpapershome.com/images/pages/ico_h/655.jpg", false, 0, new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4044), 3, 0, "https://me-en.kaspersky.com/", "A brief summary on the article", "[]", "Kaspersky" },
                    { 5, "The best for the best. The place where you can exercise your hiking and other sports.", 0, "https://www.thesouthafrican.com/wp-content/uploads/2022/07/hotel-800x529.png", false, 0, new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4047), 1, 0, "https://phishtank.org/", "A brief summary on the article", "[]", "PhishTank" },
                    { 6, "Sleep for cheap. Cheapest Hotel you may ever found", 0, "https://wallpapercave.com/wp/wp12549190.jpg", false, 0, new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4050), 2, 0, "https://www.virustotal.com/gui/home/upload", "A brief summary on the article", "[]", "VirusTotal" },
                    { 7, "> Hi \n # What do you have today \n \"Good\" `Morning`  ", 0, "file://C:/Users/shmai/source/repos/Security_Guard/wwwroot/Neighbors/Dr.Web.png", false, 0, new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4037), 5, 0, "https://www.drweb.com/", "A brief summary on the article", "[]", "Markdown" }
                });

            migrationBuilder.InsertData(
                table: "Files",
                columns: new[] { "Id", "DateTime", "FileName", "StatusMessage", "URL", "UserName" },
                values: new object[,]
                {
                    { 0, new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(3472), "Virus.pdf", "", "www.virus.com", "Mostafa" },
                    { 1, new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(3518), "Malware.pdf", "", "www.malware.ar", "Mostafa" },
                    { 2, new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(3523), "potato.pdf", "", "www.potato.me", "Mostafa" },
                    { 3, new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(3526), "Virus.pdf", "", "www.virus.com", "Mostafa" },
                    { 4, new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(3529), "Malware.pdf", "", "www.malware.ar", "Mostafa" },
                    { 5, new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(3533), "potato.pdf", "", "www.potato.me", "Mostafa" }
                });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "Id", "DateTime", "Status", "StatusMessage", "URL", "UserName" },
                values: new object[,]
                {
                    { 0, new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(3956), "danger", "", "www.pdf.com.lb.mu.edu", "Mostafa" },
                    { 1, new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(3962), "safe", "", "www.trojans.ar", "Mostafa" },
                    { 2, new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(3967), "ambigious", "", "www.malosd.me", "Mostafa" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "IsAi", "Sender", "Text", "Time" },
                values: new object[,]
                {
                    { 0, false, "Mostafa", "Hello", new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4104) },
                    { 1, true, "AI", "Hi", new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4108) },
                    { 2, false, "Mostafa", "How are you?", new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4111) },
                    { 3, true, "AI", "I'm fine", new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4115) },
                    { 4, false, "Mostafa", "Good", new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4118) },
                    { 5, true, "AI", "Bye", new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4121) },
                    { 6, false, "Mostafa", "Bye", new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4124) },
                    { 7, true, "AI", "Goodbye", new DateTime(2024, 8, 14, 1, 13, 13, 796, DateTimeKind.Local).AddTicks(4127) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
