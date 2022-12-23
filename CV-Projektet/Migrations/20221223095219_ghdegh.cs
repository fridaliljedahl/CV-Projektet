using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class ghdegh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Addresses_AdressID",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<int>(
                name: "AdressID",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Addresses_AdressID",
                table: "AspNetUsers",
                column: "AdressID",
                principalTable: "Addresses",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Addresses_AdressID",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdressID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "647e899f-bd87-4280-b0c8-f8e52dcbed3c", "d9c39d97-9403-4787-a584-2782bf24adb1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0c6a5c08-b92a-4198-8efc-ca38f2bc6283", "570194eb-2b15-4faa-94dd-d4cb2c301300" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "25482926-0aa9-4d6b-8bd0-7d7489ddc029", "bb880c09-cab0-494c-a8c6-333a2bc22c65" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 23, 10, 46, 25, 359, DateTimeKind.Local).AddTicks(2679), new DateTime(2022, 12, 23, 10, 46, 25, 359, DateTimeKind.Local).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 23, 10, 46, 25, 359, DateTimeKind.Local).AddTicks(2702), new DateTime(2022, 12, 23, 10, 46, 25, 359, DateTimeKind.Local).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 23, 10, 46, 25, 359, DateTimeKind.Local).AddTicks(2718), new DateTime(2022, 12, 23, 10, 46, 25, 359, DateTimeKind.Local).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 23, 10, 46, 25, 358, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Addresses_AdressID",
                table: "AspNetUsers",
                column: "AdressID",
                principalTable: "Addresses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
