using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class agerg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare10id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "94ccdd45-7214-4955-bee5-220cf0b853cb", "ea45b752-cfeb-4d72-90ef-e65ac1398629" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1f82aaa2-87a2-4840-b8bf-13fbc80575a0", "ee04a489-dbb8-4761-bf1c-d4455ae1b204" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "54df5ecf-31e5-4788-af75-ab62fcf91d22", "05d9bc1f-d8da-44fd-9a24-33e6b4d28e11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ecc13c37-1f82-4d10-8536-199649cb6471", "a6856235-dc5a-4fcf-9b6f-c8001f17095b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare4id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3a5fe9ca-b80a-45b7-9969-cefe1ab3aacc", "01549392-c4e2-4f56-9f26-71d7b951fa9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare5id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1aa78286-2603-402d-8126-62f5043bfc9b", "ff4dde25-0b83-4921-b98f-2375518a6ef4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare6id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b60baaf4-ab35-424d-bda6-918cb02e4b94", "2717470b-6b1d-4500-8ebd-341aa2a3312e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare7id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4c670139-e555-4e3c-bd33-c00a4a502eec", "898aad14-b685-4dc6-b635-c3b927b0b38f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare8id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e35325a9-5cf2-47a0-b0d4-9e30f947eb23", "ed360548-6d1f-44d3-92a1-ff32b1bb7466" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare9id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "abee0080-bdfd-4171-bf4e-994210461aa2", "b2b5ef65-6bdc-4834-9866-204b73d781b8" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 21, 21, 817, DateTimeKind.Local).AddTicks(6688), new DateTime(2022, 12, 27, 10, 21, 21, 817, DateTimeKind.Local).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 21, 21, 817, DateTimeKind.Local).AddTicks(6694), new DateTime(2022, 12, 27, 10, 21, 21, 817, DateTimeKind.Local).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 21, 21, 817, DateTimeKind.Local).AddTicks(6699), new DateTime(2022, 12, 27, 10, 21, 21, 817, DateTimeKind.Local).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 21, 21, 817, DateTimeKind.Local).AddTicks(6704), new DateTime(2022, 12, 27, 10, 21, 21, 817, DateTimeKind.Local).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 21, 21, 817, DateTimeKind.Local).AddTicks(6708), new DateTime(2022, 12, 27, 10, 21, 21, 817, DateTimeKind.Local).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 27, 10, 21, 21, 817, DateTimeKind.Local).AddTicks(3786));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare10id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "78bbd489-6ebe-4359-aca0-efa066bde72c", "c516b162-3e4a-4cbe-99db-14909b30b839" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "416128f7-aeb7-4d60-8022-5fe0b8e5b64a", "23a4e9cd-48c4-4511-86d9-da604bd2b883" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8e0d5e6d-36c1-49a8-bdca-f618ec23c0f8", "c3cd04d3-2901-418e-ba3c-6b6d9e952965" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3d7ba274-1ae2-4cd8-ab10-235a6c32903c", "9277c05d-9ac7-4273-a1b3-928c7865b998" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare4id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f4511cd7-02f6-4a15-927b-a57748c01141", "f68afdff-05ce-4f6f-a408-1b20f0070c0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare5id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "336c3f59-a1ad-4d63-b240-d61265b62c37", "36f467c0-2128-4bbb-88ed-53d4af5d9022" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare6id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "333b2692-3b9d-4db9-9a63-8cbb551bda31", "90f217bd-5cfa-43d1-8ea0-71276883f549" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare7id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4ce0a7ea-9693-4abe-8c98-030f27102a83", "e23b5b58-d339-4660-8a29-80636ef45117" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare8id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "33e462c5-52f8-44e8-a4ff-263f1f84c12d", "4c5a13cd-bc6a-4d8c-9ba8-8c66c059ed08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare9id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5f1b0431-ecea-4fa0-908c-872c1cde3066", "8c771ce8-4ed9-4b80-9341-3bf00c35bb06" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 22, 4, 18, 124, DateTimeKind.Local).AddTicks(6585), new DateTime(2022, 12, 26, 22, 4, 18, 124, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 22, 4, 18, 124, DateTimeKind.Local).AddTicks(6593), new DateTime(2022, 12, 26, 22, 4, 18, 124, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 22, 4, 18, 124, DateTimeKind.Local).AddTicks(6598), new DateTime(2022, 12, 26, 22, 4, 18, 124, DateTimeKind.Local).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 22, 4, 18, 124, DateTimeKind.Local).AddTicks(6603), new DateTime(2022, 12, 26, 22, 4, 18, 124, DateTimeKind.Local).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 22, 4, 18, 124, DateTimeKind.Local).AddTicks(6609), new DateTime(2022, 12, 26, 22, 4, 18, 124, DateTimeKind.Local).AddTicks(6607) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 26, 22, 4, 18, 124, DateTimeKind.Local).AddTicks(3224));
        }
    }
}
