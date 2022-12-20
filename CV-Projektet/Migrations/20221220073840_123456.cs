using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class _123456 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "652620a0-b17e-4c32-a0e8-e3126ed95cdd", "b490ce23-e2fe-4fbe-be2d-278f12f4e744" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ad21ad29-f293-45d2-b46e-a7ae2d2e6c1a", "c21aabda-9e82-4f2a-a409-f9bcc0b5259e" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 20, 8, 38, 39, 997, DateTimeKind.Local).AddTicks(1148), new DateTime(2022, 12, 20, 8, 38, 39, 997, DateTimeKind.Local).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 20, 8, 38, 39, 997, DateTimeKind.Local).AddTicks(1161), new DateTime(2022, 12, 20, 8, 38, 39, 997, DateTimeKind.Local).AddTicks(1159) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 20, 8, 38, 39, 997, DateTimeKind.Local).AddTicks(1172), new DateTime(2022, 12, 20, 8, 38, 39, 997, DateTimeKind.Local).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 20, 8, 38, 39, 996, DateTimeKind.Local).AddTicks(8985));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e79aa5f3-2c9f-475f-89e9-f19eb0c03bc8", "7f4f13f4-b5cf-474b-8b3e-7ac2d44bf0cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ddaff308-68fb-4de2-85ed-e6706bbf052e", "95586270-bb33-4369-9491-59fd3a28704f" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 20, 8, 29, 55, 209, DateTimeKind.Local).AddTicks(6327), new DateTime(2022, 12, 20, 8, 29, 55, 209, DateTimeKind.Local).AddTicks(6319) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 20, 8, 29, 55, 209, DateTimeKind.Local).AddTicks(6342), new DateTime(2022, 12, 20, 8, 29, 55, 209, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 20, 8, 29, 55, 209, DateTimeKind.Local).AddTicks(6354), new DateTime(2022, 12, 20, 8, 29, 55, 209, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 20, 8, 29, 55, 209, DateTimeKind.Local).AddTicks(4135));
        }
    }
}
