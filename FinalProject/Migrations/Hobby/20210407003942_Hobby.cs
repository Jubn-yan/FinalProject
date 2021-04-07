using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations.Hobby
{
    public partial class Hobby : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    FavoriteHobby = table.Column<string>(nullable: true),
                    SecondFavoriteHobby = table.Column<string>(nullable: true),
                    WhyYouLikeThem = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Id", "FavoriteHobby", "FullName", "SecondFavoriteHobby", "WhyYouLikeThem" },
                values: new object[] { 1, "Basketball", "Michael Ahlers", "Baseball", "I like staying active" });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Id", "FavoriteHobby", "FullName", "SecondFavoriteHobby", "WhyYouLikeThem" },
                values: new object[] { 2, "Fishing", "Josh Anness", "Basketball", "I like being outside and staying active" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hobbies");
        }
    }
}
