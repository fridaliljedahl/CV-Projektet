using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class ett : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

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

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AdressID", "ConcurrencyStamp", "Description", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "användare1id", 0, 1, "e8a78789-7c46-4d81-a692-d1666195191c", "Hejaaa", "User", "inga@hotmail.com", false, "Inga", "Karlsson", false, null, null, null, "mittnamnäringa", "073-111 11 11", false, null, "77f90ae4-857c-46c9-b84f-128315fac46c", false, null },
                    { "användare2id", 0, 1, "61113857-812d-4778-bab0-d95f9cb22051", "Halloj", "User", "gunvor@hotmail.se", false, "Gunvor", "Nilsson", false, null, null, null, "mittnamnärgunvor", "073-222 22 22", false, null, "9316fc16-fdf4-4625-9b11-02b47c13eb27", false, null },
                    { "användare3id", 0, 1, "db6b0aa0-9ba7-4d48-a099-2889cb6f4df0", "dfggdffdgfdgdffdggdf", "User", "Jögge@hotmail.se", false, "Jörgen", "Svensson", false, null, null, null, "mittnamnärjörgen", "073-333 33 33", false, null, "957b0348-4127-46a5-ae0b-178846f2fa12", false, null }
                });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 23, 8, 25, 40, 843, DateTimeKind.Local).AddTicks(2612), new DateTime(2022, 12, 23, 8, 25, 40, 843, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 23, 8, 25, 40, 843, DateTimeKind.Local).AddTicks(2625), new DateTime(2022, 12, 23, 8, 25, 40, 843, DateTimeKind.Local).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 23, 8, 25, 40, 843, DateTimeKind.Local).AddTicks(2637), new DateTime(2022, 12, 23, 8, 25, 40, 843, DateTimeKind.Local).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 23, 8, 25, 40, 843, DateTimeKind.Local).AddTicks(788));
        }
    }
}
