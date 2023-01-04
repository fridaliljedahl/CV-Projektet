using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class testdata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AspNetUsers",
                type: "nvarchar(350)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare10id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7493366a-b039-4c17-b229-a287234f7117", "11fa1511-9222-42f7-a006-02d3d4756d2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "272cc5fa-f480-49d6-a43e-23989234494e", "d54c5cf6-22a5-4707-be67-8b317d403082" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4ffcf43c-54ea-4e9e-9e7e-719c91e2e61c", "431054b1-5b85-4a33-890a-8db4ac10be8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "584797c2-a71f-4553-aa81-41e6d5022038", "c927476b-fd7a-49ba-bcf9-295185042d60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare4id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2868edff-db6e-439f-8b7d-b5cd98af2dbd", "383f0db9-5bc5-4d07-86bc-963ed0d0565c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare5id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "99303dd7-337a-424f-a610-8563f2739fb5", "cbcdc10d-505f-4897-9d45-5e8377e950f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare6id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b68c9208-6375-4ba0-ad95-e40efbecf307", "38b2fed6-9069-425c-b92d-815780d81c3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare7id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e4a86b4e-52b5-462b-a61c-9bdf71331ee7", "f757e1f3-ce36-4564-9582-0ba1d17b1610" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare8id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3b98e5d1-9bc3-4256-b0e3-461f3d4dfcbf", "33eec172-5e04-4e98-b031-a967aca17d1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare9id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fb87910e-4819-46ab-b962-3153059805af", "73ddd631-6c06-4c43-b833-e0d5d24cb539" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(350)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare10id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c54ec39d-840a-4dcc-a333-e9074ccb57a7", "d2cac978-3a24-4593-9a93-a1f77148cc03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "abd773f5-46c5-4294-beac-4617de11605d", "43ca4d4c-afdc-49c6-81cd-6f8f994d6c7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e052b86d-f591-47c3-81b0-cfc4f3f6162b", "f948fed9-3279-4bf8-9364-f61f922ba49d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "195a2f68-025f-45d0-8b31-50450a408398", "b6227b8e-d680-4591-a7a0-e71ed9bb8db9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare4id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bc86263b-3121-42ce-9d91-a7dff11ec6c1", "c9703483-4041-4a41-940d-b152b1e5a652" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare5id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6f5cf880-a680-4214-ad7e-6891903406b4", "8bc75fe2-e14a-41d5-9c36-38f2b138f1cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare6id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f309ca80-6b89-42a0-9057-f904885b23cf", "cca0a21c-d591-4d2d-95e9-4bfcfdb2ffb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare7id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "69b92aeb-4a4a-47a0-aee4-dbdd2bb9ec78", "631f36ae-ac81-4467-87dd-3d9f850e3b8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare8id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d1846d5c-371f-4f10-bb48-5d7d45ac2cd2", "da01fb57-6855-4ce6-bcc0-6905913854b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare9id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b4d11124-e74f-4cfe-9fed-162bc5a3bd11", "811dc210-e8b1-432c-a22a-5d438e5c3f89" });
        }
    }
}
