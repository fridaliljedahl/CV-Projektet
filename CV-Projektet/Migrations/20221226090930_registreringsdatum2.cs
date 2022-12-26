using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class registreringsdatum2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsPrivate",
                table: "AspNetUsers",
                newName: "IsPublic");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "IsPublic", "SecurityStamp" },
                values: new object[] { "fa723010-6f37-4805-9a10-f0559441283b", true, "2e4c2a57-aa01-4b83-bd77-3d11fe7cd2e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "IsPublic", "SecurityStamp" },
                values: new object[] { "a6a00aa6-e7b1-4989-9c6d-3be20d670431", false, "fef06e1f-1a6f-431d-85b0-10fe5cf37507" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "IsPublic", "SecurityStamp" },
                values: new object[] { "82d98617-33b7-4dd6-8061-bf347e666044", true, "977c7da6-0173-481b-92cd-07c1b778766d" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 10, 9, 30, 78, DateTimeKind.Local).AddTicks(2486), new DateTime(2022, 12, 26, 10, 9, 30, 78, DateTimeKind.Local).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 10, 9, 30, 78, DateTimeKind.Local).AddTicks(2499), new DateTime(2022, 12, 26, 10, 9, 30, 78, DateTimeKind.Local).AddTicks(2497) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 10, 9, 30, 78, DateTimeKind.Local).AddTicks(2511), new DateTime(2022, 12, 26, 10, 9, 30, 78, DateTimeKind.Local).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 26, 10, 9, 30, 78, DateTimeKind.Local).AddTicks(764));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsPublic",
                table: "AspNetUsers",
                newName: "IsPrivate");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "IsPrivate", "SecurityStamp" },
                values: new object[] { "a0d06103-040f-4971-b376-06a1b0d60473", false, "8ebfc4f6-3655-40ff-8d28-de9610ecf087" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "IsPrivate", "SecurityStamp" },
                values: new object[] { "795bbc66-081d-4952-82c1-0b91c5631f08", true, "98735684-616f-48e6-bcd8-0c101bfbee7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "IsPrivate", "SecurityStamp" },
                values: new object[] { "11d261bc-802e-43e9-8bf6-570c07046628", false, "1b52ac8a-5492-4b0e-a41c-7d0b775f4a78" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 10, 7, 36, 720, DateTimeKind.Local).AddTicks(637), new DateTime(2022, 12, 26, 10, 7, 36, 720, DateTimeKind.Local).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 10, 7, 36, 720, DateTimeKind.Local).AddTicks(650), new DateTime(2022, 12, 26, 10, 7, 36, 720, DateTimeKind.Local).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 10, 7, 36, 720, DateTimeKind.Local).AddTicks(662), new DateTime(2022, 12, 26, 10, 7, 36, 720, DateTimeKind.Local).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 26, 10, 7, 36, 719, DateTimeKind.Local).AddTicks(8815));
        }
    }
}
