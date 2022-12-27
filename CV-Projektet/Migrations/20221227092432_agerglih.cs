using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class agerglih : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare10id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e2aa879-9a69-4b10-b65d-8ea14becad41", "35d9c86b-3849-4e3c-a53e-7e92da19d6c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a7c6fa81-96f3-4189-b7dd-b7b2d7b6933f", "7ce9d5e1-a017-4492-8c79-6457a0743012" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f9ed08a6-3f3a-4791-9d63-7b1a74c7b97c", "309a9070-2055-400c-b503-32de0e10c2af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "53699ef9-875c-4104-bd92-827b2837a3da", "5b83462b-d79b-463c-bcf0-cfcd042c217b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare4id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "62cf1ec3-0db4-4a5c-b7a4-d3dc000c1b6a", "ea34742e-dd5d-4063-b551-819cbefb132b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare5id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1eced8ca-1733-407f-a089-983a624d8112", "59ae399c-e2aa-4b4e-afc9-4d04002d9dc7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare6id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3a48f55a-d7be-4fcc-97f4-480991fa8203", "4d6325be-0323-475f-87d7-2383c6b50f9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare7id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7c3d48e1-82cd-4e80-a5bd-9220de0024fd", "b9cf03d0-4d99-44d7-bdd8-76e24e72a5e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare8id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4669d382-d9ba-4f8c-bc09-07593d4e39f2", "2eba633c-f727-437c-b78f-69e262f9e3ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare9id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "319e350a-84ba-4301-baa9-024159da424d", "78fbc375-5cb5-4f29-b5d2-53b96f9e5b92" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 24, 31, 699, DateTimeKind.Local).AddTicks(7247), new DateTime(2022, 12, 27, 10, 24, 31, 699, DateTimeKind.Local).AddTicks(7233) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 24, 31, 699, DateTimeKind.Local).AddTicks(7255), new DateTime(2022, 12, 27, 10, 24, 31, 699, DateTimeKind.Local).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 24, 31, 699, DateTimeKind.Local).AddTicks(7260), new DateTime(2022, 12, 27, 10, 24, 31, 699, DateTimeKind.Local).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 24, 31, 699, DateTimeKind.Local).AddTicks(7264), new DateTime(2022, 12, 27, 10, 24, 31, 699, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 24, 31, 699, DateTimeKind.Local).AddTicks(7269), new DateTime(2022, 12, 27, 10, 24, 31, 699, DateTimeKind.Local).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 27, 10, 24, 31, 699, DateTimeKind.Local).AddTicks(4504));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
