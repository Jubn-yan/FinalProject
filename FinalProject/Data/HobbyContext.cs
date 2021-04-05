using Microsoft.EntityFrameworkCore;
using FinalProject.Models;
using System;

namespace FinalProject.Data
{
    public class HobbyContext : DbContext
    {
        public HobbyContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hobby> Hobbies { get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Hobby>().HasData(
                new Hobby
                {
                    ID = 1,
                    FullName = "Michael Ahlers",
                    FavoriteHobby = "Basketball",
                    SecondFavoriteHobby = "Baseball",
                    WhyYouLikeThem = "I like staying active"
                },
                new Hobby
                {
                    ID = 2,
                    FullName = "Josh Anness",
                    FavoriteHobby = "Fishing",
                    SecondFavoriteHobby = "Basketball",
                    WhyYouLikeThem = "I like being outside and staying active"
                }
            );
        }
    }
}