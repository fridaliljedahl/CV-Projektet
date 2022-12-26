using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class anvandareAndring2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "IsPrivate", "SecurityStamp" },
                values: new object[] { "d5652167-15a4-4b77-9a03-3a2e6225d9fb", false, "285e545a-432a-4617-8c23-908b1945ee4e" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "IsPrivate", "SecurityStamp" },
                values: new object[] { "2aca9cb2-83d6-48f5-96d1-06ac54493454", true, "0bddeff0-3ae8-456d-b9db-0938f2126b31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "03126e20-5905-4c49-b7a2-c5dcd16aceab", "03d39f41-ed47-4e7e-9961-e33e6a1413ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "11d0950b-c1ae-489a-8bb0-522397aa8667", "328a7e62-811e-46eb-ba66-b32df4c0d4d8" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 37, 34, 361, DateTimeKind.Local).AddTicks(5380), new DateTime(2022, 12, 26, 9, 37, 34, 361, DateTimeKind.Local).AddTicks(5372) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 37, 34, 361, DateTimeKind.Local).AddTicks(5393), new DateTime(2022, 12, 26, 9, 37, 34, 361, DateTimeKind.Local).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 37, 34, 361, DateTimeKind.Local).AddTicks(5405), new DateTime(2022, 12, 26, 9, 37, 34, 361, DateTimeKind.Local).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 26, 9, 37, 34, 361, DateTimeKind.Local).AddTicks(3661));
        }
    }
}
