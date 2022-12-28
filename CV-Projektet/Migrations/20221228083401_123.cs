using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class _123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Addresses_AdressID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
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
                values: new object[] { "30699fb3-79d0-477c-bd66-98ad4a4c87c5", "77c9b045-697a-4666-a32a-13c43b645f01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2c11c249-4667-45fc-af8b-d09132178aed", "2485a9f1-a183-412e-91d6-edaea749e2a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "db3e3677-a576-42fd-98e9-98eb09f4cd51", "50bd76eb-80fc-4a87-b341-ef3b819befcd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f1efee94-4df3-4bf4-bd84-71f6f4e4fdda", "27c6e33e-f56e-4872-b65a-2f667fa7fd05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare4id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0f53793a-3062-41c2-9a0b-8131e6715b28", "ceea908d-3aa1-4ece-8222-60b58c7772f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare5id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a0e33e92-5cf6-4f8e-995c-67c2e803f2ac", "39eae402-596d-4aac-abba-d70583d4f310" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare6id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3c99feec-b136-4bb5-8f29-68feda3a827e", "b0bffb6d-c77f-478d-a9ec-5ba5f3e37742" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare7id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "92ffab60-6993-4ed7-9ffb-144647d998f4", "eda9f865-2409-498c-bd45-a4eb4e5dd414" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare8id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4a27011b-58e6-4da7-8e85-1ba8fe71ec4e", "b8aea2bf-77f2-4c3f-b5ca-4e9b4f3653a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare9id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "467040b1-415c-4f15-87c1-3a1deeb40535", "22fac48f-85f0-46e4-a0d1-ab73c5311328" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 28, 9, 34, 1, 491, DateTimeKind.Local).AddTicks(3376), new DateTime(2022, 12, 28, 9, 34, 1, 491, DateTimeKind.Local).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 28, 9, 34, 1, 491, DateTimeKind.Local).AddTicks(3380), new DateTime(2022, 12, 28, 9, 34, 1, 491, DateTimeKind.Local).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 28, 9, 34, 1, 491, DateTimeKind.Local).AddTicks(3384), new DateTime(2022, 12, 28, 9, 34, 1, 491, DateTimeKind.Local).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 28, 9, 34, 1, 491, DateTimeKind.Local).AddTicks(3388), new DateTime(2022, 12, 28, 9, 34, 1, 491, DateTimeKind.Local).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 28, 9, 34, 1, 491, DateTimeKind.Local).AddTicks(3392), new DateTime(2022, 12, 28, 9, 34, 1, 491, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 28, 9, 34, 1, 491, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Addresses_AdressID",
                table: "AspNetUsers",
                column: "AdressID",
                principalTable: "Addresses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.AlterColumn<int>(
                name: "AdressID",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare10id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "828561df-74fa-4845-9a8c-3bd22edc1bc3", "f1d76b4b-afa9-456a-971d-744287f49b85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5a8e6eaf-622f-4fe9-aba6-148baaadd14a", "ae31497d-0c78-4aa7-8097-a0875aed57a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "72b24609-7678-4824-b300-f3f456464510", "a1180c23-498c-4091-a912-18714775b49b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "29e321f0-1b57-4bbb-a6ea-fe616879c0ac", "ab801e4f-dd1e-43d6-a566-2a05b65f7310" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare4id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ce5fa78b-6b11-42c3-91e6-11160da57867", "ccce1c5a-8c57-4757-a4b0-e7f2f5d1c079" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare5id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6b9ada02-95fc-43ee-869c-572ee7399c99", "694389a2-ed0d-427c-9407-d77f31a47f31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare6id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cf1b1d96-1c86-4f94-b360-f91b3986c03f", "0d539acf-6e5d-4a0f-b042-6b0a90a5cd2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare7id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "be5ce2d3-d4b0-4d8e-8973-d9dccd89bb59", "e73e4472-de75-4c43-a041-d275904cd51f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare8id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ec453276-5916-46f7-8f4b-3fb3bf2985b9", "ba71be4a-3747-41c2-bf52-092e1686a66a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare9id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "762cdf22-57bf-40e1-ae97-f3c839ddb0b5", "22ab3823-0fd6-44ea-b5e9-2966d32b75f2" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 13, 24, 29, 654, DateTimeKind.Local).AddTicks(2798), new DateTime(2022, 12, 27, 13, 24, 29, 654, DateTimeKind.Local).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 13, 24, 29, 654, DateTimeKind.Local).AddTicks(2803), new DateTime(2022, 12, 27, 13, 24, 29, 654, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 13, 24, 29, 654, DateTimeKind.Local).AddTicks(2807), new DateTime(2022, 12, 27, 13, 24, 29, 654, DateTimeKind.Local).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 13, 24, 29, 654, DateTimeKind.Local).AddTicks(2810), new DateTime(2022, 12, 27, 13, 24, 29, 654, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 13, 24, 29, 654, DateTimeKind.Local).AddTicks(2814), new DateTime(2022, 12, 27, 13, 24, 29, 654, DateTimeKind.Local).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 27, 13, 24, 29, 654, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Addresses_AdressID",
                table: "AspNetUsers",
                column: "AdressID",
                principalTable: "Addresses",
                principalColumn: "ID");
        }
    }
}
