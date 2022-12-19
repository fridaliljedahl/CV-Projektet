using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class _1111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "257891df-561e-4378-9322-03e1dc751dc8");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Experiences");

            migrationBuilder.RenameColumn(
                name: "CV",
                table: "Experiences",
                newName: "CVID");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AdressID", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8afec1f8-58a1-47ed-9cc1-07b012b33a66", 0, 1, "5e43b5b1-d83c-4fb2-94e1-d343588bd0bc", "User", null, false, "Frida", "Liljedahl", false, null, null, null, null, null, false, null, "9d52c873-4ae6-4079-acc4-6f072c54d0e4", false, null });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "ID", "CVID", "City", "Description", "Discriminator", "EndDate", "LocationName", "RoleName", "StartDate" },
                values: new object[] { 1, 1, "Lund", "pratade i telefon", "Work", new DateTime(2022, 12, 19, 13, 28, 47, 269, DateTimeKind.Local).AddTicks(4970), "ICA", "Kundtjänst", new DateTime(2022, 12, 19, 13, 28, 47, 269, DateTimeKind.Local).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 19, 13, 28, 47, 268, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_CVID",
                table: "Experiences",
                column: "CVID");

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_CVs_CVID",
                table: "Experiences",
                column: "CVID",
                principalTable: "CVs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_CVs_CVID",
                table: "Experiences");

            migrationBuilder.DropIndex(
                name: "IX_Experiences_CVID",
                table: "Experiences");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8afec1f8-58a1-47ed-9cc1-07b012b33a66");

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "CVID",
                table: "Experiences",
                newName: "CV");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AdressID", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "257891df-561e-4378-9322-03e1dc751dc8", 0, 1, "8c86ec6a-ac5b-46cb-a94a-47a4dcc58931", "User", null, false, "Frida", "Liljedahl", false, null, null, null, null, null, false, null, "29742b16-484c-4394-a946-f8e438b19937", false, null });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 19, 13, 14, 21, 864, DateTimeKind.Local).AddTicks(776));
        }
    }
}
