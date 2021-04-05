using System;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
  public class MemberContext : DbContext
  {

    public MemberContext(DbContextOptions options) : base(options)
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
              Birthdate = new DateTime(2002, 01, 13)
          },
          new info
          {
              ID = 3,
              FullName = "Michael Ahlers",
              CollegeProgram = "IT",
              YearInProgram = "Sophmore",
              Birthdate = new DateTime(1990, 05, 12)
          }
        );
    }
  }
}