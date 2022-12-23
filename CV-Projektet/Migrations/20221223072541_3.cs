using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8a78789-7c46-4d81-a692-d1666195191c", "mittnamnäringa", "77f90ae4-857c-46c9-b84f-128315fac46c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61113857-812d-4778-bab0-d95f9cb22051", "mittnamnärgunvor", "9316fc16-fdf4-4625-9b11-02b47c13eb27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db6b0aa0-9ba7-4d48-a099-2889cb6f4df0", "mittnamnärjörgen", "957b0348-4127-46a5-ae0b-178846f2fa12" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 23, 8, 25, 40, 843, DateTimeKind.Local).AddTicks(2612), new DateTime(2022, 12, 23, 8, 25, 40, 843, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 23, 8, 25, 40, 843, DateTimeKind.Local).AddTicks(2625), new DateTime(2022, 12, 23, 8, 25, 40, 843, DateTimeKind.Local).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 23, 8, 25, 40, 843, DateTimeKind.Local).AddTicks(2637), new DateTime(2022, 12, 23, 8, 25, 40, 843, DateTimeKind.Local).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 23, 8, 25, 40, 843, DateTimeKind.Local).AddTicks(788));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "685a14df-f33d-4113-98ad-9128f1b2c608", null, "d8e02ba9-0586-42d0-abe6-6b9fa5199c5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0b5ff8a-8131-45b1-8da1-d748a553936f", null, "fead0a8c-29b0-4a90-9e75-c13c4d5372f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "621c52fc-dcb7-466f-9666-2fe18ab705c5", null, "6a256fcb-665a-4078-909a-6f53765ea726" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 23, 8, 23, 10, 516, DateTimeKind.Local).AddTicks(6384), new DateTime(2022, 12, 23, 8, 23, 10, 516, DateTimeKind.Local).AddTicks(6374) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 23, 8, 23, 10, 516, DateTimeKind.Local).AddTicks(6400), new DateTime(2022, 12, 23, 8, 23, 10, 516, DateTimeKind.Local).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 23, 8, 23, 10, 516, DateTimeKind.Local).AddTicks(6415), new DateTime(2022, 12, 23, 8, 23, 10, 516, DateTimeKind.Local).AddTicks(6412) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 23, 8, 23, 10, 516, DateTimeKind.Local).AddTicks(4642));
        }
    }
}
