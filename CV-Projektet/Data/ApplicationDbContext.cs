using CV_Projektet.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CV_Projektet.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
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
		public DbSet<CV_Competences> CV_Competences { get; set; }
		public DbSet<User_Projects> User_Projects{ get; set; }
        public DbSet<ImageModel> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.UserSender)
                .WithMany(s => s.SentMessages)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.UserReceiver)
                .WithMany(s => s.ReceivedMessages)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Project>()
                .HasOne(p => p.ProjectLeader)
                .WithMany(l => l.LeadProjects)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(u => u.LeadProjects)
                .WithOne(p => p.ProjectLeader)
                .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<User_Projects>()
            //    .HasMany<Project>()


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
                    ProjectLeaderID = "användare1id"
                },
                new Project
                {
                    ID = 2,
                    Name = "TestProject2",
                    Description = "TestProject1Desc",
                    ProjectLeaderID = "användare2id"
                });
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = "användare1id",
                    FirstName = "Inga",
                    LastName = "Karlsson",
                    AdressID = 1,
                    Description = "Hejaaa",
                    Email = "inga@hotmail.com",
                    PhoneNumber = "073-111 11 11",
                    PasswordHash = "mittnamnäringa",
                    IsActive = true,
                    IsPrivate = false
                });
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = "användare2id",
                    FirstName = "Gunvor",
                    LastName = "Nilsson",
                    AdressID = 1,
                    Description = "Halloj",
                    Email = "gunvor@hotmail.se",
                    PhoneNumber = "073-222 22 22",
                    PasswordHash = "mittnamnärgunvor",
                    IsActive = true,
                    IsPrivate = true
                });
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = "användare3id",
                    FirstName = "Jörgen",
                    LastName = "Svensson",
                    AdressID = 1,
                    Description = "dfggdffdgfdgdffdggdf",
                    Email = "Jögge@hotmail.se",
                    PhoneNumber = "073-333 33 33",
                    PasswordHash = "mittnamnärjörgen",
                    IsActive = true,
                    IsPrivate = false
                });
            modelBuilder.Entity<CV>().HasData(
                new CV
                {
                    ID = 1,
                    TimesViewed = 0,
                    UserID = "användare1id"
                });
            modelBuilder.Entity<CV>().HasData(
                new CV
                {
                    ID = 2,
                    TimesViewed = 0,
                    UserID = "användare3id"
                });
            modelBuilder.Entity<Message>().HasData(
                new Message
                {
                    ID = 1,
                    Sender = "användare1id",
                    Receiver = "användare2id",
                    Text = "hejsan hoppsan",
                    Date = DateTime.Now,
                    Read = false
                });
            modelBuilder.Entity<User_Projects>()
                .HasKey(pc => new { pc.UserID, pc.ProjectID });

            modelBuilder.Entity<CV_Competences>()
                .HasKey(cc => new { cc.CVID, cc.CompetenceID });

            modelBuilder.Entity<Competence>().HasData(
                new Competence
                {
                    ID = 1,
                    Name = "C#"
                });
            modelBuilder.Entity<CV_Competences>().HasData(
                new CV_Competences
                {
                    CVID = 1,
                    CompetenceID = 1
                });

            modelBuilder.Entity<User_Projects>().HasData(
               new User_Projects
               {
                   UserID = "användare1id",
                   ProjectID = 1
               });
            modelBuilder.Entity<User_Projects>().HasData(
               new User_Projects
               {
                   UserID = "användare2id",
                   ProjectID = 2
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