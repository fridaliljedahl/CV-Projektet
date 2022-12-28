using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_Projektet.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare10id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aafb901d-46f4-484c-8c44-bf140c23bb52", "ded68517-f372-49f9-904a-4a30019abc76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c09627bf-6be9-44b0-99f5-06edd1d846f4", "2b92959d-04c7-4ca5-bbc7-cd86d8ecbabb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "16de512a-9441-45e1-b95b-782a37e8ac79", "b0213d4d-fe2a-4e1c-88e5-4d9f26b3e2a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2d687985-2b35-4281-ba8c-45f95489f08b", "8a21576c-78c5-46a7-affc-5426b589c3d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare4id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fbe60369-bfa2-451f-97f6-0f259768023c", "01335c0f-a848-44f4-a864-2b5bd0c89711" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare5id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "34b862f9-a8d6-42c2-8ad5-c9c730aefcfd", "1cea89a3-0db1-47bd-ba43-02121f5ea0ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare6id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2500515b-b260-4f0f-8801-a87a8a69ba07", "7569a857-37e1-4397-8ff4-983960fd32e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare7id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "778f0380-cf4f-40a3-8cd0-b2776a33624c", "73bfbae1-ac6a-406e-9c01-d21769edfb53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare8id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e6858dcc-28a0-420b-8664-0b80f68a76b7", "8cd4ff7b-c213-4853-b5c5-e4818d2db6b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare9id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a5d2ae98-2009-4561-8d42-6ebe8b216ec4", "87a1d1e0-a314-485c-a914-2803dad0368c" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 28, 15, 5, 38, 3, DateTimeKind.Local).AddTicks(2188));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare10id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "137e57f3-464a-41ca-89fb-3280df7bee74", "a23c5b84-fe87-41ee-b3fd-06324370019c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare1id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e141ad3b-f985-4759-a356-86561d5e9d1d", "328a3269-b45a-456b-b17c-3ddc194fd293" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare2id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "22169ad2-5e5d-459d-b7a7-2d324d1d0aff", "ce2f24e6-5555-4e94-b317-9e0844c52fc1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare3id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d7a6f2aa-1495-4f42-8629-55f79a0412fe", "07a7f290-1d41-4693-a401-07965449a693" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare4id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5ecf979f-5e34-40c5-83f0-b511abb52706", "ad2aaf96-f7f6-407e-a020-63b3e8a09de0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare5id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e2f45748-e81b-477e-b8fe-2bc19b5cd068", "3174b41b-cf97-4f66-bbee-25313260559e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare6id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "31a2f19c-f346-4b42-93c6-a17f7cf5999e", "2afd598f-c0c3-416a-b1c2-b0e1b03dcf5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare7id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "87281c16-9331-465e-a9e0-46918cdc5c0b", "772eaf8e-46af-4092-970c-42ddb43e183f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare8id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3cf7f71d-f461-4490-bf27-7d5801bab37a", "46d3b30f-d6de-432d-a479-c57746b2ce1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "användare9id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3265d9bc-e7bd-4e94-8d77-1b6d02503459", "85a90edf-cd3c-4056-8227-45f33805fe3f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 28, 15, 3, 51, 743, DateTimeKind.Local).AddTicks(6858));
        }
    }
}
