using libreriaa_SLE.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace libreriaa_SLE.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<Books> Books { get; set; }




    }
}
