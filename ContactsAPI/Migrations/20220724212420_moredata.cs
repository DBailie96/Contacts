using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactsAPI.Migrations
{
    public partial class moredata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 1,
                column: "Address",
                value: "Amanzimtoti, Durban");

            migrationBuilder.UpdateData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "DateOfBirth" },
                values: new object[] { "Bloemfontein", new DateTime(1999, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "DateOfBirth" },
                values: new object[] { "Western Cape", new DateTime(1998, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "DateOfBirth" },
                values: new object[] { "Pinetown, Durban", new DateTime(1991, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "DateOfBirth" },
                values: new object[] { "Western Cape", new DateTime(1998, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "contact",
                columns: new[] { "Id", "Address", "DateOfBirth", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 6, "Baloni, Gauteng", new DateTime(1997, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miguel", "Serrao", "0799693943" },
                    { 7, "Amanzimtoti, Durban", new DateTime(1996, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brendon", "Du Plessis", "0799693943" },
                    { 8, "Kloof, Durban", new DateTime(1996, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shaun", "Mhlanga", "0799693943" },
                    { 9, "Benoni, Gauteng", new DateTime(1995, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Skye", "Mclennan", "0799693943" },
                    { 10, "Waterfall, Durban", new DateTime(1994, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nathan", "Geel", "0799693943" },
                    { 11, "Westville, Durban", new DateTime(1994, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Justin", "Pillay", "0799693943" },
                    { 12, "Queensburgh, Durban", new DateTime(1998, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tannah", "Renou", "0799693943" },
                    { 13, "Pietermaritzburg, Durban", new DateTime(1998, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luke", "Venter", "0799693943" },
                    { 14, "Western Cape", new DateTime(1993, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jason", "Smit", "0799693943" },
                    { 15, "Pretoria", new DateTime(1996, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terence", "Frade", "0799693943" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 1,
                column: "Address",
                value: "test");

            migrationBuilder.UpdateData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "DateOfBirth" },
                values: new object[] { "test", new DateTime(1996, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "DateOfBirth" },
                values: new object[] { "test", new DateTime(1996, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "DateOfBirth" },
                values: new object[] { "test", new DateTime(1996, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "contact",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "DateOfBirth" },
                values: new object[] { "test", new DateTime(1996, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
