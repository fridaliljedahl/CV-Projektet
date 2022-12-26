using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class anvandareAndring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPrivate",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "IsActive", "IsPrivate", "SecurityStamp" },
                values: new object[] { "2aca9cb2-83d6-48f5-96d1-06ac54493454", true, true, "0bddeff0-3ae8-456d-b9db-0938f2126b31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "IsActive", "IsPrivate", "SecurityStamp" },
                values: new object[] { "03126e20-5905-4c49-b7a2-c5dcd16aceab", true, true, "03d39f41-ed47-4e7e-9961-e33e6a1413ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "IsActive", "SecurityStamp" },
                values: new object[] { "11d0950b-c1ae-489a-8bb0-522397aa8667", true, "328a7e62-811e-46eb-ba66-b32df4c0d4d8" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsPrivate",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "40a9f467-abb3-4d78-a1f1-817c593e8ade", "2f66bcb8-0599-469b-9759-da2b055b0cce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f204579f-6426-423c-86f5-c8c253abca08", "7c8f03e7-2f6c-4b94-9a98-50fc6dd6f56f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0604e39d-2da0-43f9-ac5a-58f751de95e8", "acb0e3f2-b7c2-49bd-8b48-fe65b3d72f69" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 23, 10, 52, 18, 605, DateTimeKind.Local).AddTicks(1788), new DateTime(2022, 12, 23, 10, 52, 18, 605, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 23, 10, 52, 18, 605, DateTimeKind.Local).AddTicks(1807), new DateTime(2022, 12, 23, 10, 52, 18, 605, DateTimeKind.Local).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 23, 10, 52, 18, 605, DateTimeKind.Local).AddTicks(1822), new DateTime(2022, 12, 23, 10, 52, 18, 605, DateTimeKind.Local).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 23, 10, 52, 18, 604, DateTimeKind.Local).AddTicks(8692));
        }
    }
}
