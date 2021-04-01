using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class UpdatedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Info",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Info",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Info",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Info",
                columns: new[] { "ID", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[] { 1, new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Michael Ahlers", "Sophmore" });

            migrationBuilder.InsertData(
                table: "Info",
                columns: new[] { "ID", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[] { 2, new DateTime(1995, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Josh Anness", "Sophmore" });

            migrationBuilder.InsertData(
                table: "Info",
                columns: new[] { "ID", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[] { 3, new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Michael Ahlers", "Sophmore" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Info",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Info",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Info",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Info",
                columns: new[] { "ID", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[] { 1, new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Michael Ahlers", "Sophmore" });

            migrationBuilder.InsertData(
                table: "Info",
                columns: new[] { "ID", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[] { 2, new DateTime(1995, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Josh Anness", "Sophmore" });

            migrationBuilder.InsertData(
                table: "Info",
                columns: new[] { "ID", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[] { 3, new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Michael Ahlers", "Sophmore" });
        }
    }
}
