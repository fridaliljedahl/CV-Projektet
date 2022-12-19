using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class test1234 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14d27041-703b-48c8-89d1-ba025321a4c1");

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sender = table.Column<int>(type: "int", nullable: false),
                    Receiver = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Read = table.Column<bool>(type: "bit", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8ac76e0b-f48a-4982-8730-fde78f10b7ba", 0, "da00d4a5-d2d7-410e-8c51-7933f1940550", "User", null, false, "Frida", "Liljedahl", false, null, null, null, null, null, false, "d573fdc1-7bde-4eb9-a37e-55313fd66e9e", false, null });

            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "Id", "Date", "Read", "Receiver", "Sender", "Text" },
                values: new object[] { 1, new DateTime(2022, 12, 19, 10, 35, 18, 825, DateTimeKind.Local).AddTicks(3904), false, 2, 1, "hejsan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ac76e0b-f48a-4982-8730-fde78f10b7ba");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "14d27041-703b-48c8-89d1-ba025321a4c1", 0, "fc6fb881-d5e0-4689-b7f6-6ee8fa5af5cc", "User", null, false, "Frida", "Liljedahl", false, null, null, null, null, null, false, "ac5a1ab4-d53c-4f95-9f2f-a331af9e1d48", false, null });
        }
    }
}
