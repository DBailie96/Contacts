using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactsAPI.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "contact",
                columns: new[] { "Id", "Address", "DateOfBirth", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "test", new DateTime(1996, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", "Bailie", "0799693943" },
                    { 2, "test", new DateTime(1996, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Armand", "Van Den Berg", "0799693943" },
                    { 3, "test", new DateTime(1996, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrew", "Trautmann", "0799693943" },
                    { 4, "test", new DateTime(1996, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ashton", "Naidoo", "0799693943" },
                    { 5, "test", new DateTime(1996, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iviwe", "Malotana", "0799693943" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
