using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations.Course
{
    public partial class Course : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    CourseName = table.Column<string>(nullable: true),
                    CourseID = table.Column<string>(nullable: true),
                    ProfessorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseID", "CourseName", "FullName", "ProfessorName" },
                values: new object[] { 1, "IT3080", "Contemporary Programming", "Michael Ahlers", "Dyllon Dekok" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseID", "CourseName", "FullName", "ProfessorName" },
                values: new object[] { 2, "IT3080", "Contemporary Programming", "Josh Anness", "Dyllon Dekok" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseID", "CourseName", "FullName", "ProfessorName" },
                values: new object[] { 3, "IT3045", "Database Management II", "Jeffrey Wallace", "Aditty Mutsuddi" });
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseID", "CourseName", "FullName", "ProfessorName" },
                values: new object[] { 4, "IT3045", "Database Management II", "Darrion Hoard", "Professor D" });
            migrationBuilder.InsertData(
              table: "Courses",
              columns: new[] { "Id", "CourseID", "CourseName", "FullName", "ProfessorName" },
              values: new object[] { 5, "IT3080", "Database Management II", "Bangyan Ju", "Dyllon Dekok" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
