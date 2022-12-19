using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class _1111432 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectsInCV");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2781d92-66f8-4479-8fde-233878a31ac0");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "RoleName",
                table: "Experiences");

            migrationBuilder.RenameColumn(
                name: "LocationName",
                table: "Experiences",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "Experiences",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "Place",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CompetenceID",
                table: "CVs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Competence",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competence", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CV_Project",
                columns: table => new
                {
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    CVID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CV_Project", x => new { x.ProjectID, x.CVID });
                    table.ForeignKey(
                        name: "FK_CV_Project_CVs_CVID",
                        column: x => x.CVID,
                        principalTable: "CVs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CV_Project_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CV_Competence",
                columns: table => new
                {
                    CVID = table.Column<int>(type: "int", nullable: false),
                    CompetenceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CV_Competence", x => new { x.CVID, x.CompetenceID });
                    table.ForeignKey(
                        name: "FK_CV_Competence_Competence_CompetenceID",
                        column: x => x.CompetenceID,
                        principalTable: "Competence",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CV_Competence_CVs_CVID",
                        column: x => x.CVID,
                        principalTable: "CVs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AdressID", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "eab89f8c-e0a7-4fb1-a573-bf3cde766d3b", 0, 1, "362b4ab1-ebdf-4491-86d7-51cb0b334475", "User", null, false, "Frida", "Liljedahl", false, null, null, null, null, null, false, null, "727d435f-a45a-4e46-b881-e553a90af40f", false, null });

            migrationBuilder.InsertData(
                table: "CV_Project",
                columns: new[] { "CVID", "ProjectID" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "C#" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "Place", "StartDate", "Title", "Type" },
                values: new object[] { new DateTime(2022, 12, 19, 14, 14, 40, 867, DateTimeKind.Local).AddTicks(9946), "ICA", new DateTime(2022, 12, 19, 14, 14, 40, 867, DateTimeKind.Local).AddTicks(9937), "Kundtjänst", "Work" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "Place", "StartDate", "Title", "Type" },
                values: new object[] { new DateTime(2022, 12, 19, 14, 14, 40, 867, DateTimeKind.Local).AddTicks(9961), "Örebro Universitet", new DateTime(2022, 12, 19, 14, 14, 40, 867, DateTimeKind.Local).AddTicks(9959), "Systemvetenskap", "Education" });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "Place", "StartDate", "Title", "Type" },
                values: new object[] { new DateTime(2022, 12, 19, 14, 14, 40, 867, DateTimeKind.Local).AddTicks(9974), "Företag1", new DateTime(2022, 12, 19, 14, 14, 40, 867, DateTimeKind.Local).AddTicks(9972), "HLR", "Course" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 19, 14, 14, 40, 867, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.InsertData(
                table: "CV_Competence",
                columns: new[] { "CVID", "CompetenceID" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_CVs_CompetenceID",
                table: "CVs",
                column: "CompetenceID");

            migrationBuilder.CreateIndex(
                name: "IX_CV_Competence_CompetenceID",
                table: "CV_Competence",
                column: "CompetenceID");

            migrationBuilder.CreateIndex(
                name: "IX_CV_Project_CVID",
                table: "CV_Project",
                column: "CVID");

            migrationBuilder.AddForeignKey(
                name: "FK_CVs_Competence_CompetenceID",
                table: "CVs",
                column: "CompetenceID",
                principalTable: "Competence",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CVs_Competence_CompetenceID",
                table: "CVs");

            migrationBuilder.DropTable(
                name: "CV_Competence");

            migrationBuilder.DropTable(
                name: "CV_Project");

            migrationBuilder.DropTable(
                name: "Competence");

            migrationBuilder.DropIndex(
                name: "IX_CVs_CompetenceID",
                table: "CVs");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eab89f8c-e0a7-4fb1-a573-bf3cde766d3b");

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Place",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "CompetenceID",
                table: "CVs");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Experiences",
                newName: "LocationName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Experiences",
                newName: "Discriminator");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoleName",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProjectsInCV",
                columns: table => new
                {
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    CVID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectsInCV", x => new { x.ProjectID, x.CVID });
                    table.ForeignKey(
                        name: "FK_ProjectsInCV_CVs_CVID",
                        column: x => x.CVID,
                        principalTable: "CVs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectsInCV_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AdressID", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d2781d92-66f8-4479-8fde-233878a31ac0", 0, 1, "2bd7e173-5a5a-4011-ad0d-bb06d416058f", "User", null, false, "Frida", "Liljedahl", false, null, null, null, null, null, false, null, "f7541832-8629-4030-a753-5be1c0a03c36", false, null });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "ID", "CVID", "City", "Description", "Discriminator", "EndDate", "LocationName", "Name", "StartDate" },
                values: new object[] { 2, 1, "Örebro", "Java", "Education", new DateTime(2022, 12, 19, 13, 33, 40, 690, DateTimeKind.Local).AddTicks(2989), "Örebro Universitet", "Systemvetenskap", new DateTime(2022, 12, 19, 13, 33, 40, 690, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "ID", "CVID", "City", "Description", "Discriminator", "EndDate", "LocationName", "StartDate" },
                values: new object[] { 3, 1, "Göteborg", "HLR-utbildning", "Experience", new DateTime(2022, 12, 19, 13, 33, 40, 690, DateTimeKind.Local).AddTicks(3018), "Företaget", new DateTime(2022, 12, 19, 13, 33, 40, 690, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "ID", "CVID", "City", "Description", "Discriminator", "EndDate", "LocationName", "RoleName", "StartDate" },
                values: new object[] { 1, 1, "Lund", "pratade i telefon", "Work", new DateTime(2022, 12, 19, 13, 33, 40, 689, DateTimeKind.Local).AddTicks(8011), "ICA", "Kundtjänst", new DateTime(2022, 12, 19, 13, 33, 40, 689, DateTimeKind.Local).AddTicks(8001) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 19, 13, 33, 40, 689, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.InsertData(
                table: "ProjectsInCV",
                columns: new[] { "CVID", "ProjectID" },
                values: new object[] { 1, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectsInCV_CVID",
                table: "ProjectsInCV",
                column: "CVID");
        }
    }
}
