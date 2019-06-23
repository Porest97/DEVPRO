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
#pragma warning restore 612, 618
        }
    }
}
