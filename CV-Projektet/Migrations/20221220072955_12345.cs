using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class _12345 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CVs_Competences_CompetenceID",
                table: "CVs");

            migrationBuilder.DropIndex(
                name: "IX_CVs_CompetenceID",
                table: "CVs");

            migrationBuilder.DropColumn(
                name: "CompetenceID",
                table: "CVs");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompetenceID",
                table: "CVs",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0e48067c-b8ab-41b7-8d21-eece8738ca41", "f49b7fa4-7514-493b-8deb-f9cebfaa0d6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f9c6bd57-e53c-49b7-8f80-2ea5b26a97db", "437d7718-cf6c-4a44-a9ab-fa4cdfbcf3e9" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 20, 8, 27, 8, 941, DateTimeKind.Local).AddTicks(7199), new DateTime(2022, 12, 20, 8, 27, 8, 941, DateTimeKind.Local).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 20, 8, 27, 8, 941, DateTimeKind.Local).AddTicks(7212), new DateTime(2022, 12, 20, 8, 27, 8, 941, DateTimeKind.Local).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 20, 8, 27, 8, 941, DateTimeKind.Local).AddTicks(7223), new DateTime(2022, 12, 20, 8, 27, 8, 941, DateTimeKind.Local).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 20, 8, 27, 8, 941, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.CreateIndex(
                name: "IX_CVs_CompetenceID",
                table: "CVs",
                column: "CompetenceID");

            migrationBuilder.AddForeignKey(
                name: "FK_CVs_Competences_CompetenceID",
                table: "CVs",
                column: "CompetenceID",
                principalTable: "Competences",
                principalColumn: "ID");
        }
    }
}
