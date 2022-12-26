using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class testdata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User_Projects",
                keyColumns: new[] { "ProjectID", "UserID" },
                keyValues: new object[] { 2, "användare2id" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare10id",
                columns: new[] { "ConcurrencyStamp", "IsActive", "IsPublic", "SecurityStamp" },
                values: new object[] { "747b73d2-5a22-4bab-b75e-6269cad511a7", false, false, "21341959-07fb-422a-9855-23d0b0e1c266" });

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
                columns: new[] { "ConcurrencyStamp", "IsPublic", "SecurityStamp" },
                values: new object[] { "c42ddf65-d100-4776-9c59-8d8306fc12d6", false, "f74088d1-aa8c-4394-8e02-aebe1140bb64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare5id",
                columns: new[] { "ConcurrencyStamp", "IsActive", "SecurityStamp" },
                values: new object[] { "a8db9ea6-6181-44a2-aad5-dab92c1073e2", false, "f5d51b7d-b23e-4203-9c72-f1f1afff4497" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare6id",
                columns: new[] { "AdressID", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { 4, "46f4af0c-1ea6-4167-8af7-c0c850cab21e", "b9d1f008-bf4b-40ed-b6b7-56ead3aae65f" });

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

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "ID", "CVID", "City", "Description", "EndDate", "Place", "StartDate", "Title", "Type" },
                values: new object[,]
                {
                    { 4, 2, "Örebro", "Beskrivning blabla", new DateTime(2022, 12, 26, 11, 11, 10, 75, DateTimeKind.Local).AddTicks(5016), "Örebro Universitet", new DateTime(2022, 12, 26, 11, 11, 10, 75, DateTimeKind.Local).AddTicks(5015), "Lärarprogrammet", "Education" },
                    { 5, 1, "Örebro", "Java", new DateTime(2022, 12, 26, 11, 11, 10, 75, DateTimeKind.Local).AddTicks(5020), "Örebro Universitet", new DateTime(2022, 12, 26, 11, 11, 10, 75, DateTimeKind.Local).AddTicks(5019), "Systemvetenskap", "Education" }
                });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 26, 11, 11, 10, 75, DateTimeKind.Local).AddTicks(3218));

            migrationBuilder.InsertData(
                table: "User_Projects",
                columns: new[] { "ProjectID", "UserID" },
                values: new object[,]
                {
                    { 2, "användare1id" },
                    { 1, "användare2id" },
                    { 3, "användare2id" },
                    { 2, "användare3id" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "User_Projects",
                keyColumns: new[] { "ProjectID", "UserID" },
                keyValues: new object[] { 2, "användare1id" });

            migrationBuilder.DeleteData(
                table: "User_Projects",
                keyColumns: new[] { "ProjectID", "UserID" },
                keyValues: new object[] { 1, "användare2id" });

            migrationBuilder.DeleteData(
                table: "User_Projects",
                keyColumns: new[] { "ProjectID", "UserID" },
                keyValues: new object[] { 3, "användare2id" });

            migrationBuilder.DeleteData(
                table: "User_Projects",
                keyColumns: new[] { "ProjectID", "UserID" },
                keyValues: new object[] { 2, "användare3id" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare10id",
                columns: new[] { "ConcurrencyStamp", "IsActive", "IsPublic", "SecurityStamp" },
                values: new object[] { "8ba8d8f9-2e29-426c-8b22-4d989d2441d1", true, true, "9f398579-cf5a-4002-9294-4fc49ebf1d9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "858e7ecf-77eb-49c1-82f5-6ca2f9f49a5a", "34af90ba-d794-4fc9-834c-c5aefb58a1a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "678092bb-186b-48c3-af15-12584cbfda47", "3e9a7934-a3d3-4f57-9bbb-f3260e825a77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ce9359fa-692f-4aa8-8baa-bff8d6f105ea", "a07df67f-29b4-40f6-bd86-4488c46c2fe3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare4id",
                columns: new[] { "ConcurrencyStamp", "IsPublic", "SecurityStamp" },
                values: new object[] { "3b5b5736-fefa-4e4b-a857-b7e21455fb41", true, "e665b278-4eed-46c7-a498-1e7a7b2a3aa4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare5id",
                columns: new[] { "ConcurrencyStamp", "IsActive", "SecurityStamp" },
                values: new object[] { "25071ca3-4c3e-4e23-9410-33941457d953", true, "a4068e9a-e982-445d-ab86-eaf00e94feb5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare6id",
                columns: new[] { "AdressID", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { 3, "deab7c6a-496b-418b-a155-f13435cfa841", "214501dc-5e13-4355-a9ff-da5c4ef56618" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare7id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b1695ca7-7b28-4ecf-87c3-33bd2fbb1942", "2dd7e446-ccb5-4eed-b8c3-c05d707ed158" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare8id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "219e454a-f2c2-4f4c-99f0-8e6084f8a9f9", "22f96869-01ec-4a6a-ba28-030af934290c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare9id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "53593ebc-2d22-463d-a263-87bf4f697503", "d30e8c93-f636-4c8d-a760-23c2d4d76b0d" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 10, 29, 6, 308, DateTimeKind.Local).AddTicks(6330), new DateTime(2022, 12, 26, 10, 29, 6, 308, DateTimeKind.Local).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 10, 29, 6, 308, DateTimeKind.Local).AddTicks(6335), new DateTime(2022, 12, 26, 10, 29, 6, 308, DateTimeKind.Local).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 10, 29, 6, 308, DateTimeKind.Local).AddTicks(6339), new DateTime(2022, 12, 26, 10, 29, 6, 308, DateTimeKind.Local).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 26, 10, 29, 6, 308, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.InsertData(
                table: "User_Projects",
                columns: new[] { "ProjectID", "UserID" },
                values: new object[] { 2, "användare2id" });
        }
    }
}
