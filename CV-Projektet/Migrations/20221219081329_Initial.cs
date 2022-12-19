using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83c84485-695d-49d7-ae53-e44a9af023ea");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProjectID", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d350c30a-ebd8-4550-b496-ffecb6a7a7da", 0, "de254d3f-b137-4ba0-bb4f-a60443f419a3", "User", null, false, "Frida", "Liljedahl", false, null, null, null, null, null, false, null, "e24741eb-cb62-4987-8ab2-2231db71fd31", false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d350c30a-ebd8-4550-b496-ffecb6a7a7da");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProjectID", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "83c84485-695d-49d7-ae53-e44a9af023ea", 0, "9d1cf005-1e31-4f39-997b-bfba9c802958", "User", null, false, "Frida", "Liljedahl", false, null, null, null, null, null, false, null, "19e4614e-c2ad-415e-8045-be20b3fbb85b", false, null });
        }
    }
}
