using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class uppdatTestdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare10id",
                columns: new[] { "ConcurrencyStamp", "IsPublic", "SecurityStamp" },
                values: new object[] { "4a4ec1ee-af0c-4e44-afbb-6c22158fcbca", true, "dda11059-1621-441c-9aaf-05ceb720dc58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "db4a14ea-d83f-455e-b2bd-d98654c2c8d1", "fcddcec8-d07f-4d91-889b-c036d6edef42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "IsPublic", "SecurityStamp" },
                values: new object[] { "da3bd54e-b960-4e94-ba87-aeb1649709fd", true, "2790e552-7b7f-4b88-a2c1-9892456fdecd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fb1fc850-e6eb-4bac-9277-806d9bb61c94", "9ecf36c6-dd04-437e-8c31-ad6e7f83a9bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare4id",
                columns: new[] { "ConcurrencyStamp", "IsPublic", "SecurityStamp" },
                values: new object[] { "00063279-560e-41e0-9683-c99fb8c70d6f", true, "272f4a14-1521-43b7-b6e7-9a58016e7342" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare5id",
                columns: new[] { "ConcurrencyStamp", "IsActive", "SecurityStamp" },
                values: new object[] { "1561ab68-d9ea-493d-ae2a-bdd5dd1a9824", true, "89fce294-8d56-4bc5-bd2b-e076349058a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare6id",
                columns: new[] { "ConcurrencyStamp", "IsActive", "IsPublic", "SecurityStamp" },
                values: new object[] { "60e4cea7-6afd-43be-9ec7-5c00a8dc79d8", false, false, "29c3099e-0d5a-41bd-9565-b0f4db5b9184" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare7id",
                columns: new[] { "ConcurrencyStamp", "IsPublic", "SecurityStamp" },
                values: new object[] { "bb1bee76-d04f-49c1-827a-b058aeab8988", false, "e26e08fe-c3d4-462f-b63e-611bb7e511b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare8id",
                columns: new[] { "ConcurrencyStamp", "IsPublic", "SecurityStamp" },
                values: new object[] { "6b51455c-78b1-4f71-842b-72e267b2a9e7", false, "97f88926-2a7f-4e01-99c1-c705872511b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare9id",
                columns: new[] { "ConcurrencyStamp", "IsActive", "IsPublic", "SecurityStamp" },
                values: new object[] { "bf0d0497-50e1-4565-8061-f6984761232c", false, false, "477853be-cdc1-4ced-9171-2622a7d1d3d1" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 14, 56, 817, DateTimeKind.Local).AddTicks(3532), new DateTime(2022, 12, 27, 10, 14, 56, 817, DateTimeKind.Local).AddTicks(3525) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 14, 56, 817, DateTimeKind.Local).AddTicks(3537), new DateTime(2022, 12, 27, 10, 14, 56, 817, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 14, 56, 817, DateTimeKind.Local).AddTicks(3541), new DateTime(2022, 12, 27, 10, 14, 56, 817, DateTimeKind.Local).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 14, 56, 817, DateTimeKind.Local).AddTicks(3545), new DateTime(2022, 12, 27, 10, 14, 56, 817, DateTimeKind.Local).AddTicks(3543) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 10, 14, 56, 817, DateTimeKind.Local).AddTicks(3549), new DateTime(2022, 12, 27, 10, 14, 56, 817, DateTimeKind.Local).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 27, 10, 14, 56, 817, DateTimeKind.Local).AddTicks(1805));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare10id",
                columns: new[] { "ConcurrencyStamp", "IsPublic", "SecurityStamp" },
                values: new object[] { "f56f5a5d-c34b-45f1-acfb-0975e0955cd7", false, "010fab70-df7b-49b0-b458-65a1e8900aab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1274ed15-73e3-472e-ad28-ee49fbd0b9c8", "b3c280b3-da9d-4eed-b01e-43a1194310f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "IsPublic", "SecurityStamp" },
                values: new object[] { "35081f22-af71-4e85-b225-0e392b505a67", false, "995b9686-9490-4ffb-9041-57a71537c4f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dcaca7cd-4ad6-4da1-9097-3da38edb571e", "76ead78d-eb3f-409d-ad30-0c2204c909a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare4id",
                columns: new[] { "ConcurrencyStamp", "IsPublic", "SecurityStamp" },
                values: new object[] { "39be6cd5-6f17-4b2d-92bf-d3fd9e46cd89", false, "4d4ced4d-070a-41cd-b560-546d5e0d54ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare5id",
                columns: new[] { "ConcurrencyStamp", "IsActive", "SecurityStamp" },
                values: new object[] { "74b44ca9-2602-449a-9d2d-eb7e144efdf4", false, "51cceff1-33e9-4c56-9bae-64a2a55c05ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare6id",
                columns: new[] { "ConcurrencyStamp", "IsActive", "IsPublic", "SecurityStamp" },
                values: new object[] { "33069bc3-c517-4afa-901a-45e9cfc312ff", true, true, "5001af0f-eba0-4c2d-9520-da41722bfe63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare7id",
                columns: new[] { "ConcurrencyStamp", "IsPublic", "SecurityStamp" },
                values: new object[] { "7952cddf-9f94-4868-b89e-895bded8d616", true, "29f1f30e-c7a5-4028-974b-dd24261512ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare8id",
                columns: new[] { "ConcurrencyStamp", "IsPublic", "SecurityStamp" },
                values: new object[] { "6485f44e-bc6e-4fdf-a444-81275476b349", true, "e4254e5c-54a7-4c04-b2ae-408706d26db8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare9id",
                columns: new[] { "ConcurrencyStamp", "IsActive", "IsPublic", "SecurityStamp" },
                values: new object[] { "c1ec136f-9da4-425f-a519-fb936ee3f704", true, true, "f2148aed-1fd3-4ceb-8daf-33225e9176f8" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 8, 32, 9, 298, DateTimeKind.Local).AddTicks(30), new DateTime(2022, 12, 27, 8, 32, 9, 298, DateTimeKind.Local).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 8, 32, 9, 298, DateTimeKind.Local).AddTicks(35), new DateTime(2022, 12, 27, 8, 32, 9, 298, DateTimeKind.Local).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 8, 32, 9, 298, DateTimeKind.Local).AddTicks(38), new DateTime(2022, 12, 27, 8, 32, 9, 298, DateTimeKind.Local).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 8, 32, 9, 298, DateTimeKind.Local).AddTicks(42), new DateTime(2022, 12, 27, 8, 32, 9, 298, DateTimeKind.Local).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 27, 8, 32, 9, 298, DateTimeKind.Local).AddTicks(46), new DateTime(2022, 12, 27, 8, 32, 9, 298, DateTimeKind.Local).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 27, 8, 32, 9, 297, DateTimeKind.Local).AddTicks(8249));
        }
    }
}
