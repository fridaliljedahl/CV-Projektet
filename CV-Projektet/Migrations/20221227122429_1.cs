using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class _1 : Migration
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
                    { "användare10id", 0, 4, "828561df-74fa-4845-9a8c-3bd22edc1bc3", "dfggdffdgfdgdffdggdf", "ulla@hotmail.se", false, "Ulla", false, true, "Ivarsson", false, null, null, null, "mittnamnärulla", "073-888 33 33", false, null, new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "f1d76b4b-afa9-456a-971d-744287f49b85", false, null },
                    { "användare1id", 0, 1, "5a8e6eaf-622f-4fe9-aba6-148baaadd14a", "Hejaaa", "inga@hotmail.com", false, "Inga", true, true, "Karlsson", false, null, null, null, "mittnamnäringa", "073-111 11 11", false, null, new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ae31497d-0c78-4aa7-8097-a0875aed57a0", false, null },
                    { "användare2id", 0, 1, "72b24609-7678-4824-b300-f3f456464510", "Halloj", "gunvor@hotmail.se", false, "Gunvor", true, true, "Nilsson", false, null, null, null, "mittnamnärgunvor", "073-222 22 22", false, null, new DateTime(2022, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "a1180c23-498c-4091-a912-18714775b49b", false, null },
                    { "användare3id", 0, 1, "29e321f0-1b57-4bbb-a6ea-fe616879c0ac", "dfggdffdgfdgdffdggdf", "Jögge@hotmail.se", false, "Jörgen", true, true, "Svensson", false, null, null, null, "mittnamnärjörgen", "073-333 33 33", false, null, new DateTime(2022, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "ab801e4f-dd1e-43d6-a566-2a05b65f7310", false, null },
                    { "användare4id", 0, 2, "ce5fa78b-6b11-42c3-91e6-11160da57867", "dfggdffdgfdgdffdggdf", "stenis@hotmail.se", false, "Sten", true, true, "Kallesson", false, null, null, null, "mittnamnärsten", "074-444 44 44", false, null, new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "ccce1c5a-8c57-4757-a4b0-e7f2f5d1c079", false, null },
                    { "användare5id", 0, 3, "6b9ada02-95fc-43ee-869c-572ee7399c99", "dfggdffdgfdgdffdggdf", "kajsa@hotmail.se", false, "Kajsa", true, true, "Stenbäck", false, null, null, null, "mittnamnärkajsa", "075-123 55 55", false, null, new DateTime(2022, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "694389a2-ed0d-427c-9407-d77f31a47f31", false, null },
                    { "användare6id", 0, 4, "cf1b1d96-1c86-4f94-b360-f91b3986c03f", "dfggdffdgfdgdffdggdf", "frida@hotmail.se", false, "Frida", false, false, "Liljedahl", false, null, null, null, "mittnamnärfrida", "075-555 55 55", false, null, new DateTime(2022, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "0d539acf-6e5d-4a0f-b042-6b0a90a5cd2b", false, null },
                    { "användare7id", 0, 2, "be5ce2d3-d4b0-4d8e-8973-d9dccd89bb59", "dfggdffdgfdgdffdggdf", "linda@hotmail.se", false, "Linda", true, false, "Nordeman", false, null, null, null, "mittnamnärlinda", "076-666 66 66", false, null, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "e73e4472-de75-4c43-a041-d275904cd51f", false, null },
                    { "användare8id", 0, 3, "ec453276-5916-46f7-8f4b-3fb3bf2985b9", "dfggdffdgfdgdffdggdf", "lisa@hotmail.se", false, "Lisa", true, false, "Kjellgren", false, null, null, null, "mittnamnärlisa", "077-773 33 33", false, null, new DateTime(2022, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "ba71be4a-3747-41c2-bf52-092e1686a66a", false, null },
                    { "användare9id", 0, 2, "762cdf22-57bf-40e1-ae97-f3c839ddb0b5", "dfggdffdgfdgdffdggdf", "viktor@hotmail.se", false, "Viktor", false, false, "Hemlin Gravander", false, null, null, null, "mittnamnärviktor", "073-333 33 33", false, null, new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "22ab3823-0fd6-44ea-b5e9-2966d32b75f2", false, null }
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
                values: new object[] { 1, new DateTime(2022, 12, 27, 13, 24, 29, 654, DateTimeKind.Local).AddTicks(1070), false, "användare2id", "användare1id", "hejsan hoppsan" });

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
                    { 1, 1, "Lund", "pratade i telefon", new DateTime(2022, 12, 27, 13, 24, 29, 654, DateTimeKind.Local).AddTicks(2798), "ICA", new DateTime(2022, 12, 27, 13, 24, 29, 654, DateTimeKind.Local).AddTicks(2790), "Kundtjänst", "Work" },
                    { 2, 1, "Örebro", "Java", new DateTime(2022, 12, 27, 13, 24, 29, 654, DateTimeKind.Local).AddTicks(2803), "Örebro Universitet", new DateTime(2022, 12, 27, 13, 24, 29, 654, DateTimeKind.Local).AddTicks(2801), "Systemvetenskap", "Education" },
                    { 3, 1, "Göteborg", "HLR-utbildning", new DateTime(2022, 12, 27, 13, 24, 29, 654, DateTimeKind.Local).AddTicks(2807), "Företag1", new DateTime(2022, 12, 27, 13, 24, 29, 654, DateTimeKind.Local).AddTicks(2805), "HLR", "Course" },
                    { 4, 2, "Örebro", "Beskrivning blabla", new DateTime(2022, 12, 27, 13, 24, 29, 654, DateTimeKind.Local).AddTicks(2810), "Örebro Universitet", new DateTime(2022, 12, 27, 13, 24, 29, 654, DateTimeKind.Local).AddTicks(2809), "Lärarprogrammet", "Education" },
                    { 5, 1, "Örebro", "Java", new DateTime(2022, 12, 27, 13, 24, 29, 654, DateTimeKind.Local).AddTicks(2814), "Örebro Universitet", new DateTime(2022, 12, 27, 13, 24, 29, 654, DateTimeKind.Local).AddTicks(2813), "Systemvetenskap", "Education" }
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
