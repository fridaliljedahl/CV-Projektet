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

        public DbSet<Address> Addresses { get; set; }
        public DbSet<CV> CVs { get; set; }
        //public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<Work> Works { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Address>().HasData(
               new Address
               {
                   ID = 1,
                   Street = "Storgatan 1",
                   PostalCode = 12345,
                   City = "Örebro"
               });
            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    ID = 1,
                    Name = "TestProject",
                    Description = "TestProject1Desc",
                    ProjectLeader = "dsdsfsfddfs"
                },
                new Project
                {
                    ID = 2,
                    Name = "TestProject2",
                    Description = "TestProject1Desc",
                    ProjectLeader = "dsdsfdassadfddfs"
                });
            modelBuilder.Entity<CV>().HasData(
                new CV
                {
                    ID = 1,
                    TimesViewed = 0
                });
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    FirstName = "Frida",
                    LastName = "Liljedahl",
                    AdressID = 1
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
            modelBuilder.Entity<ProjectsInCV>()
                .HasKey(pc => new { pc.ProjectID, pc.CVID });
               
            modelBuilder.Entity<ProjectsInCV>().HasData(
               new ProjectsInCV
               {
                   ProjectID = 2,
                   CVID = 1
               });
            modelBuilder.Entity<Work>().HasData(
               new Work
               {
                   ID = 1,
                   RoleName = "Kundtjänst",
                   StartDate = DateTime.Now,
                   EndDate = DateTime.Now,
                   City = "Lund",
                   LocationName = "ICA",
                   Description = "pratade i telefon",
                   CVID = 1
               });
            modelBuilder.Entity<Education>().HasData(
               new Education
               {
                   ID = 2,
                   Name = "Systemvetenskap",
                   StartDate = DateTime.Now,
                   EndDate = DateTime.Now,
                   City = "Örebro",
                   LocationName = "Örebro Universitet",
                   Description = "Java",
                   CVID = 1
               });
            modelBuilder.Entity<Experience>().HasData(
               new Experience
               {
                   ID = 3,
                   StartDate = DateTime.Now,
                   EndDate = DateTime.Now,
                   City = "Göteborg",
                   LocationName = "Företaget",
                   Description = "HLR-utbildning",
                   CVID = 1
               });
        }
    }
}