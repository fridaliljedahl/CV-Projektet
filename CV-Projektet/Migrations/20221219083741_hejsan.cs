using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class hejsan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Projects_ProjectID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ProjectID",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d350c30a-ebd8-4550-b496-ffecb6a7a7da");

            migrationBuilder.DropColumn(
                name: "ProjectID",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "9045b4e8-7a0a-4c15-8c64-e93d2e68dc0d", "User", null, false, "Frida", "Liljedahl", false, null, null, null, null, null, false, "a39b5316-87bc-4988-bb7e-30dd0c6889b3", false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.AddColumn<int>(
                name: "ProjectID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProjectID", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d350c30a-ebd8-4550-b496-ffecb6a7a7da", 0, "de254d3f-b137-4ba0-bb4f-a60443f419a3", "User", null, false, "Frida", "Liljedahl", false, null, null, null, null, null, false, null, "e24741eb-cb62-4987-8ab2-2231db71fd31", false, null });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ProjectID",
                table: "AspNetUsers",
                column: "ProjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Projects_ProjectID",
                table: "AspNetUsers",
                column: "ProjectID",
                principalTable: "Projects",
                principalColumn: "ProjectID");
        }
    }
}
