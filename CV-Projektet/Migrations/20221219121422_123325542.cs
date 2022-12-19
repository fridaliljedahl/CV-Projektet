using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class _123325542 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2752ccf8-4e4a-49c9-a3d1-f4c92834799d");

            migrationBuilder.AddColumn<int>(
                name: "TimesViewed",
                table: "CVs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProjectsInCV",
                columns: table => new
                {
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    CVID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectsInCV", x => new { x.ProjectID, x.CVID });
                    table.ForeignKey(
                        name: "FK_ProjectsInCV_CVs_CVID",
                        column: x => x.CVID,
                        principalTable: "CVs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectsInCV_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AdressID", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "257891df-561e-4378-9322-03e1dc751dc8", 0, 1, "8c86ec6a-ac5b-46cb-a94a-47a4dcc58931", "User", null, false, "Frida", "Liljedahl", false, null, null, null, null, null, false, null, "29742b16-484c-4394-a946-f8e438b19937", false, null });

            migrationBuilder.InsertData(
                table: "CVs",
                columns: new[] { "ID", "TimesViewed" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 19, 13, 14, 21, 864, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.InsertData(
                table: "ProjectsInCV",
                columns: new[] { "CVID", "ProjectID" },
                values: new object[] { 1, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectsInCV_CVID",
                table: "ProjectsInCV",
                column: "CVID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectsInCV");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "257891df-561e-4378-9322-03e1dc751dc8");

            migrationBuilder.DeleteData(
                table: "CVs",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "TimesViewed",
                table: "CVs");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AdressID", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2752ccf8-4e4a-49c9-a3d1-f4c92834799d", 0, 1, "d30ffda3-aa57-4a9a-abc0-ccd29f470d72", "User", null, false, "Frida", "Liljedahl", false, null, null, null, null, null, false, null, "bf873dfc-e4d4-4e80-98db-89a06763fa0c", false, null });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 19, 12, 56, 44, 683, DateTimeKind.Local).AddTicks(690));
        }
    }
}
