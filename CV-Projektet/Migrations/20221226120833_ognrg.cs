using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class ognrg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d41b6102-ee4e-4d4e-b581-ade2fd53fbe3", "b9cb8792-f9f0-4202-8be9-9b419bb5c792" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eb713b5a-27be-47d0-b6bc-34bd4f6367af", "fd3bdc4c-9c27-4015-9bc8-a5217c87f6c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "82a9583f-8cb2-494c-a149-c53172240b6c", "7b35dabc-2a44-4881-862c-4f561f45a917" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 13, 8, 32, 574, DateTimeKind.Local).AddTicks(8995), new DateTime(2022, 12, 26, 13, 8, 32, 574, DateTimeKind.Local).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 13, 8, 32, 574, DateTimeKind.Local).AddTicks(9015), new DateTime(2022, 12, 26, 13, 8, 32, 574, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 13, 8, 32, 574, DateTimeKind.Local).AddTicks(9030), new DateTime(2022, 12, 26, 13, 8, 32, 574, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 26, 13, 8, 32, 574, DateTimeKind.Local).AddTicks(5966));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d5652167-15a4-4b77-9a03-3a2e6225d9fb", "285e545a-432a-4617-8c23-908b1945ee4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1bc90d73-5311-4528-9aec-675899451d1e", "73f4dff5-2f68-44af-89ae-e18029304b5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "97745366-f223-4a3a-a9b7-2c74dcdc8898", "0485c9f9-78b0-44ee-b9e2-493b957c3419" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 38, 56, 916, DateTimeKind.Local).AddTicks(9489), new DateTime(2022, 12, 26, 9, 38, 56, 916, DateTimeKind.Local).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 38, 56, 916, DateTimeKind.Local).AddTicks(9503), new DateTime(2022, 12, 26, 9, 38, 56, 916, DateTimeKind.Local).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 38, 56, 916, DateTimeKind.Local).AddTicks(9515), new DateTime(2022, 12, 26, 9, 38, 56, 916, DateTimeKind.Local).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 26, 9, 38, 56, 916, DateTimeKind.Local).AddTicks(7748));
        }
    }
}
