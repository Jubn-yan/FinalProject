using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class HobbyContext : DbContext
    {
        public HobbyContext(DbContextOptions options) : base(options)
        {

        }
    }
}