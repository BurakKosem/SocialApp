using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("64231cb3-12b6-404b-b857-e2b7f92eb9b3"), "Konser", "İstanbul", new DateTime(2023, 9, 7, 13, 48, 25, 297, DateTimeKind.Local).AddTicks(2067), "konser", "Duman Konseri", "Maltepe" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e4057d43-4e65-43ce-aa91-49ac4c4f3616", 0, null, "f09f4e0c-9590-4c53-9997-cee3087f80e8", "Test", "test@gmail.com", false, false, null, "TEST@GMAIL.COM", "TEST", "AQAAAAIAAYagAAAAEKfY8eHGrPxhBYy/cegvwrzEn0Vx+fZ7/klaJY6wLEdH2haNDvW5LQM+Sb5e+3KSmQ==", null, false, "723443e4-56be-4fd7-a3b7-ba266bcacbcc", false, "Test" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("64231cb3-12b6-404b-b857-e2b7f92eb9b3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4057d43-4e65-43ce-aa91-49ac4c4f3616");
        }
    }
}
