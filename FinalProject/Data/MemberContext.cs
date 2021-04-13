using System;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
  public class MemberContext : DbContext
  {

    public MemberContext(DbContextOptions<MemberContext> options) : base(options)
    {

    }

    public DbSet<info> Info {get; set;}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<info>().HasData(
          new info
          {
              ID = 1,
              FullName = "Michael Ahlers",
              CollegeProgram = "IT",
              YearInProgram = "Sophmore",
              Birthdate = new DateTime(1990, 05, 12)
          },
          new info
          {
              ID = 2,
              FullName = "Josh Anness",
              CollegeProgram = "IT",
              YearInProgram = "Sophmore",
              Birthdate = new DateTime(2002, 01, 02)
          },
           new info
           {
               ID = 3,
               FullName = "Jeffrey Wallace",
               CollegeProgram = "IT",
               YearInProgram = "Sophmore",
               Birthdate = new DateTime(2002, 01, 02)
           },
          new info
          {
              ID = 4,
              FullName = "Darrion Hoard",
              CollegeProgram = "IT",
              YearInProgram = "Junior",
              Birthdate = new DateTime(1994, 07, 13)
          },
          new info
          {
              ID = 5,
              FullName = "Bangyan Ju",
              CollegeProgram = "IT",
              YearInProgram = "Junior",
              Birthdate = new DateTime(2000, 02, 04)
          }
        );
    }
  }

  public class HobbyContext : DbContext
  {

    public HobbyContext(DbContextOptions<HobbyContext> options) : base(options)
    {

    }
    public DbSet<Hobby> Hobbies { get; set;}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Hobby>().HasData(
          new Hobby
          {
              Id = 1,
              FullName = "Michael Ahlers",
              FavoriteHobby = "Basketball",
              SecondFavoriteHobby = "Baseball",
              WhyYouLikeThem = "I like staying active"
          },
          new Hobby
          {
              Id = 2,
              FullName = "Josh Anness",
              FavoriteHobby = "Fishing",
              SecondFavoriteHobby = "Basketball",
              WhyYouLikeThem = "I like being outside and staying active"
          },
          new Hobby
          {
              Id = 3,
              FullName = "Jeffrey Wallace",
              FavoriteHobby = "Jeffrey Wallace",
              SecondFavoriteHobby = "Jeffrey Wallace",
              WhyYouLikeThem = "Jeffrey Wallace"
          },
          new Hobby
          {
              Id = 4,
              FullName = "Darrion Hoard",
              FavoriteHobby = "Cooking",
              SecondFavoriteHobby = "Jiu Jitsu",
              WhyYouLikeThem = "I love to eat and learning new submission points"
          },
          new Hobby
          {
              Id = 5,
              FullName = "Bangyan Ju",
              FavoriteHobby = "Cooking",
              SecondFavoriteHobby = "Playing Computergames",
              WhyYouLikeThem = "Cooking and playing games make me feel happy"
          }
        );
    }
  }
   public class CourseContext : DbContext 
    { 

        public CourseContext(DbContextOptions<CourseContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Course>().HasData(
            new Course
            {
              Id = 1,
              FullName = "Michael Ahlers",
              CourseName = "Contemporary Programming",
              CourseID = "IT3080",
              ProfessorName = "Dyllon Dekok"
            },
            new Course
            {
              Id = 2,
              FullName = "Josh Anness",
              CourseName = "Contemporary Programming",
              CourseID = "IT3080",
              ProfessorName = "Dyllon Dekok"
            },
            new Course
            {
              Id = 3,
              FullName = "Jeffrey Wallace",
              CourseName = "Database Management II",
              CourseID = "IT3045",
              ProfessorName = "Aditty Mutsuddi"
            },
            new Course
            {
                Id = 4,
                FullName = "Darrion Hoard",
                CourseName = "Database Management II",
                CourseID = "IT3045",
                ProfessorName = "Professor D"
            },
            new Course
            {
                Id = 5,
                FullName = "Bangyan Ju",
                CourseName = "Database Management II",
                CourseID = "IT3080",
                ProfessorName = "Dyllon Dekok"
            }
          );

        }
    }
}
