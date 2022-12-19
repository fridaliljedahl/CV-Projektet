using CV_Projektet.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CV_Projektet.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    ProjectID = 1,
                    Name = "TestProject",
                    Description = "TestProject1Desc",
                    Test = "hej"
                },
                new Project
                {
                    ProjectID = 2,
                    Name = "TestProject2",
                    Description = "TestProject1Desc",
                    Test = "hej"
                });

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    FirstName = "Frida",
                    LastName = "Liljedahl"
                });
            modelBuilder.Entity<Message>().HasData(
                new Message
                {
                    Id = 1,
                    Sender = 1,
                    Receiver = 2,
                    Text = "hejsan",
                    Date = DateTime.Now,
                    Read = false
                });
        }
    }
}