using Microsoft.EntityFrameworkCore;
using Demo.Models;

namespace Demo.Data
{
    public class ActionDbContext : DbContext
    {
    public ActionDbContext (DbContextOptions<ActionDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> PersonID { get; set; }
        public DbSet<Person> PersonName { get; set; }
        public DbSet<Person> PersonAddress { get; set; }
    }
}