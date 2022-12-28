using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class jobbmedreg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
