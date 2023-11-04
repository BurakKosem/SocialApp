using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("fa6ab135-a8d5-4048-bad3-f157db13e532"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bf7c437-0daa-48a3-a6dc-660f04346211");

            migrationBuilder.AddColumn<bool>(
                name: "IsCancelled",
                table: "Activities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "IsCancelled", "Title", "Venue" },
                values: new object[] { new Guid("48260496-12f1-4c28-8caf-9f6fd052b5f4"), "Konser", "İstanbul", new DateTime(2023, 9, 7, 22, 18, 40, 354, DateTimeKind.Local).AddTicks(8135), "konser", false, "Duman Konseri", "Maltepe" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fdbfbdb8-e11c-4bfe-bcfb-f6fded543bb4", 0, null, "a6fe1d5a-0a8d-48c3-9bfa-b911e6b62057", "Test", "test@gmail.com", false, false, null, "TEST@GMAIL.COM", "TEST", "AQAAAAIAAYagAAAAEBaShDme7JNHq97lMqjNXzCnp4I5bAen7lMg9doQMk1zwzzF0KDL2+HT9X3c1CQ7ug==", null, false, "cfc67833-ca95-4793-ae0b-f77340c2b22a", false, "Test" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("48260496-12f1-4c28-8caf-9f6fd052b5f4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fdbfbdb8-e11c-4bfe-bcfb-f6fded543bb4");

            migrationBuilder.DropColumn(
                name: "IsCancelled",
                table: "Activities");

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("fa6ab135-a8d5-4048-bad3-f157db13e532"), "Konser", "İstanbul", new DateTime(2023, 9, 7, 21, 24, 4, 40, DateTimeKind.Local).AddTicks(992), "konser", "Duman Konseri", "Maltepe" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0bf7c437-0daa-48a3-a6dc-660f04346211", 0, null, "f1d8718c-95e9-40ff-a3ae-39891340209d", "Test", "test@gmail.com", false, false, null, "TEST@GMAIL.COM", "TEST", "AQAAAAIAAYagAAAAELHSdhnCluK26lP6lw6Gx6IV7ogRMMA3PjP0ulu1kedNID3Yu50uLfKthL4na3WROw==", null, false, "885dbec9-34c2-4b59-afed-e3236dd0f5a7", false, "Test" });
        }
    }
}
