using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MVC.Models;

namespace MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
            public DbSet<Student> Students { get; set;}
            public DbSet<Customer> Customers{ get; set;}
            public DbSet<Employee> Employees {get; set;}


    }
}