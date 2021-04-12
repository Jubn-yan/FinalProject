using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations.Food
{
    public partial class Food : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    FavoriteFood = table.Column<string>(nullable: true),
                    SecondFavoriteFood = table.Column<string>(nullable: true),
                    FavoriteMealTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "FavoriteFood", "FavoriteMealTime", "FullName", "SecondFavoriteFood" },
                values: new object[,]
                {
                    { 1, "Pizza", "Lunch", "Michael Ahlers", "Wings" },
                    { 2, "Burger", "Dinner", "Josh Anness", "Pizza" },
                    { 3, "Cooking", "I like exploring", "Jeffrey Wallace", "Photography" },
                    { 4, "Cooking", "I love to eat and learning new submission points", "Darrion Hoard", "Jiu Jitsu" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");
        }
    }
}
