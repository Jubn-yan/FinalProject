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
    }
}