using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class _1234567 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CV_Competence");

            migrationBuilder.DropTable(
                name: "CV_Project");

            migrationBuilder.CreateTable(
                name: "CV_Competences",
                columns: table => new
                {
                    CVID = table.Column<int>(type: "int", nullable: false),
                    CompetenceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CV_Competences", x => new { x.CVID, x.CompetenceID });
                    table.ForeignKey(
                        name: "FK_CV_Competences_Competences_CompetenceID",
                        column: x => x.CompetenceID,
                        principalTable: "Competences",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CV_Competences_CVs_CVID",
                        column: x => x.CVID,
                        principalTable: "CVs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CV_Projects",
                columns: table => new
                {
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    CVID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CV_Projects", x => new { x.ProjectID, x.CVID });
                    table.ForeignKey(
                        name: "FK_CV_Projects_CVs_CVID",
                        column: x => x.CVID,
                        principalTable: "CVs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CV_Projects_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "43a9a3fe-f516-418e-8d0e-59e2328bcbe6", "e158a210-39d3-4def-928e-bd356befaddd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4abd5687-3a0e-490a-abe8-885f808728da", "0e226c82-0410-4510-96c3-8c77237506e9" });

            migrationBuilder.InsertData(
                table: "CV_Competences",
                columns: new[] { "CVID", "CompetenceID" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "CV_Projects",
                columns: new[] { "CVID", "ProjectID" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 20, 8, 39, 24, 979, DateTimeKind.Local).AddTicks(6887), new DateTime(2022, 12, 20, 8, 39, 24, 979, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 20, 8, 39, 24, 979, DateTimeKind.Local).AddTicks(6901), new DateTime(2022, 12, 20, 8, 39, 24, 979, DateTimeKind.Local).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 20, 8, 39, 24, 979, DateTimeKind.Local).AddTicks(6913), new DateTime(2022, 12, 20, 8, 39, 24, 979, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 20, 8, 39, 24, 979, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.CreateIndex(
                name: "IX_CV_Competences_CompetenceID",
                table: "CV_Competences",
                column: "CompetenceID");

            migrationBuilder.CreateIndex(
                name: "IX_CV_Projects_CVID",
                table: "CV_Projects",
                column: "CVID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CV_Competences");

            migrationBuilder.DropTable(
                name: "CV_Projects");

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
                        name: "FK_CV_Competence_Competences_CompetenceID",
                        column: x => x.CompetenceID,
                        principalTable: "Competences",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CV_Competence_CVs_CVID",
                        column: x => x.CVID,
                        principalTable: "CVs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "652620a0-b17e-4c32-a0e8-e3126ed95cdd", "b490ce23-e2fe-4fbe-be2d-278f12f4e744" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ad21ad29-f293-45d2-b46e-a7ae2d2e6c1a", "c21aabda-9e82-4f2a-a409-f9bcc0b5259e" });

            migrationBuilder.InsertData(
                table: "CV_Competence",
                columns: new[] { "CVID", "CompetenceID" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "CV_Project",
                columns: new[] { "CVID", "ProjectID" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 20, 8, 38, 39, 997, DateTimeKind.Local).AddTicks(1148), new DateTime(2022, 12, 20, 8, 38, 39, 997, DateTimeKind.Local).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 20, 8, 38, 39, 997, DateTimeKind.Local).AddTicks(1161), new DateTime(2022, 12, 20, 8, 38, 39, 997, DateTimeKind.Local).AddTicks(1159) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 20, 8, 38, 39, 997, DateTimeKind.Local).AddTicks(1172), new DateTime(2022, 12, 20, 8, 38, 39, 997, DateTimeKind.Local).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 20, 8, 38, 39, 996, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.CreateIndex(
                name: "IX_CV_Competence_CompetenceID",
                table: "CV_Competence",
                column: "CompetenceID");

            migrationBuilder.CreateIndex(
                name: "IX_CV_Project_CVID",
                table: "CV_Project",
                column: "CVID");
        }
    }
}
