using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class registreringsdatum3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "RegistrationDate", "SecurityStamp" },
                values: new object[] { "dd3fe1e5-674f-4456-a98c-662c18623f70", new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "e535ccc0-7258-4ef1-97f7-76fb28d4b545" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "RegistrationDate", "SecurityStamp" },
                values: new object[] { "0c40e8d2-c139-4efe-a515-ff22d5c53223", new DateTime(2022, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "97eb1d70-1ea7-4a4a-a4cd-8cb6489f353d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "RegistrationDate", "SecurityStamp" },
                values: new object[] { "46468ae1-7921-4e7f-887e-e049197107bc", new DateTime(2022, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "f6a5dae8-f5f5-436a-a8bd-f0743ca41dc7" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 10, 10, 49, 979, DateTimeKind.Local).AddTicks(8928), new DateTime(2022, 12, 26, 10, 10, 49, 979, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 10, 10, 49, 979, DateTimeKind.Local).AddTicks(8942), new DateTime(2022, 12, 26, 10, 10, 49, 979, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 10, 10, 49, 979, DateTimeKind.Local).AddTicks(8953), new DateTime(2022, 12, 26, 10, 10, 49, 979, DateTimeKind.Local).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 26, 10, 10, 49, 979, DateTimeKind.Local).AddTicks(7276));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "RegistrationDate", "SecurityStamp" },
                values: new object[] { "fa723010-6f37-4805-9a10-f0559441283b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2016), "2e4c2a57-aa01-4b83-bd77-3d11fe7cd2e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "RegistrationDate", "SecurityStamp" },
                values: new object[] { "a6a00aa6-e7b1-4989-9c6d-3be20d670431", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2005), "fef06e1f-1a6f-431d-85b0-10fe5cf37507" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "RegistrationDate", "SecurityStamp" },
                values: new object[] { "82d98617-33b7-4dd6-8061-bf347e666044", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1986), "977c7da6-0173-481b-92cd-07c1b778766d" });

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
    }
}
