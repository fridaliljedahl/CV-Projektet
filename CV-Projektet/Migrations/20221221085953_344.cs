using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class _344 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "CVs",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "de481468-3dbd-4cc8-bf52-ea48287d63b5", "4d93f61e-1ffb-4b88-8f01-c518f52df9da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7ffa4be1-7575-4eed-8a44-c35b7bbb65f3", "bec51d34-248a-412c-bb47-991eb40487ce" });

            migrationBuilder.UpdateData(
                table: "CVs",
                keyColumn: "ID",
                keyValue: 1,
                column: "UserID",
                value: "användare1id");

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 21, 9, 59, 52, 21, DateTimeKind.Local).AddTicks(9631), new DateTime(2022, 12, 21, 9, 59, 52, 21, DateTimeKind.Local).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 21, 9, 59, 52, 21, DateTimeKind.Local).AddTicks(9695), new DateTime(2022, 12, 21, 9, 59, 52, 21, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 21, 9, 59, 52, 21, DateTimeKind.Local).AddTicks(9723), new DateTime(2022, 12, 21, 9, 59, 52, 21, DateTimeKind.Local).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 21, 9, 59, 52, 21, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.CreateIndex(
                name: "IX_CVs_UserID",
                table: "CVs",
                column: "UserID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CVs_AspNetUsers_UserID",
                table: "CVs",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CVs_AspNetUsers_UserID",
                table: "CVs");

            migrationBuilder.DropIndex(
                name: "IX_CVs_UserID",
                table: "CVs");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "CVs");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "43a9a3fe-f516-418e-8d0e-59e2328bcbe6", "e158a210-39d3-4def-928e-bd356befaddd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4abd5687-3a0e-490a-abe8-885f808728da", "0e226c82-0410-4510-96c3-8c77237506e9" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 20, 8, 39, 24, 979, DateTimeKind.Local).AddTicks(6887), new DateTime(2022, 12, 20, 8, 39, 24, 979, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 20, 8, 39, 24, 979, DateTimeKind.Local).AddTicks(6901), new DateTime(2022, 12, 20, 8, 39, 24, 979, DateTimeKind.Local).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 20, 8, 39, 24, 979, DateTimeKind.Local).AddTicks(6913), new DateTime(2022, 12, 20, 8, 39, 24, 979, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 20, 8, 39, 24, 979, DateTimeKind.Local).AddTicks(4618));
        }
    }
}
