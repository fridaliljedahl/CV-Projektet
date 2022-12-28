using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class jobbmedreg2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Addresses_AdressID",
                table: "AspNetUsers");

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
                keyValue: "användare10id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9741f4a6-5013-4862-9745-d3fc1d41db52", "841c4607-6a30-45ec-bb34-8d8823588773" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "04cf3519-c86a-4449-833d-c417c0a75e5b", "da321e6b-6834-4763-a920-45a05c3fa509" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e3508232-c90f-4566-af70-10c584ac096f", "4821d8fc-8c6d-4801-b756-492eb19201e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "843da5cf-81cd-467d-949c-f340008ad734", "14d914d0-7671-49e8-a7a1-8fd7719915ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare4id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "caf208fa-786a-4dbb-8d72-829114a3e82f", "e094e9a2-6e3a-40f9-801f-26aae07079ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare5id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2efbf7a8-1272-4f6c-9187-3347a777f005", "64f33a36-d8ec-446f-ae07-b1c776841d1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare6id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "db02fe92-529b-4a41-869c-37c9eda7b074", "fc340f24-35fb-4954-8a1a-5a8b7799e230" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare7id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "902d095a-b5b8-4715-b11f-500517839ee9", "f5991f08-de6f-4d4b-a811-e9c5772f60bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare8id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5b7c7c52-731e-49bc-b729-22d5931fc67b", "871eb2a2-c1ec-491d-be93-51d5c6623f84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare9id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e5c1e67e-a5b7-43a7-896a-cac70abd8479", "0d58d65f-675a-408f-890b-c5c255be3986" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 28, 13, 43, 11, 538, DateTimeKind.Local).AddTicks(4871), new DateTime(2022, 12, 28, 13, 43, 11, 538, DateTimeKind.Local).AddTicks(4864) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 28, 13, 43, 11, 538, DateTimeKind.Local).AddTicks(4876), new DateTime(2022, 12, 28, 13, 43, 11, 538, DateTimeKind.Local).AddTicks(4874) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 28, 13, 43, 11, 538, DateTimeKind.Local).AddTicks(4880), new DateTime(2022, 12, 28, 13, 43, 11, 538, DateTimeKind.Local).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 28, 13, 43, 11, 538, DateTimeKind.Local).AddTicks(4884), new DateTime(2022, 12, 28, 13, 43, 11, 538, DateTimeKind.Local).AddTicks(4882) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 28, 13, 43, 11, 538, DateTimeKind.Local).AddTicks(4887), new DateTime(2022, 12, 28, 13, 43, 11, 538, DateTimeKind.Local).AddTicks(4886) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 28, 13, 43, 11, 538, DateTimeKind.Local).AddTicks(3144));

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
                keyValue: "användare10id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "88ebd78c-763d-4336-b4e5-d77e655e0d59", "748d9058-9314-49fa-bc97-7195f39d513d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "036bceef-0c05-477e-8ccc-8ac363440465", "9be2a788-1308-44c4-88bf-5fecd1e531ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2a0131c7-a66e-41ee-a2bb-00f854a6c60f", "89cf6706-aee5-4988-be25-3c107c80f6eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ff1e762d-f646-4623-bb78-396a8b632b0e", "9794887b-de51-4e73-ba7c-276fc486b366" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare4id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ceaa8920-6dc0-4caa-87d0-8f2d2a72b75d", "7466a91e-d623-41ad-af5d-356e8ce71e2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare5id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "99fb2088-b062-463e-9244-237d1d00e323", "f210bfa6-2160-4ee8-b11d-ca92a904d73b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare6id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dff39a4c-25dd-44f3-8778-4d37ac3d5389", "382f4d6a-c4da-4e67-ba4c-c1c50351827c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare7id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1b8ccb03-906e-4fb1-9894-dc556a81bae7", "86f9adef-e1f8-4607-a4cc-ed01fc82c648" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare8id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "12c31294-036e-4e44-87d0-6ec9cdebccd2", "3b383713-dcea-41ca-96b9-fad2ded8cd45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare9id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "73836f18-a7f7-4b6e-a83c-8e0e006eb158", "5f57a584-4f7c-4dc0-89d3-71ea1ddd8997" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 28, 13, 38, 31, 305, DateTimeKind.Local).AddTicks(8666), new DateTime(2022, 12, 28, 13, 38, 31, 305, DateTimeKind.Local).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 28, 13, 38, 31, 305, DateTimeKind.Local).AddTicks(8671), new DateTime(2022, 12, 28, 13, 38, 31, 305, DateTimeKind.Local).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 28, 13, 38, 31, 305, DateTimeKind.Local).AddTicks(8675), new DateTime(2022, 12, 28, 13, 38, 31, 305, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 28, 13, 38, 31, 305, DateTimeKind.Local).AddTicks(8678), new DateTime(2022, 12, 28, 13, 38, 31, 305, DateTimeKind.Local).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 28, 13, 38, 31, 305, DateTimeKind.Local).AddTicks(8682), new DateTime(2022, 12, 28, 13, 38, 31, 305, DateTimeKind.Local).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 28, 13, 38, 31, 305, DateTimeKind.Local).AddTicks(6949));

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
