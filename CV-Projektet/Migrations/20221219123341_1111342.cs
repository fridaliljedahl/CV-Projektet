using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class _1111342 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8afec1f8-58a1-47ed-9cc1-07b012b33a66");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AdressID", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d2781d92-66f8-4479-8fde-233878a31ac0", 0, 1, "2bd7e173-5a5a-4011-ad0d-bb06d416058f", "User", null, false, "Frida", "Liljedahl", false, null, null, null, null, null, false, null, "f7541832-8629-4030-a753-5be1c0a03c36", false, null });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 19, 13, 33, 40, 689, DateTimeKind.Local).AddTicks(8011), new DateTime(2022, 12, 19, 13, 33, 40, 689, DateTimeKind.Local).AddTicks(8001) });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "ID", "CVID", "City", "Description", "Discriminator", "EndDate", "LocationName", "Name", "StartDate" },
                values: new object[] { 2, 1, "Örebro", "Java", "Education", new DateTime(2022, 12, 19, 13, 33, 40, 690, DateTimeKind.Local).AddTicks(2989), "Örebro Universitet", "Systemvetenskap", new DateTime(2022, 12, 19, 13, 33, 40, 690, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "ID", "CVID", "City", "Description", "Discriminator", "EndDate", "LocationName", "StartDate" },
                values: new object[] { 3, 1, "Göteborg", "HLR-utbildning", "Experience", new DateTime(2022, 12, 19, 13, 33, 40, 690, DateTimeKind.Local).AddTicks(3018), "Företaget", new DateTime(2022, 12, 19, 13, 33, 40, 690, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 19, 13, 33, 40, 689, DateTimeKind.Local).AddTicks(1483));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2781d92-66f8-4479-8fde-233878a31ac0");

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Experiences");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AdressID", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8afec1f8-58a1-47ed-9cc1-07b012b33a66", 0, 1, "5e43b5b1-d83c-4fb2-94e1-d343588bd0bc", "User", null, false, "Frida", "Liljedahl", false, null, null, null, null, null, false, null, "9d52c873-4ae6-4079-acc4-6f072c54d0e4", false, null });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 19, 13, 28, 47, 269, DateTimeKind.Local).AddTicks(4970), new DateTime(2022, 12, 19, 13, 28, 47, 269, DateTimeKind.Local).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 19, 13, 28, 47, 268, DateTimeKind.Local).AddTicks(8299));
        }
    }
}
