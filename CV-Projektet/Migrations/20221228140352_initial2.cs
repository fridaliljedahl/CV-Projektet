using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare10id",
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "137e57f3-464a-41ca-89fb-3280df7bee74", "0738883333", "a23c5b84-fe87-41ee-b3fd-06324370019c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "e141ad3b-f985-4759-a356-86561d5e9d1d", "0731111111", "328a3269-b45a-456b-b17c-3ddc194fd293" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "22169ad2-5e5d-459d-b7a7-2d324d1d0aff", "0732222222", "ce2f24e6-5555-4e94-b317-9e0844c52fc1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "d7a6f2aa-1495-4f42-8629-55f79a0412fe", "0733333333", "07a7f290-1d41-4693-a401-07965449a693" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare4id",
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "5ecf979f-5e34-40c5-83f0-b511abb52706", "0744444444", "ad2aaf96-f7f6-407e-a020-63b3e8a09de0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare5id",
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "e2f45748-e81b-477e-b8fe-2bc19b5cd068", "0751235555", "3174b41b-cf97-4f66-bbee-25313260559e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare6id",
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "31a2f19c-f346-4b42-93c6-a17f7cf5999e", "0755555555", "2afd598f-c0c3-416a-b1c2-b0e1b03dcf5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare7id",
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "87281c16-9331-465e-a9e0-46918cdc5c0b", "0766666666", "772eaf8e-46af-4092-970c-42ddb43e183f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare8id",
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "3cf7f71d-f461-4490-bf27-7d5801bab37a", "0777733333", "46d3b30f-d6de-432d-a479-c57746b2ce1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare9id",
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "3265d9bc-e7bd-4e94-8d77-1b6d02503459", "0733333333", "85a90edf-cd3c-4056-8227-45f33805fe3f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 28, 15, 3, 51, 743, DateTimeKind.Local).AddTicks(6858));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare10id",
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "2d51cf53-809a-4561-8ac7-66ea83716e05", "073-888 33 33", "107adb6c-3b15-4f8b-9d1f-254d4d5c247f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "2c7a5470-462e-4185-9d33-bd7d4d6c90ea", "073-111 11 11", "c4dc09ab-e50f-4c4b-a38c-2483c951a64c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "71fea3bf-745a-4e27-b7e0-795c98d2758f", "073-222 22 22", "14a8aa26-d2e3-4ec4-b962-e27cb6d3506e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "66576d19-aac3-49bd-bbeb-512974b1e983", "073-333 33 33", "ac8640ba-451c-4f53-aa54-bbaadb0e31bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare4id",
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "65c8db7e-c11a-4f6d-b3f0-da2f9672ae7d", "074-444 44 44", "66aa6ac9-ad45-4f2b-88f8-96c0e352858d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare5id",
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "526db4be-f070-41c9-9a46-7995523ec4b9", "075-123 55 55", "b1ac829c-2cb8-40ae-a078-cf094c485a8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare6id",
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "a367a7d5-033a-4cbe-bd04-17dcfe377764", "075-555 55 55", "433c7db1-99cf-4d51-a8a5-48069c823468" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare7id",
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "0e7a5342-361b-410c-a752-7823afead603", "076-666 66 66", "4a56f759-61c9-45fa-b7c3-6e0b27e022e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare8id",
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "7a74bec1-5df0-41af-a955-ece37690e41d", "077-773 33 33", "7c2e5182-ca58-4a22-9a3c-eebb3b17fd90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare9id",
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "b815dd32-2df8-4575-b9de-c101f144c614", "073-333 33 33", "e99cf35e-9c95-4f55-9a28-49ddc6705545" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 28, 14, 59, 40, 61, DateTimeKind.Local).AddTicks(2444));
        }
    }
}
