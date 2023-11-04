using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("2bae4d7a-3ff5-4cca-a4ee-1b052a104c40"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e65cc1b-195d-43b8-ab4e-57d2bebf8344");

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "IsCancelled", "Title", "Venue" },
                values: new object[] { new Guid("b77a10e7-699d-4309-913c-99aacd9db752"), "Konser", "İstanbul", new DateTime(2023, 9, 8, 9, 46, 22, 871, DateTimeKind.Local).AddTicks(8126), "konser", false, "Duman Konseri", "Maltepe" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2e63502d-d5c0-4a1f-8615-396bb71b99c9", 0, null, "f1f5949e-8c28-4981-b98e-a09dd8caf016", "Test", "test@gmail.com", false, false, null, "TEST@GMAIL.COM", "TEST", "AQAAAAIAAYagAAAAELX8M6HFTGvW5kT8xjtycaOUfnXqb1+V6u9HaLm9naXv/tHwI6QzXxSwa3svtQMCrw==", null, false, "8d0a5e17-c8b2-4d6c-a064-8cf924b9903d", false, "Test" });

            migrationBuilder.CreateIndex(
                name: "IX_Images_AppUserId",
                table: "Images",
                column: "AppUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b77a10e7-699d-4309-913c-99aacd9db752"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e63502d-d5c0-4a1f-8615-396bb71b99c9");

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "IsCancelled", "Title", "Venue" },
                values: new object[] { new Guid("2bae4d7a-3ff5-4cca-a4ee-1b052a104c40"), "Konser", "İstanbul", new DateTime(2023, 9, 7, 22, 42, 34, 552, DateTimeKind.Local).AddTicks(8802), "konser", false, "Duman Konseri", "Maltepe" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3e65cc1b-195d-43b8-ab4e-57d2bebf8344", 0, null, "0e970655-6a88-4fa2-a5c1-4368a2527df0", "Test", "test@gmail.com", false, false, null, "TEST@GMAIL.COM", "TEST", "AQAAAAIAAYagAAAAEL6Q4GVbA8Ro7poEM6SKxeuOdKuVIw3XqNA1BtrUZqlflz8YUPhG28oto1+1aVPBcA==", null, false, "95a0f75e-775f-4694-bbb7-79ee1c26e54f", false, "Test" });
        }
    }
}
