using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class TestarIgen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProjectID", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "83c84485-695d-49d7-ae53-e44a9af023ea", 0, "9d1cf005-1e31-4f39-997b-bfba9c802958", "User", null, false, "Frida", "Liljedahl", false, null, null, null, null, null, false, null, "19e4614e-c2ad-415e-8045-be20b3fbb85b", false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83c84485-695d-49d7-ae53-e44a9af023ea");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProjectID", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "8fdc83c9-8381-4ad4-b958-63eab99d3676", "User", null, false, "Frida", "Liljedahl", false, null, null, null, null, null, false, null, "f129f411-c9f8-4c2f-9569-58988af0ec0d", false, null });
        }
    }
}
