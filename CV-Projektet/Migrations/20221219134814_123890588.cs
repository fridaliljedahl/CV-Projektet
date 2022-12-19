using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class _123890588 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Sender",
                table: "Messages",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Receiver",
                table: "Messages",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 19, 14, 48, 14, 126, DateTimeKind.Local).AddTicks(4944), new DateTime(2022, 12, 19, 14, 48, 14, 126, DateTimeKind.Local).AddTicks(4936) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 19, 14, 48, 14, 126, DateTimeKind.Local).AddTicks(4958), new DateTime(2022, 12, 19, 14, 48, 14, 126, DateTimeKind.Local).AddTicks(4956) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 19, 14, 48, 14, 126, DateTimeKind.Local).AddTicks(4994), new DateTime(2022, 12, 19, 14, 48, 14, 126, DateTimeKind.Local).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Date", "Receiver", "Sender" },
                values: new object[] { new DateTime(2022, 12, 19, 14, 48, 14, 126, DateTimeKind.Local).AddTicks(2765), 2, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sender",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Receiver",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
                columns: new[] { "Date", "Receiver", "Sender" },
                values: new object[] { new DateTime(2022, 12, 19, 14, 47, 11, 603, DateTimeKind.Local).AddTicks(4671), "user2", "user1" });
        }
    }
}
