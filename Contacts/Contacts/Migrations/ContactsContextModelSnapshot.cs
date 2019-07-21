﻿// <auto-generated />
using System;
using Contacts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Contacts.Migrations
{
    [DbContext(typeof(ContactsContext))]
    partial class ContactsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview5.19227.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Contacts.Models.AgeCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AgeCategoryName");

                    b.HasKey("Id");

                    b.ToTable("AgeCategory");
                });

            modelBuilder.Entity("Contacts.Models.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClubName");

                    b.Property<int?>("DistrictId");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.ToTable("Club");
                });

            modelBuilder.Entity("Contacts.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AgeCategoryId");

                    b.Property<int?>("ClubId");

                    b.Property<int?>("DistrictId");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber1");

                    b.Property<string>("PhoneNumber2");

                    b.Property<int?>("RoleId");

                    b.Property<int?>("SeasonId");

                    b.Property<int?>("SportId");

                    b.Property<string>("Ssn");

                    b.Property<int?>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("AgeCategoryId");

                    b.HasIndex("ClubId");

                    b.HasIndex("DistrictId");

                    b.HasIndex("RoleId");

                    b.HasIndex("SeasonId");

                    b.HasIndex("SportId");

                    b.HasIndex("TeamId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("Contacts.Models.ContactRaw", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AgeCategory");

                    b.Property<string>("Club");

                    b.Property<string>("District");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber1");

                    b.Property<string>("PhoneNumber2");

                    b.Property<string>("Role");

                    b.Property<string>("Season");

                    b.Property<string>("Sport");

                    b.Property<string>("Ssn");

                    b.Property<string>("Team");

                    b.HasKey("Id");

                    b.ToTable("ContactRaw");
                });

            modelBuilder.Entity("Contacts.Models.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DistrictName");

                    b.HasKey("Id");

                    b.ToTable("District");
                });

            modelBuilder.Entity("Contacts.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Contacts.Models.SIFModels.SIFArena", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArenaNumber");

                    b.Property<string>("ArenanAddress");

                    b.Property<string>("ArenanBench");

                    b.Property<string>("ArenanBuildYear");

                    b.Property<string>("ArenanCapacity");

                    b.Property<string>("ArenanCategory");

                    b.Property<string>("ArenanChair");

                    b.Property<string>("ArenanCity");

                    b.Property<string>("ArenanCountry");

                    b.Property<string>("ArenanDistrict");

                    b.Property<string>("ArenanHandicapSlots");

                    b.Property<string>("ArenanLastChecked");

                    b.Property<string>("ArenanLatestInspected");

                    b.Property<string>("ArenanName");

                    b.Property<string>("ArenanPhoneNumbers");

                    b.Property<string>("ArenanReBuildYear");

                    b.Property<string>("ArenanSoftChair");

                    b.Property<string>("ArenanStanding");

                    b.Property<string>("ArenanZipCode");

                    b.HasKey("Id");

                    b.ToTable("SIFArena");
                });

            modelBuilder.Entity("Contacts.Models.SIFModels.SIFClub", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActiveIOL");

                    b.Property<string>("ClubAddress");

                    b.Property<string>("ClubCity");

                    b.Property<string>("ClubCountry");

                    b.Property<string>("ClubDistrict");

                    b.Property<string>("ClubName");

                    b.Property<string>("ClubNote");

                    b.Property<string>("ClubNumber");

                    b.Property<string>("HomeArena");

                    b.Property<string>("Organizer");

                    b.Property<string>("ShortName");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("SIFClub");
                });

            modelBuilder.Entity("Contacts.Models.SIFModels.SIFRef", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber1");

                    b.Property<string>("PhoneNumber2");

                    b.Property<string>("RefCategory");

                    b.Property<string>("RefCategoryType");

                    b.Property<string>("RefClub");

                    b.Property<string>("RefDistrict");

                    b.Property<string>("RefNumber");

                    b.Property<string>("RefType");

                    b.Property<string>("SSN");

                    b.Property<string>("SeasonRegistred");

                    b.Property<string>("Status");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("SIFRef");
                });

            modelBuilder.Entity("Contacts.Models.Schedule.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email1");

                    b.Property<string>("Email2");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber1");

                    b.Property<string>("PhoneNumber2");

                    b.Property<string>("PhoneNumber3");

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Contacts.Models.Schedule.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Friday");

                    b.Property<decimal>("HoursFriday");

                    b.Property<decimal>("HoursMonday");

                    b.Property<decimal>("HoursSaturday");

                    b.Property<decimal>("HoursSunday");

                    b.Property<decimal>("HoursThursday");

                    b.Property<decimal>("HoursTuesday");

                    b.Property<decimal>("HoursWednesday");

                    b.Property<string>("Monday");

                    b.Property<int?>("PersonId");

                    b.Property<string>("Saturday");

                    b.Property<string>("Sunday");

                    b.Property<string>("Thursday");

                    b.Property<decimal>("TotalHours");

                    b.Property<string>("Tuesday");

                    b.Property<string>("Wednesday");

                    b.Property<int?>("WeekNumber");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("Contacts.Models.Season", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SeasonName");

                    b.HasKey("Id");

                    b.ToTable("Season");
                });

            modelBuilder.Entity("Contacts.Models.Sport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SportName");

                    b.HasKey("Id");

                    b.ToTable("Sport");
                });

            modelBuilder.Entity("Contacts.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TeamName");

                    b.HasKey("Id");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("Contacts.Models.Club", b =>
                {
                    b.HasOne("Contacts.Models.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId");
                });

            modelBuilder.Entity("Contacts.Models.Contact", b =>
                {
                    b.HasOne("Contacts.Models.AgeCategory", "AgeCategory")
                        .WithMany()
                        .HasForeignKey("AgeCategoryId");

                    b.HasOne("Contacts.Models.Club", "Club")
                        .WithMany()
                        .HasForeignKey("ClubId");

                    b.HasOne("Contacts.Models.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId");

                    b.HasOne("Contacts.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("Contacts.Models.Season", "Season")
                        .WithMany()
                        .HasForeignKey("SeasonId");

                    b.HasOne("Contacts.Models.Sport", "Sport")
                        .WithMany()
                        .HasForeignKey("SportId");

                    b.HasOne("Contacts.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("Contacts.Models.Schedule.Schedule", b =>
                {
                    b.HasOne("Contacts.Models.Schedule.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");
                });
#pragma warning restore 612, 618
        }
    }
}
