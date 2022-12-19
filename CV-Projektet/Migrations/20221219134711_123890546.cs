using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class _123890546 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 19, 14, 47, 11, 603, DateTimeKind.Local).AddTicks(6759), new DateTime(2022, 12, 19, 14, 47, 11, 603, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 19, 14, 47, 11, 603, DateTimeKind.Local).AddTicks(6774), new DateTime(2022, 12, 19, 14, 47, 11, 603, DateTimeKind.Local).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 19, 14, 47, 11, 603, DateTimeKind.Local).AddTicks(6786), new DateTime(2022, 12, 19, 14, 47, 11, 603, DateTimeKind.Local).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 19, 14, 47, 11, 603, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "AdressID", "FirstName", "LastName", "ProfilePicture" },
                values: new object[] { 2, 1, "hej", "hejsan", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 19, 14, 46, 3, 166, DateTimeKind.Local).AddTicks(230), new DateTime(2022, 12, 19, 14, 46, 3, 166, DateTimeKind.Local).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 19, 14, 46, 3, 166, DateTimeKind.Local).AddTicks(244), new DateTime(2022, 12, 19, 14, 46, 3, 166, DateTimeKind.Local).AddTicks(242) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 19, 14, 46, 3, 166, DateTimeKind.Local).AddTicks(255), new DateTime(2022, 12, 19, 14, 46, 3, 166, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 19, 14, 46, 3, 165, DateTimeKind.Local).AddTicks(8148));
        }
    }
}
