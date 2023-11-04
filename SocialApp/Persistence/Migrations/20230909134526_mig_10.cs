using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("0da30c20-f1cd-4afe-ae8d-09ef45a6b971"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5648219-81dd-416c-8bc3-90180daeef8b");

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "IsCancelled", "Title", "Venue" },
                values: new object[] { new Guid("cdecde2c-a266-4e0a-86f7-532e97263edd"), "Konser", "İstanbul", new DateTime(2023, 9, 9, 16, 45, 26, 422, DateTimeKind.Local).AddTicks(3565), "konser", false, "Duman Konseri", "Maltepe" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b2d477dd-374d-4bcc-b40f-99819eaf3ac3", 0, null, "55ca8172-9d43-4bbb-8534-d4b567a21c21", "Test", "test@gmail.com", false, false, null, "TEST@GMAIL.COM", "TEST", "AQAAAAIAAYagAAAAEPSFSLXGFpIXBSYvTKZtZtCUctnwBKjTRQNiOL+w01ILEPc9SAqD3d1JmyrTm73HhA==", null, false, "5a256038-c8f1-4cc2-9cf7-b470ea407662", false, "Test" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("cdecde2c-a266-4e0a-86f7-532e97263edd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2d477dd-374d-4bcc-b40f-99819eaf3ac3");

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "IsCancelled", "Title", "Venue" },
                values: new object[] { new Guid("0da30c20-f1cd-4afe-ae8d-09ef45a6b971"), "Konser", "İstanbul", new DateTime(2023, 9, 9, 16, 44, 37, 890, DateTimeKind.Local).AddTicks(9731), "konser", false, "Duman Konseri", "Maltepe" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f5648219-81dd-416c-8bc3-90180daeef8b", 0, null, "9db03829-7e65-40eb-9f95-d1597ec4427c", "Test", "test@gmail.com", false, false, null, "TEST@GMAIL.COM", "TEST", "AQAAAAIAAYagAAAAEMtLesBwK6oZt5gYZ6VKry/4cgER/lJ9QQLOHWNaVkuqWVKP+aPouAF9mapkXEwByg==", null, false, "b75d0b58-629e-4941-b141-36646c9a4ad9", false, "Test" });
        }
    }
}
