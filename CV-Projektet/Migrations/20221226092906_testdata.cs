using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class testdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "ID", "City", "PostalCode", "Street" },
                values: new object[,]
                {
                    { 2, "Ystad", 12365, "Drottninggatan 12" },
                    { 3, "Göteborg", 16845, "Kungsgatan 43" },
                    { 4, "Gnesta", 16845, "Storälven 22" }
                });

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
                table: "CVs",
                keyColumn: "ID",
                keyValue: 2,
                column: "TimesViewed",
                value: 3);

            migrationBuilder.InsertData(
                table: "CVs",
                columns: new[] { "ID", "TimesViewed", "UserID" },
                values: new object[] { 3, 12, "användare2id" });

            migrationBuilder.InsertData(
                table: "Competences",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 2, "Java" },
                    { 3, "Kassavana" },
                    { 4, "HLR" }
                });

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

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Projektbeskrivningen blabla", "Planeringsprojektet" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Projektbeskrivningen blabla", "Yogahemsideprojektet" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ID", "Description", "Name", "ProjectLeaderID" },
                values: new object[] { 3, "Projektbeskrivningen blabla", "CV-Projektet", "användare3id" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AdressID", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "FirstName", "IsActive", "IsPublic", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "RegistrationDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "användare10id", 0, 4, "8ba8d8f9-2e29-426c-8b22-4d989d2441d1", "dfggdffdgfdgdffdggdf", "ulla@hotmail.se", false, "Ulla", true, true, "Ivarsson", false, null, null, null, "mittnamnärulla", "073-888 33 33", false, null, new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "9f398579-cf5a-4002-9294-4fc49ebf1d9c", false, null },
                    { "användare4id", 0, 2, "3b5b5736-fefa-4e4b-a857-b7e21455fb41", "dfggdffdgfdgdffdggdf", "stenis@hotmail.se", false, "Sten", true, true, "Kallesson", false, null, null, null, "mittnamnärsten", "074-444 44 44", false, null, new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "e665b278-4eed-46c7-a498-1e7a7b2a3aa4", false, null },
                    { "användare5id", 0, 3, "25071ca3-4c3e-4e23-9410-33941457d953", "dfggdffdgfdgdffdggdf", "kajsa@hotmail.se", false, "Kajsa", true, true, "Stenbäck", false, null, null, null, "mittnamnärkajsa", "075-123 55 55", false, null, new DateTime(2022, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "a4068e9a-e982-445d-ab86-eaf00e94feb5", false, null },
                    { "användare6id", 0, 3, "deab7c6a-496b-418b-a155-f13435cfa841", "dfggdffdgfdgdffdggdf", "frida@hotmail.se", false, "Frida", true, true, "Liljedahl", false, null, null, null, "mittnamnärfrida", "075-555 55 55", false, null, new DateTime(2022, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "214501dc-5e13-4355-a9ff-da5c4ef56618", false, null },
                    { "användare7id", 0, 2, "b1695ca7-7b28-4ecf-87c3-33bd2fbb1942", "dfggdffdgfdgdffdggdf", "linda@hotmail.se", false, "Linda", true, true, "Nordeman", false, null, null, null, "mittnamnärlinda", "076-666 66 66", false, null, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "2dd7e446-ccb5-4eed-b8c3-c05d707ed158", false, null },
                    { "användare8id", 0, 3, "219e454a-f2c2-4f4c-99f0-8e6084f8a9f9", "dfggdffdgfdgdffdggdf", "lisa@hotmail.se", false, "Lisa", true, true, "Kjellgren", false, null, null, null, "mittnamnärlisa", "077-773 33 33", false, null, new DateTime(2022, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "22f96869-01ec-4a6a-ba28-030af934290c", false, null },
                    { "användare9id", 0, 2, "53593ebc-2d22-463d-a263-87bf4f697503", "dfggdffdgfdgdffdggdf", "viktor@hotmail.se", false, "Viktor", true, true, "Hemlin Gravander", false, null, null, null, "mittnamnärviktor", "073-333 33 33", false, null, new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "d30e8c93-f636-4c8d-a760-23c2d4d76b0d", false, null }
                });

            migrationBuilder.InsertData(
                table: "CV_Competences",
                columns: new[] { "CVID", "CompetenceID" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 4 }
                });

            migrationBuilder.InsertData(
                table: "CVs",
                columns: new[] { "ID", "TimesViewed", "UserID" },
                values: new object[] { 4, 55, "användare4id" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ID", "Description", "Name", "ProjectLeaderID" },
                values: new object[] { 4, "Projektbeskrivningen blabla", "Mötesprojektet", "användare4id" });

            migrationBuilder.InsertData(
                table: "CV_Competences",
                columns: new[] { "CVID", "CompetenceID" },
                values: new object[] { 4, 1 });

            migrationBuilder.InsertData(
                table: "CV_Competences",
                columns: new[] { "CVID", "CompetenceID" },
                values: new object[] { 4, 2 });

            migrationBuilder.InsertData(
                table: "CV_Competences",
                columns: new[] { "CVID", "CompetenceID" },
                values: new object[] { 4, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare10id");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare5id");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare6id");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare7id");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare8id");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare9id");

            migrationBuilder.DeleteData(
                table: "CV_Competences",
                keyColumns: new[] { "CVID", "CompetenceID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CV_Competences",
                keyColumns: new[] { "CVID", "CompetenceID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CV_Competences",
                keyColumns: new[] { "CVID", "CompetenceID" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "CV_Competences",
                keyColumns: new[] { "CVID", "CompetenceID" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "CV_Competences",
                keyColumns: new[] { "CVID", "CompetenceID" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "CV_Competences",
                keyColumns: new[] { "CVID", "CompetenceID" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "CV_Competences",
                keyColumns: new[] { "CVID", "CompetenceID" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "CV_Competences",
                keyColumns: new[] { "CVID", "CompetenceID" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CVs",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CVs",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Competences",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Competences",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Competences",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare4id");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dd3fe1e5-674f-4456-a98c-662c18623f70", "e535ccc0-7258-4ef1-97f7-76fb28d4b545" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0c40e8d2-c139-4efe-a515-ff22d5c53223", "97eb1d70-1ea7-4a4a-a4cd-8cb6489f353d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "46468ae1-7921-4e7f-887e-e049197107bc", "f6a5dae8-f5f5-436a-a8bd-f0743ca41dc7" });

            migrationBuilder.UpdateData(
                table: "CVs",
                keyColumn: "ID",
                keyValue: 2,
                column: "TimesViewed",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 10, 10, 49, 979, DateTimeKind.Local).AddTicks(8928), new DateTime(2022, 12, 26, 10, 10, 49, 979, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 10, 10, 49, 979, DateTimeKind.Local).AddTicks(8942), new DateTime(2022, 12, 26, 10, 10, 49, 979, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 26, 10, 10, 49, 979, DateTimeKind.Local).AddTicks(8953), new DateTime(2022, 12, 26, 10, 10, 49, 979, DateTimeKind.Local).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 26, 10, 10, 49, 979, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "TestProject1Desc", "TestProject" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "TestProject1Desc", "TestProject2" });
        }
    }
}
