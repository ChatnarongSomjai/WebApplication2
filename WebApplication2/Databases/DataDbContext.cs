using Microsoft.EntityFrameworkCore; //Import EF
using WebApplication2.Models;

namespace WebApplication2.Databases
{
    public class DataDbContext : DbContext
    {
        // Constructure Method
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) { }
        //Table manufacturers
        //Table devices
        public DbSet<positions> positions { get; set; }

        public DbSet<employees> employees { get; set; }
    }
}