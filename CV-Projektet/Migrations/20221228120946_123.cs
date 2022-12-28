using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class _123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Competences",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competences", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AdressID = table.Column<int>(type: "int", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Addresses_AdressID",
                        column: x => x.AdressID,
                        principalTable: "Addresses",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CVs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimesViewed = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CVs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CVs_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Images_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sender = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Receiver = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Read = table.Column<bool>(type: "bit", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_Receiver",
                        column: x => x.Receiver,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_Sender",
                        column: x => x.Sender,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjectLeaderID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Projects_AspNetUsers_ProjectLeaderID",
                        column: x => x.ProjectLeaderID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

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
                name: "Experiences",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CVID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Experiences_CVs_CVID",
                        column: x => x.CVID,
                        principalTable: "CVs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User_Projects",
                columns: table => new
                {
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProjectID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Projects", x => new { x.UserID, x.ProjectID });
                    table.ForeignKey(
                        name: "FK_User_Projects_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Projects_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "ID", "City", "PostalCode", "Street" },
                values: new object[,]
                {
                    { 1, "Örebro", 12345, "Storgatan 1" },
                    { 2, "Ystad", 12365, "Drottninggatan 12" },
                    { 3, "Göteborg", 16845, "Kungsgatan 43" },
                    { 4, "Gnesta", 16845, "Storälven 22" }
                });

            migrationBuilder.InsertData(
                table: "Competences",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "C#" },
                    { 2, "Java" },
                    { 3, "Kassavana" },
                    { 4, "HLR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AdressID", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "FirstName", "IsActive", "IsPublic", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "RegistrationDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "användare10id", 0, 4, "789f1c2d-5951-4685-9c26-7eed6dcdb2d8", "dfggdffdgfdgdffdggdf", "ulla@hotmail.se", false, "Ulla", false, true, "Ivarsson", false, null, null, null, "mittnamnärulla", "073-888 33 33", false, null, new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "4d6ebc3c-11d5-4dc4-8458-e96794ee54a0", false, null },
                    { "användare1id", 0, 1, "2dad762a-0134-4c00-99b4-480c8cec5c97", "Hejaaa", "inga@hotmail.com", false, "Inga", true, true, "Karlsson", false, null, null, null, "mittnamnäringa", "073-111 11 11", false, null, new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "9c7b8c0e-2144-4291-9876-cfba38e9ac20", false, null },
                    { "användare2id", 0, 1, "7d17ae5b-a451-4000-b00b-f11f3751336a", "Halloj", "gunvor@hotmail.se", false, "Gunvor", true, true, "Nilsson", false, null, null, null, "mittnamnärgunvor", "073-222 22 22", false, null, new DateTime(2022, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "3fd1fa5a-1583-43bc-92ea-d9f3d8787acf", false, null },
                    { "användare3id", 0, 1, "2b7e74dc-7d75-4233-939d-f2428c1596ab", "dfggdffdgfdgdffdggdf", "Jögge@hotmail.se", false, "Jörgen", true, true, "Svensson", false, null, null, null, "mittnamnärjörgen", "073-333 33 33", false, null, new DateTime(2022, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "92c2bade-72f9-4131-b6ba-2cb376fba604", false, null },
                    { "användare4id", 0, 2, "ac6e0d5c-7820-4932-8517-fda6189b657a", "dfggdffdgfdgdffdggdf", "stenis@hotmail.se", false, "Sten", true, true, "Kallesson", false, null, null, null, "mittnamnärsten", "074-444 44 44", false, null, new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "76a3fb40-47b9-419a-a11f-39017eb2d53b", false, null },
                    { "användare5id", 0, 3, "786aa87c-c533-4077-bac4-d522a45f2a89", "dfggdffdgfdgdffdggdf", "kajsa@hotmail.se", false, "Kajsa", true, true, "Stenbäck", false, null, null, null, "mittnamnärkajsa", "075-123 55 55", false, null, new DateTime(2022, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "432672fd-f6ce-4088-8b2c-a9455e7cf1ad", false, null },
                    { "användare6id", 0, 4, "ddd2c15b-c948-4f42-8c02-ad3f38dfeb05", "dfggdffdgfdgdffdggdf", "frida@hotmail.se", false, "Frida", false, false, "Liljedahl", false, null, null, null, "mittnamnärfrida", "075-555 55 55", false, null, new DateTime(2022, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "d9b40021-9b84-4557-a9c8-753ea92ccdff", false, null },
                    { "användare7id", 0, 2, "ef5c919b-9a8a-4c51-a856-6a689e83a4f0", "dfggdffdgfdgdffdggdf", "linda@hotmail.se", false, "Linda", true, false, "Nordeman", false, null, null, null, "mittnamnärlinda", "076-666 66 66", false, null, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "412cfd50-dd80-48a8-a98d-f1c5081ec5f0", false, null },
                    { "användare8id", 0, 3, "60d34ec3-c67e-4bda-ab3b-5439cfeb699d", "dfggdffdgfdgdffdggdf", "lisa@hotmail.se", false, "Lisa", true, false, "Kjellgren", false, null, null, null, "mittnamnärlisa", "077-773 33 33", false, null, new DateTime(2022, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "e40f7a85-c047-4176-ba07-00e5afd574a5", false, null },
                    { "användare9id", 0, 2, "23c91428-366e-4f75-818a-5e232d6da7aa", "dfggdffdgfdgdffdggdf", "viktor@hotmail.se", false, "Viktor", false, false, "Hemlin Gravander", false, null, null, null, "mittnamnärviktor", "073-333 33 33", false, null, new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "b0a3c988-a5ad-4326-816b-e8cfd5c0651a", false, null }
                });

            migrationBuilder.InsertData(
                table: "CVs",
                columns: new[] { "ID", "TimesViewed", "UserID" },
                values: new object[,]
                {
                    { 1, 0, "användare1id" },
                    { 2, 3, "användare3id" },
                    { 3, 12, "användare2id" },
                    { 4, 55, "användare4id" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "Name", "Title", "UserID" },
                values: new object[] { 4, "image (1)223847664.png", "Profilbild", "användare1id" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "ID", "Date", "Read", "Receiver", "Sender", "Text" },
                values: new object[] { 1, new DateTime(2022, 12, 28, 13, 9, 46, 300, DateTimeKind.Local).AddTicks(2229), false, "användare2id", "användare1id", "hejsan hoppsan" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ID", "CreatedDate", "Description", "Name", "ProjectLeaderID" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Projektbeskrivningen blabla", "Planeringsprojektet", "användare1id" },
                    { 2, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Projektbeskrivningen blabla", "Yogahemsideprojektet", "användare2id" },
                    { 3, new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Projektbeskrivningen blabla", "CV-Projektet", "användare3id" },
                    { 4, new DateTime(2022, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Projektbeskrivningen blabla", "Mötesprojektet", "användare4id" }
                });

            migrationBuilder.InsertData(
                table: "CV_Competences",
                columns: new[] { "CVID", "CompetenceID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 4 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "ID", "CVID", "City", "Description", "EndDate", "Place", "StartDate", "Title", "Type" },
                values: new object[,]
                {
                    { 1, 1, "Lund", "pratade i telefon", new DateTime(2022, 12, 28, 13, 9, 46, 300, DateTimeKind.Local).AddTicks(4516), "ICA", new DateTime(2022, 12, 28, 13, 9, 46, 300, DateTimeKind.Local).AddTicks(4502), "Kundtjänst", "Work" },
                    { 2, 1, "Örebro", "Java", new DateTime(2022, 12, 28, 13, 9, 46, 300, DateTimeKind.Local).AddTicks(4521), "Örebro Universitet", new DateTime(2022, 12, 28, 13, 9, 46, 300, DateTimeKind.Local).AddTicks(4519), "Systemvetenskap", "Education" },
                    { 3, 1, "Göteborg", "HLR-utbildning", new DateTime(2022, 12, 28, 13, 9, 46, 300, DateTimeKind.Local).AddTicks(4524), "Företag1", new DateTime(2022, 12, 28, 13, 9, 46, 300, DateTimeKind.Local).AddTicks(4523), "HLR", "Course" },
                    { 4, 2, "Örebro", "Beskrivning blabla", new DateTime(2022, 12, 28, 13, 9, 46, 300, DateTimeKind.Local).AddTicks(4528), "Örebro Universitet", new DateTime(2022, 12, 28, 13, 9, 46, 300, DateTimeKind.Local).AddTicks(4526), "Lärarprogrammet", "Education" },
                    { 5, 1, "Örebro", "Java", new DateTime(2022, 12, 28, 13, 9, 46, 300, DateTimeKind.Local).AddTicks(4531), "Örebro Universitet", new DateTime(2022, 12, 28, 13, 9, 46, 300, DateTimeKind.Local).AddTicks(4530), "Systemvetenskap", "Education" }
                });

            migrationBuilder.InsertData(
                table: "User_Projects",
                columns: new[] { "ProjectID", "UserID" },
                values: new object[,]
                {
                    { 1, "användare1id" },
                    { 2, "användare1id" },
                    { 1, "användare2id" },
                    { 3, "användare2id" },
                    { 2, "användare3id" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AdressID",
                table: "AspNetUsers",
                column: "AdressID");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CV_Competences_CompetenceID",
                table: "CV_Competences",
                column: "CompetenceID");

            migrationBuilder.CreateIndex(
                name: "IX_CVs_UserID",
                table: "CVs",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_CVID",
                table: "Experiences",
                column: "CVID");

            migrationBuilder.CreateIndex(
                name: "IX_Images_UserID",
                table: "Images",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_Receiver",
                table: "Messages",
                column: "Receiver");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_Sender",
                table: "Messages",
                column: "Sender");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectLeaderID",
                table: "Projects",
                column: "ProjectLeaderID");

            migrationBuilder.CreateIndex(
                name: "IX_User_Projects_ProjectID",
                table: "User_Projects",
                column: "ProjectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CV_Competences");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "User_Projects");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Competences");

            migrationBuilder.DropTable(
                name: "CVs");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
