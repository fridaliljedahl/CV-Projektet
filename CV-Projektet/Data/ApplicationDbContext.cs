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
                    ID = 1,
                    Name = "TestProject",
                    Description = "TestProject1Desc"
                },
                new Project
                {
                    ID = 2,
                    Name = "TestProject2",
                    Description = "TestProject1Desc"
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
                    ID = 1,
                    Sender = "user1",
                    Receiver = "user2",
                    Text = "hejsan",
                    Date = DateTime.Now,
                    Read = false
                });
        }
    }
}