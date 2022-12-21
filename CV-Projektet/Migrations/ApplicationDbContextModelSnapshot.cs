﻿// <auto-generated />
using System;
using CV_Projektet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CV_Projektet.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CV_Projektet.Models.Address", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            City = "Örebro",
                            PostalCode = 12345,
                            Street = "Storgatan 1"
                        });
                });

            modelBuilder.Entity("CV_Projektet.Models.Competence", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Competences");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "C#"
                        });
                });

            modelBuilder.Entity("CV_Projektet.Models.CV", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("TimesViewed")
                        .HasColumnType("int");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("CVs");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            TimesViewed = 0,
                            UserID = "användare1id"
                        });
                });

            modelBuilder.Entity("CV_Projektet.Models.CV_Competences", b =>
                {
                    b.Property<int>("CVID")
                        .HasColumnType("int");

                    b.Property<int>("CompetenceID")
                        .HasColumnType("int");

                    b.HasKey("CVID", "CompetenceID");

                    b.HasIndex("CompetenceID");

                    b.ToTable("CV_Competences");

                    b.HasData(
                        new
                        {
                            CVID = 1,
                            CompetenceID = 1
                        });
                });

            modelBuilder.Entity("CV_Projektet.Models.CV_Projects", b =>
                {
                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<int>("CVID")
                        .HasColumnType("int");

                    b.HasKey("ProjectID", "CVID");

                    b.HasIndex("CVID");

                    b.ToTable("CV_Projects");

                    b.HasData(
                        new
                        {
                            ProjectID = 2,
                            CVID = 1
                        });
                });

            modelBuilder.Entity("CV_Projektet.Models.Experience", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("CVID")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CVID");

                    b.ToTable("Experiences");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CVID = 1,
                            City = "Lund",
                            Description = "pratade i telefon",
                            EndDate = new DateTime(2022, 12, 21, 9, 59, 52, 21, DateTimeKind.Local).AddTicks(9631),
                            Place = "ICA",
                            StartDate = new DateTime(2022, 12, 21, 9, 59, 52, 21, DateTimeKind.Local).AddTicks(9608),
                            Title = "Kundtjänst",
                            Type = "Work"
                        },
                        new
                        {
                            ID = 2,
                            CVID = 1,
                            City = "Örebro",
                            Description = "Java",
                            EndDate = new DateTime(2022, 12, 21, 9, 59, 52, 21, DateTimeKind.Local).AddTicks(9695),
                            Place = "Örebro Universitet",
                            StartDate = new DateTime(2022, 12, 21, 9, 59, 52, 21, DateTimeKind.Local).AddTicks(9691),
                            Title = "Systemvetenskap",
                            Type = "Education"
                        },
                        new
                        {
                            ID = 3,
                            CVID = 1,
                            City = "Göteborg",
                            Description = "HLR-utbildning",
                            EndDate = new DateTime(2022, 12, 21, 9, 59, 52, 21, DateTimeKind.Local).AddTicks(9723),
                            Place = "Företag1",
                            StartDate = new DateTime(2022, 12, 21, 9, 59, 52, 21, DateTimeKind.Local).AddTicks(9720),
                            Title = "HLR",
                            Type = "Course"
                        });
                });

            modelBuilder.Entity("CV_Projektet.Models.Message", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Read")
                        .HasColumnType("bit");

                    b.Property<string>("Receiver")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Sender")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("Receiver");

                    b.HasIndex("Sender");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Date = new DateTime(2022, 12, 21, 9, 59, 52, 21, DateTimeKind.Local).AddTicks(5390),
                            Read = false,
                            Receiver = "användare2id",
                            Sender = "användare1id",
                            Text = "hejsan hoppsan"
                        });
                });

            modelBuilder.Entity("CV_Projektet.Models.Project", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectLeader")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "TestProject1Desc",
                            Name = "TestProject",
                            ProjectLeader = "dsdsfsfddfs"
                        },
                        new
                        {
                            ID = 2,
                            Description = "TestProject1Desc",
                            Name = "TestProject2",
                            ProjectLeader = "dsdsfdassadfddfs"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CV_Projektet.Models.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<int>("AdressID")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("AdressID");

                    b.HasDiscriminator().HasValue("User");

                    b.HasData(
                        new
                        {
                            Id = "användare1id",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "de481468-3dbd-4cc8-bf52-ea48287d63b5",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4d93f61e-1ffb-4b88-8f01-c518f52df9da",
                            TwoFactorEnabled = false,
                            AdressID = 1,
                            FirstName = "Inga",
                            LastName = "Karlsson"
                        },
                        new
                        {
                            Id = "användare2id",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7ffa4be1-7575-4eed-8a44-c35b7bbb65f3",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bec51d34-248a-412c-bb47-991eb40487ce",
                            TwoFactorEnabled = false,
                            AdressID = 1,
                            FirstName = "Gunvor",
                            LastName = "Nilsson"
                        });
                });

            modelBuilder.Entity("CV_Projektet.Models.CV", b =>
                {
                    b.HasOne("CV_Projektet.Models.User", "user")
                        .WithOne("CV")
                        .HasForeignKey("CV_Projektet.Models.CV", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("CV_Projektet.Models.CV_Competences", b =>
                {
                    b.HasOne("CV_Projektet.Models.CV", "CV")
                        .WithMany("CV_Competences")
                        .HasForeignKey("CVID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CV_Projektet.Models.Competence", "Competence")
                        .WithMany("CV_Competences")
                        .HasForeignKey("CompetenceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CV");

                    b.Navigation("Competence");
                });

            modelBuilder.Entity("CV_Projektet.Models.CV_Projects", b =>
                {
                    b.HasOne("CV_Projektet.Models.CV", "CV")
                        .WithMany("CV_Project")
                        .HasForeignKey("CVID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CV_Projektet.Models.Project", "Project")
                        .WithMany("CV_Project")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CV");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("CV_Projektet.Models.Experience", b =>
                {
                    b.HasOne("CV_Projektet.Models.CV", "CV")
                        .WithMany("Experiences")
                        .HasForeignKey("CVID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CV");
                });

            modelBuilder.Entity("CV_Projektet.Models.Message", b =>
                {
                    b.HasOne("CV_Projektet.Models.User", "UserReceiver")
                        .WithMany("ReceivedMessages")
                        .HasForeignKey("Receiver")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CV_Projektet.Models.User", "UserSender")
                        .WithMany("SentMessages")
                        .HasForeignKey("Sender")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("UserReceiver");

                    b.Navigation("UserSender");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CV_Projektet.Models.User", b =>
                {
                    b.HasOne("CV_Projektet.Models.Address", "Address")
                        .WithMany("Users")
                        .HasForeignKey("AdressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("CV_Projektet.Models.Address", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("CV_Projektet.Models.Competence", b =>
                {
                    b.Navigation("CV_Competences");
                });

            modelBuilder.Entity("CV_Projektet.Models.CV", b =>
                {
                    b.Navigation("CV_Competences");

                    b.Navigation("CV_Project");

                    b.Navigation("Experiences");
                });

            modelBuilder.Entity("CV_Projektet.Models.Project", b =>
                {
                    b.Navigation("CV_Project");
                });

            modelBuilder.Entity("CV_Projektet.Models.User", b =>
                {
                    b.Navigation("CV")
                        .IsRequired();

                    b.Navigation("ReceivedMessages");

                    b.Navigation("SentMessages");
                });
#pragma warning restore 612, 618
        }
    }
}
