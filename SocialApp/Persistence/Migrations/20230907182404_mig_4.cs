using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("64231cb3-12b6-404b-b857-e2b7f92eb9b3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4057d43-4e65-43ce-aa91-49ac4c4f3616");

            migrationBuilder.CreateTable(
                name: "ActivityAtendees",
                columns: table => new
                {
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsHost = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityAtendees", x => new { x.AppUserId, x.ActivityId });
                    table.ForeignKey(
                        name: "FK_ActivityAtendees_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityAtendees_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("fa6ab135-a8d5-4048-bad3-f157db13e532"), "Konser", "İstanbul", new DateTime(2023, 9, 7, 21, 24, 4, 40, DateTimeKind.Local).AddTicks(992), "konser", "Duman Konseri", "Maltepe" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0bf7c437-0daa-48a3-a6dc-660f04346211", 0, null, "f1d8718c-95e9-40ff-a3ae-39891340209d", "Test", "test@gmail.com", false, false, null, "TEST@GMAIL.COM", "TEST", "AQAAAAIAAYagAAAAELHSdhnCluK26lP6lw6Gx6IV7ogRMMA3PjP0ulu1kedNID3Yu50uLfKthL4na3WROw==", null, false, "885dbec9-34c2-4b59-afed-e3236dd0f5a7", false, "Test" });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityAtendees_ActivityId",
                table: "ActivityAtendees",
                column: "ActivityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityAtendees");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("fa6ab135-a8d5-4048-bad3-f157db13e532"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bf7c437-0daa-48a3-a6dc-660f04346211");

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("64231cb3-12b6-404b-b857-e2b7f92eb9b3"), "Konser", "İstanbul", new DateTime(2023, 9, 7, 13, 48, 25, 297, DateTimeKind.Local).AddTicks(2067), "konser", "Duman Konseri", "Maltepe" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e4057d43-4e65-43ce-aa91-49ac4c4f3616", 0, null, "f09f4e0c-9590-4c53-9997-cee3087f80e8", "Test", "test@gmail.com", false, false, null, "TEST@GMAIL.COM", "TEST", "AQAAAAIAAYagAAAAEKfY8eHGrPxhBYy/cegvwrzEn0Vx+fZ7/klaJY6wLEdH2haNDvW5LQM+Sb5e+3KSmQ==", null, false, "723443e4-56be-4fd7-a3b7-ba266bcacbcc", false, "Test" });
        }
    }
}
