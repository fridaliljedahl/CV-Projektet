using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class projectcreateddate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare10id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f56f5a5d-c34b-45f1-acfb-0975e0955cd7", "010fab70-df7b-49b0-b458-65a1e8900aab" });

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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "35081f22-af71-4e85-b225-0e392b505a67", "995b9686-9490-4ffb-9041-57a71537c4f8" });

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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "39be6cd5-6f17-4b2d-92bf-d3fd9e46cd89", "4d4ced4d-070a-41cd-b560-546d5e0d54ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare5id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "74b44ca9-2602-449a-9d2d-eb7e144efdf4", "51cceff1-33e9-4c56-9bae-64a2a55c05ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare6id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "33069bc3-c517-4afa-901a-45e9cfc312ff", "5001af0f-eba0-4c2d-9520-da41722bfe63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare7id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7952cddf-9f94-4868-b89e-895bded8d616", "29f1f30e-c7a5-4028-974b-dd24261512ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare8id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6485f44e-bc6e-4fdf-a444-81275476b349", "e4254e5c-54a7-4c04-b2ae-408706d26db8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare9id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c1ec136f-9da4-425f-a519-fb936ee3f704", "f2148aed-1fd3-4ceb-8daf-33225e9176f8" });

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

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Projects");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare10id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "747b73d2-5a22-4bab-b75e-6269cad511a7", "21341959-07fb-422a-9855-23d0b0e1c266" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5de2af1e-2646-490a-93f2-db12544c1b4b", "e8d8aa20-4b12-4a6f-9813-01bececcc3e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6ce4b970-a70f-4fa2-a1c9-e01d7872891a", "fe40f184-c75f-4f7f-91cd-707873787263" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1f219210-0ec0-437e-ad67-d720e75c9588", "9fca94df-e68a-4ef6-8cc9-2897c99fde58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare4id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c42ddf65-d100-4776-9c59-8d8306fc12d6", "f74088d1-aa8c-4394-8e02-aebe1140bb64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare5id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a8db9ea6-6181-44a2-aad5-dab92c1073e2", "f5d51b7d-b23e-4203-9c72-f1f1afff4497" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare6id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "46f4af0c-1ea6-4167-8af7-c0c850cab21e", "b9d1f008-bf4b-40ed-b6b7-56ead3aae65f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare7id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ae18cc11-da5a-4aee-a80b-386dcaa6fa55", "ff1adacc-c79d-410e-8e27-06235a9adfef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare8id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3d360315-b771-48f1-808e-d3591ce1e49d", "ad19adce-0b1b-487f-9ab1-d1c91bf8b0d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare9id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ce5bdfd7-b21c-4462-879c-982fe9554395", "af0a6b89-2a97-4804-9085-36328e67a737" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 11, 11, 10, 75, DateTimeKind.Local).AddTicks(5003), new DateTime(2022, 12, 26, 11, 11, 10, 75, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 11, 11, 10, 75, DateTimeKind.Local).AddTicks(5008), new DateTime(2022, 12, 26, 11, 11, 10, 75, DateTimeKind.Local).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 11, 11, 10, 75, DateTimeKind.Local).AddTicks(5012), new DateTime(2022, 12, 26, 11, 11, 10, 75, DateTimeKind.Local).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 11, 11, 10, 75, DateTimeKind.Local).AddTicks(5016), new DateTime(2022, 12, 26, 11, 11, 10, 75, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 11, 11, 10, 75, DateTimeKind.Local).AddTicks(5020), new DateTime(2022, 12, 26, 11, 11, 10, 75, DateTimeKind.Local).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 26, 11, 11, 10, 75, DateTimeKind.Local).AddTicks(3218));
        }
    }
}
