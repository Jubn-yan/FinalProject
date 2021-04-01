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
  }
}