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
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Competence> Competences { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Message>()

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
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    FirstName = "hej",
                    LastName = "hejsan",
                    AdressID = 1
                });
            modelBuilder.Entity<Message>().HasData(
                new Message
                {
                    ID = 1,
                    Sender = "lkjdhfs",
                    Receiver = "liksdf",
                    Text = "hejsan",
                    Date = DateTime.Now,
                    Read = false
                });
            modelBuilder.Entity<CV_Project>()
                .HasKey(pc => new { pc.ProjectID, pc.CVID });

            modelBuilder.Entity<CV_Competence>()
                .HasKey(cc => new { cc.CVID, cc.CompetenceID });

            modelBuilder.Entity<Competence>().HasData(
                new Competence
                {
                    ID = 1,
                    Name = "C#"
                });
            modelBuilder.Entity<CV_Competence>().HasData(
                new CV_Competence
                {
                    CVID = 1,
                    CompetenceID = 1
                });

            modelBuilder.Entity<CV_Project>().HasData(
               new CV_Project
               {
                   ProjectID = 2,
                   CVID = 1
               });
            modelBuilder.Entity<Experience>().HasData(
               new Experience
               {
                   ID = 1,
                   Title = "Kundtjänst",
                   Type = "Work",
                   StartDate = DateTime.Now,
                   EndDate = DateTime.Now,
                   City = "Lund",
                   Place = "ICA",
                   Description = "pratade i telefon",
                   CVID = 1
               });
            modelBuilder.Entity<Experience>().HasData(
               new Experience
               {
                   ID = 2,
                   Title = "Systemvetenskap",
                   Type = "Education",
                   StartDate = DateTime.Now,
                   EndDate = DateTime.Now,
                   City = "Örebro",
                   Place = "Örebro Universitet",
                   Description = "Java",
                   CVID = 1
               });
            modelBuilder.Entity<Experience>().HasData(
               new Experience
               {
                   ID = 3,
                   Title = "HLR",
                   Type = "Course",
                   StartDate = DateTime.Now,
                   EndDate = DateTime.Now,
                   City = "Göteborg",
                   Place = "Företag1",
                   Description = "HLR-utbildning",
                   CVID = 1
               });
        }
    }
}