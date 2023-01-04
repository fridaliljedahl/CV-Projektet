using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class testdata : Migration
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
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    Sender = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Receiver = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Read = table.Column<bool>(type: "bit", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SenderName = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                columns: new[] { "Id", "AccessFailedCount", "AdressID", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "FirstName", "IsActive", "IsPublic", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegistrationDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "användare10id", 0, 4, "c54ec39d-840a-4dcc-a333-e9074ccb57a7", "dfggdffdgfdgdffdggdf", "ulla@hotmail.se", false, "Ulla", false, true, "Ivarsson", false, null, null, null, "mittnamnärulla", "0738883333", false, new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "d2cac978-3a24-4593-9a93-a1f77148cc03", false, "Ullis" },
                    { "användare1id", 0, 1, "abd773f5-46c5-4294-beac-4617de11605d", "Hejaaa", "inga@hotmail.com", false, "Inga", true, true, "Karlsson", false, null, null, null, "mittnamnäringa", "0731111111", false, new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "43ca4d4c-afdc-49c6-81cd-6f8f994d6c7c", false, "Ingis" },
                    { "användare2id", 0, 1, "e052b86d-f591-47c3-81b0-cfc4f3f6162b", "Halloj", "gunvor@hotmail.se", false, "Gunvor", true, true, "Nilsson", false, null, null, null, "mittnamnärgunvor", "0732222222", false, new DateTime(2022, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "f948fed9-3279-4bf8-9364-f61f922ba49d", false, "Gunnis" },
                    { "användare3id", 0, 1, "195a2f68-025f-45d0-8b31-50450a408398", "dfggdffdgfdgdffdggdf", "Jögge@hotmail.se", false, "Jörgen", true, true, "Svensson", false, null, null, null, "mittnamnärjörgen", "0733333333", false, new DateTime(2022, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "b6227b8e-d680-4591-a7a0-e71ed9bb8db9", false, "Jöggis" },
                    { "användare4id", 0, 2, "bc86263b-3121-42ce-9d91-a7dff11ec6c1", "dfggdffdgfdgdffdggdf", "stenis@hotmail.se", false, "Sten", true, true, "Kallesson", false, null, null, null, "mittnamnärsten", "0744444444", false, new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "c9703483-4041-4a41-940d-b152b1e5a652", false, "Stenis" },
                    { "användare5id", 0, 3, "6f5cf880-a680-4214-ad7e-6891903406b4", "dfggdffdgfdgdffdggdf", "kajsa@hotmail.se", false, "Kajsa", true, true, "Stenbäck", false, null, null, null, "mittnamnärkajsa", "0751235555", false, new DateTime(2022, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "8bc75fe2-e14a-41d5-9c36-38f2b138f1cf", false, "Kajsis" },
                    { "användare6id", 0, 4, "f309ca80-6b89-42a0-9057-f904885b23cf", "dfggdffdgfdgdffdggdf", "frida@hotmail.se", false, "Frida", false, false, "Liljedahl", false, null, null, null, "mittnamnärfrida", "0755555555", false, new DateTime(2022, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "cca0a21c-d591-4d2d-95e9-4bfcfdb2ffb7", false, "Fridis" },
                    { "användare7id", 0, 2, "69b92aeb-4a4a-47a0-aee4-dbdd2bb9ec78", "dfggdffdgfdgdffdggdf", "linda@hotmail.se", false, "Linda", true, false, "Nordeman", false, null, null, null, "mittnamnärlinda", "0766666666", false, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "631f36ae-ac81-4467-87dd-3d9f850e3b8a", false, "Lindis" },
                    { "användare8id", 0, 3, "d1846d5c-371f-4f10-bb48-5d7d45ac2cd2", "dfggdffdgfdgdffdggdf", "lisa@hotmail.se", false, "Lisa", true, false, "Kjellgren", false, null, null, null, "mittnamnärlisa", "0777733333", false, new DateTime(2022, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "da01fb57-6855-4ce6-bcc0-6905913854b3", false, "Lisis" },
                    { "användare9id", 0, 2, "b4d11124-e74f-4cfe-9fed-162bc5a3bd11", "dfggdffdgfdgdffdggdf", "viktor@hotmail.se", false, "Viktor", false, false, "Hemlin Gravander", false, null, null, null, "mittnamnärviktor", "0733333333", false, new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "811dc210-e8b1-432c-a22a-5d438e5c3f89", false, "Vickis" }
                });

            migrationBuilder.InsertData(
                table: "CVs",
                columns: new[] { "ID", "TimesViewed", "UserID" },
                values: new object[,]
                {
                    { 1, 0, "användare1id" },
                    { 2, 3, "användare2id" },
                    { 3, 12, "användare3id" },
                    { 4, 55, "användare4id" },
                    { 5, 55, "användare5id" },
                    { 6, 55, "användare6id" },
                    { 7, 55, "användare7id" },
                    { 8, 55, "användare8id" },
                    { 9, 55, "användare9id" },
                    { 10, 55, "användare10id" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "Name", "Title", "UserID" },
                values: new object[] { 4, "image (1)223847664.png", "Profilbild", "användare1id" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "ID", "Date", "Read", "Receiver", "Sender", "SenderName", "Text" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "användare2id", "användare1id", null, "hejsan hoppsan" },
                    { 2, new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "användare1id", "användare3id", null, "halloj hur är det med dig?" },
                    { 3, new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "användare3id", null, "Kalle NoAccount", "hejsan hoppsansasasa lalalala" }
                });

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
                    { 1, 1, "Lund", "pratade i telefon", new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ICA", new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kundtjänst", "Work" },
                    { 2, 1, "Örebro", "Java", new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Örebro Universitet", new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Systemvetenskap", "Education" },
                    { 3, 1, "Göteborg", "HLR-utbildning", new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Företag1", new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HLR", "Course" },
                    { 4, 2, "Örebro", "Beskrivning blabla", new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Örebro Universitet", new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lärarprogrammet", "Education" },
                    { 5, 1, "Örebro", "Java", new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Örebro Universitet", new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Systemvetenskap", "Education" }
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
