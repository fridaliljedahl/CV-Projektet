using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "Email", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "953decf1-88d1-4f4b-8fd8-08859b81dcfe", "inga@hotmail.com", "073-111 11 11", "3b9f9413-13de-4cdb-863e-f60648f5f54a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "Email", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "9d076e02-02f3-406e-8756-9b4dc51ca0f0", "gunvor@hotmail.se", "073-222 22 22", "2cff8386-c383-4d67-bf9e-bc18e0c5b7b5" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 21, 14, 30, 50, 851, DateTimeKind.Local).AddTicks(9544), new DateTime(2022, 12, 21, 14, 30, 50, 851, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 21, 14, 30, 50, 851, DateTimeKind.Local).AddTicks(9558), new DateTime(2022, 12, 21, 14, 30, 50, 851, DateTimeKind.Local).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 21, 14, 30, 50, 851, DateTimeKind.Local).AddTicks(9570), new DateTime(2022, 12, 21, 14, 30, 50, 851, DateTimeKind.Local).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 21, 14, 30, 50, 851, DateTimeKind.Local).AddTicks(7846));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "Email", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "2debd6c1-7f75-468f-84e3-c7bd9efae82c", null, null, "269c7ce7-23ce-4db6-a104-733d9d5531af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "Email", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "228881e7-6496-49d4-aae5-76a9b36d455f", null, null, "3b57c024-2469-450f-8ece-0c4bf142557b" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 21, 13, 53, 35, 329, DateTimeKind.Local).AddTicks(4027), new DateTime(2022, 12, 21, 13, 53, 35, 329, DateTimeKind.Local).AddTicks(4019) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 21, 13, 53, 35, 329, DateTimeKind.Local).AddTicks(4043), new DateTime(2022, 12, 21, 13, 53, 35, 329, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 21, 13, 53, 35, 329, DateTimeKind.Local).AddTicks(4055), new DateTime(2022, 12, 21, 13, 53, 35, 329, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 21, 13, 53, 35, 329, DateTimeKind.Local).AddTicks(2163));
        }
    }
}
