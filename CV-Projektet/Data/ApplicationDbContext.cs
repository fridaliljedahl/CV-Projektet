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


            modelBuilder.Entity<Address>().HasData(
               new Address
               {
                   ID = 1,
                   Street = "Storgatan 1",
                   PostalCode = 12345,
                   City = "Örebro"
               },
               new Address
               {
                   ID = 2,
                   Street = "Drottninggatan 12",
                   PostalCode = 12365,
                   City = "Ystad"
               },
               new Address
               {
                   ID = 3,
                   Street = "Kungsgatan 43",
                   PostalCode = 16845,
                   City = "Göteborg"
               },
               new Address
               {
                   ID = 4,
                   Street = "Storälven 22",
                   PostalCode = 16845,
                   City = "Gnesta"
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
                    IsPublic = true,
                    RegistrationDate = new DateTime(2022, 01, 05)
                },
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
                    IsPublic = true,
                    RegistrationDate = new DateTime(2022, 06, 11)
                },
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
                    IsPublic = true,
                    RegistrationDate = new DateTime(2022, 12, 24)
                },
                new User
                {
                    Id = "användare4id",
                    FirstName = "Sten",
                    LastName = "Kallesson",
                    AdressID = 2,
                    Description = "dfggdffdgfdgdffdggdf",
                    Email = "stenis@hotmail.se",
                    PhoneNumber = "074-444 44 44",
                    PasswordHash = "mittnamnärsten",
                    IsActive = true,
                    IsPublic = true,
                    RegistrationDate = new DateTime(2022, 12, 26)
                },
                new User
                {
                    Id = "användare5id",
                    FirstName = "Kajsa",
                    LastName = "Stenbäck",
                    AdressID = 3,
                    Description = "dfggdffdgfdgdffdggdf",
                    Email = "kajsa@hotmail.se",
                    PhoneNumber = "075-123 55 55",
                    PasswordHash = "mittnamnärkajsa",
                    IsActive = true,
                    IsPublic = true,
                    RegistrationDate = new DateTime(2022, 09, 28)
                },
                new User
                {
                    Id = "användare6id",
                    FirstName = "Frida",
                    LastName = "Liljedahl",
                    AdressID = 4,
                    Description = "dfggdffdgfdgdffdggdf",
                    Email = "frida@hotmail.se",
                    PhoneNumber = "075-555 55 55",
                    PasswordHash = "mittnamnärfrida",
                    IsActive = false,
                    IsPublic = false,
                    RegistrationDate = new DateTime(2022, 07, 28)
                },
                new User
                {
                    Id = "användare7id",
                    FirstName = "Linda",
                    LastName = "Nordeman",
                    AdressID = 2,
                    Description = "dfggdffdgfdgdffdggdf",
                    Email = "linda@hotmail.se",
                    PhoneNumber = "076-666 66 66",
                    PasswordHash = "mittnamnärlinda",
                    IsActive = true,
                    IsPublic = false,
                    RegistrationDate = new DateTime(2022, 08, 11)
                },
                new User
                {
                    Id = "användare8id",
                    FirstName = "Lisa",
                    LastName = "Kjellgren",
                    AdressID = 3,
                    Description = "dfggdffdgfdgdffdggdf",
                    Email = "lisa@hotmail.se",
                    PhoneNumber = "077-773 33 33",
                    PasswordHash = "mittnamnärlisa",
                    IsActive = true,
                    IsPublic = false,
                    RegistrationDate = new DateTime(2022, 08, 26)
                },
                new User
                {
                    Id = "användare9id",
                    FirstName = "Viktor",
                    LastName = "Hemlin Gravander",
                    AdressID = 2,
                    Description = "dfggdffdgfdgdffdggdf",
                    Email = "viktor@hotmail.se",
                    PhoneNumber = "073-333 33 33",
                    PasswordHash = "mittnamnärviktor",
                    IsActive = false,
                    IsPublic = false,
                    RegistrationDate = new DateTime(2021, 10, 05)
                },
                new User
                {
                    Id = "användare10id",
                    FirstName = "Ulla",
                    LastName = "Ivarsson",
                    AdressID = 4,
                    Description = "dfggdffdgfdgdffdggdf",
                    Email = "ulla@hotmail.se",
                    PhoneNumber = "073-888 33 33",
                    PasswordHash = "mittnamnärulla",
                    IsActive = false,
                    IsPublic = true,
                    RegistrationDate = new DateTime(2020, 10, 05)
                });

            modelBuilder.Entity<CV>().HasData(
                new CV
                {
                    ID = 1,
                    TimesViewed = 0,
                    UserID = "användare1id"
                },
                new CV
                {
                    ID = 2,
                    TimesViewed = 3,
                    UserID = "användare3id"
                },
                new CV
                {
                    ID = 3,
                    TimesViewed = 12,
                    UserID = "användare2id"
                },
                new CV
                {
                    ID = 4,
                    TimesViewed = 55,
                    UserID = "användare4id"
                });
                
            modelBuilder.Entity<ImageModel>().HasData(
                new ImageModel
                {
                    ID = 4,
                    Title = "Profilbild",
                    Name = "image (1)223847664.png",
                    UserID = "användare1id"
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

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    ID = 1,
                    Name = "Planeringsprojektet",
                    Description = "Projektbeskrivningen blabla",
                    ProjectLeaderID = "användare1id",
                    CreatedDate = new DateTime(2021, 05, 12)
                },
                new Project
                {
                    ID = 2,
                    Name = "Yogahemsideprojektet",
                    Description = "Projektbeskrivningen blabla",
                    ProjectLeaderID = "användare2id",
                    CreatedDate = new DateTime(2020, 08, 12)
                },
                new Project
                {
                    ID = 3,
                    Name = "CV-Projektet",
                    Description = "Projektbeskrivningen blabla",
                    ProjectLeaderID = "användare3id",
                    CreatedDate = new DateTime(2022, 09, 29)
                },
                new Project
                {
                    ID = 4,
                    Name = "Mötesprojektet",
                    Description = "Projektbeskrivningen blabla",
                    ProjectLeaderID = "användare4id",
                    CreatedDate = new DateTime(2022, 12, 27)
                });

            modelBuilder.Entity<CV_Competences>()
                .HasKey(cc => new { cc.CVID, cc.CompetenceID });

            modelBuilder.Entity<Competence>().HasData(
                new Competence
                {
                    ID = 1,
                    Name = "C#"
                },
                new Competence
                {
                    ID = 2,
                    Name = "Java"
                },
                new Competence
                {
                    ID = 3,
                    Name = "Kassavana"
                },
                new Competence
                {
                    ID = 4,
                    Name = "HLR"
                });
            modelBuilder.Entity<CV_Competences>().HasData(
                new CV_Competences
                {
                    CVID = 1,
                    CompetenceID = 1
                },
                new CV_Competences
                {
                    CVID = 1,
                    CompetenceID = 2
                },
                new CV_Competences
                {
                    CVID = 2,
                    CompetenceID = 3
                },
                new CV_Competences
                {
                    CVID = 2,
                    CompetenceID = 2
                },
                new CV_Competences
                {
                    CVID = 2,
                    CompetenceID = 4
                },
                new CV_Competences
                {
                    CVID = 3,
                    CompetenceID = 4
                },
                new CV_Competences
                {
                    CVID = 4,
                    CompetenceID = 1
                },
                new CV_Competences
                {
                    CVID = 4,
                    CompetenceID = 2
                },
                new CV_Competences
                {
                    CVID = 4,
                    CompetenceID = 3
                });

            modelBuilder.Entity<User_Projects>().HasData(
               new User_Projects
               {
                   UserID = "användare1id",
                   ProjectID = 1
               },
               new User_Projects
               {
                   UserID = "användare1id",
                   ProjectID = 2
               },
               new User_Projects
               {
                   UserID = "användare2id",
                   ProjectID = 1
               },
               new User_Projects
               {
                   UserID = "användare2id",
                   ProjectID = 3
               },
               new User_Projects
               {
                   UserID = "användare3id",
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
               },
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
               },
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
               },
               new Experience
               {
                   ID = 4,
                   Title = "Lärarprogrammet",
                   Type = "Education",
                   StartDate = DateTime.Now,
                   EndDate = DateTime.Now,
                   City = "Örebro",
                   Place = "Örebro Universitet",
                   Description = "Beskrivning blabla",
                   CVID = 2
               },
               new Experience
               {
                   ID = 5,
                   Title = "Systemvetenskap",
                   Type = "Education",
                   StartDate = DateTime.Now,
                   EndDate = DateTime.Now,
                   City = "Örebro",
                   Place = "Örebro Universitet",
                   Description = "Java",
                   CVID = 1
               }
               );
        }
    }
}
