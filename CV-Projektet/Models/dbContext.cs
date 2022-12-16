using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace CV_Projektet.Models
{
    public class dataBaseContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }

        public dataBaseContext(DbContextOptions<dataBaseContext> options) : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
                new Project { Name = "TestProject", Description = "TestProject1Desc" },
            new Project { Name = "TestProject2", Description = "TestProject1Desc" });

        }
    }

}

