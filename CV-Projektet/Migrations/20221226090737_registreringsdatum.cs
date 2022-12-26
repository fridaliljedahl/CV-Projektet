using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class registreringsdatum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "RegistrationDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "RegistrationDate", "SecurityStamp" },
                values: new object[] { "a0d06103-040f-4971-b376-06a1b0d60473", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2016), "8ebfc4f6-3655-40ff-8d28-de9610ecf087" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "RegistrationDate", "SecurityStamp" },
                values: new object[] { "795bbc66-081d-4952-82c1-0b91c5631f08", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2005), "98735684-616f-48e6-bcd8-0c101bfbee7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "RegistrationDate", "SecurityStamp" },
                values: new object[] { "11d261bc-802e-43e9-8bf6-570c07046628", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1986), "1b52ac8a-5492-4b0e-a41c-7d0b775f4a78" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegistrationDate",
                table: "AspNetUsers");

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
