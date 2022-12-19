using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class test12345 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Message",
                table: "Message");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ac76e0b-f48a-4982-8730-fde78f10b7ba");

            migrationBuilder.RenameTable(
                name: "Message",
                newName: "Messages");

            migrationBuilder.RenameColumn(
                name: "Test",
                table: "Projects",
                newName: "ProjectLeader");

            migrationBuilder.RenameColumn(
                name: "ProjectID",
                table: "Projects",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Messages",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "AdressID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sender",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Receiver",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                table: "Messages",
                column: "ID");

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
                name: "CVs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CVs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CV = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "ID", "City", "PostalCode", "Street" },
                values: new object[] { 1, "Örebro", 12345, "Storgatan 1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Date", "Receiver", "Sender" },
                values: new object[] { new DateTime(2022, 12, 19, 12, 56, 44, 683, DateTimeKind.Local).AddTicks(690), "user2", "user1" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 1,
                column: "ProjectLeader",
                value: "dsdsfsfddfs");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 2,
                column: "ProjectLeader",
                value: "dsdsfdassadfddfs");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AdressID", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2752ccf8-4e4a-49c9-a3d1-f4c92834799d", 0, 1, "d30ffda3-aa57-4a9a-abc0-ccd29f470d72", "User", null, false, "Frida", "Liljedahl", false, null, null, null, null, null, false, null, "bf873dfc-e4d4-4e80-98db-89a06763fa0c", false, null });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AdressID",
                table: "AspNetUsers",
                column: "AdressID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Addresses_AdressID",
                table: "AspNetUsers",
                column: "AdressID",
                principalTable: "Addresses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Addresses_AdressID",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "CVs");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AdressID",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                table: "Messages");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2752ccf8-4e4a-49c9-a3d1-f4c92834799d");

            migrationBuilder.DropColumn(
                name: "AdressID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Messages",
                newName: "Message");

            migrationBuilder.RenameColumn(
                name: "ProjectLeader",
                table: "Projects",
                newName: "Test");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Projects",
                newName: "ProjectID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Message",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Sender",
                table: "Message",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Receiver",
                table: "Message",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Message",
                table: "Message",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8ac76e0b-f48a-4982-8730-fde78f10b7ba", 0, "da00d4a5-d2d7-410e-8c51-7933f1940550", "User", null, false, "Frida", "Liljedahl", false, null, null, null, null, null, false, "d573fdc1-7bde-4eb9-a37e-55313fd66e9e", false, null });

            migrationBuilder.UpdateData(
                table: "Message",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Receiver", "Sender" },
                values: new object[] { new DateTime(2022, 12, 19, 10, 35, 18, 825, DateTimeKind.Local).AddTicks(3904), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 1,
                column: "Test",
                value: "hej");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 2,
                column: "Test",
                value: "hej");
        }
    }
}
