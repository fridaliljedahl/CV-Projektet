using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class _1234432 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CV_Competence_Competence_CompetenceID",
                table: "CV_Competence");

            migrationBuilder.DropForeignKey(
                name: "FK_CVs_Competence_CompetenceID",
                table: "CVs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Competence",
                table: "Competence");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eab89f8c-e0a7-4fb1-a573-bf3cde766d3b");

            migrationBuilder.RenameTable(
                name: "Competence",
                newName: "Competences");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Messages",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Messages",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Competences",
                table: "Competences",
                column: "ID");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AdressID", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a01b1ae9-6975-4bac-958c-d5ed86a387b7", 0, 1, "2f64ea1f-04db-4be8-9fd3-e34a7c04d499", "User", null, false, "Frida", "Liljedahl", false, null, null, null, null, null, false, null, "a4c5a73c-5e49-49fe-9b2f-a3d9591a4e53", false, null });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 19, 14, 38, 50, 264, DateTimeKind.Local).AddTicks(7974), new DateTime(2022, 12, 19, 14, 38, 50, 264, DateTimeKind.Local).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 19, 14, 38, 50, 264, DateTimeKind.Local).AddTicks(7987), new DateTime(2022, 12, 19, 14, 38, 50, 264, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 19, 14, 38, 50, 264, DateTimeKind.Local).AddTicks(7999), new DateTime(2022, 12, 19, 14, 38, 50, 264, DateTimeKind.Local).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 19, 14, 38, 50, 264, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId",
                table: "Messages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId1",
                table: "Messages",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CV_Competence_Competences_CompetenceID",
                table: "CV_Competence",
                column: "CompetenceID",
                principalTable: "Competences",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CVs_Competences_CompetenceID",
                table: "CVs",
                column: "CompetenceID",
                principalTable: "Competences",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_UserId",
                table: "Messages",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_UserId1",
                table: "Messages",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CV_Competence_Competences_CompetenceID",
                table: "CV_Competence");

            migrationBuilder.DropForeignKey(
                name: "FK_CVs_Competences_CompetenceID",
                table: "CVs");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_UserId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_UserId1",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_UserId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_UserId1",
                table: "Messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Competences",
                table: "Competences");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a01b1ae9-6975-4bac-958c-d5ed86a387b7");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Messages");

            migrationBuilder.RenameTable(
                name: "Competences",
                newName: "Competence");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Competence",
                table: "Competence",
                column: "ID");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AdressID", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "eab89f8c-e0a7-4fb1-a573-bf3cde766d3b", 0, 1, "362b4ab1-ebdf-4491-86d7-51cb0b334475", "User", null, false, "Frida", "Liljedahl", false, null, null, null, null, null, false, null, "727d435f-a45a-4e46-b881-e553a90af40f", false, null });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 19, 14, 14, 40, 867, DateTimeKind.Local).AddTicks(9946), new DateTime(2022, 12, 19, 14, 14, 40, 867, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 19, 14, 14, 40, 867, DateTimeKind.Local).AddTicks(9961), new DateTime(2022, 12, 19, 14, 14, 40, 867, DateTimeKind.Local).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 19, 14, 14, 40, 867, DateTimeKind.Local).AddTicks(9974), new DateTime(2022, 12, 19, 14, 14, 40, 867, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 19, 14, 14, 40, 867, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.AddForeignKey(
                name: "FK_CV_Competence_Competence_CompetenceID",
                table: "CV_Competence",
                column: "CompetenceID",
                principalTable: "Competence",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CVs_Competence_CompetenceID",
                table: "CVs",
                column: "CompetenceID",
                principalTable: "Competence",
                principalColumn: "ID");
        }
    }
}
