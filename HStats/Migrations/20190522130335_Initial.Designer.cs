﻿// <auto-generated />
using System;
using HStats.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HStats.Migrations
{
    [DbContext(typeof(HStatsContext))]
    [Migration("20190522130335_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview5.19227.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HStats.Models.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClubName");

                    b.Property<string>("Country");

                    b.Property<string>("County");

                    b.Property<string>("Email");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Club");
                });

            modelBuilder.Entity("HStats.Models.CoachStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SCStatus");

                    b.HasKey("Id");

                    b.ToTable("CoachStatus");
                });

            modelBuilder.Entity("HStats.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClubId");

                    b.Property<int?>("ClubId1");

                    b.Property<int?>("CoachStatusId");

                    b.Property<string>("Country");

                    b.Property<string>("County");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.Property<int?>("PlayerStatusId");

                    b.Property<int?>("RefereeStatusId");

                    b.Property<string>("Ssn");

                    b.Property<int?>("StaffStatusId");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.HasIndex("ClubId1");

                    b.HasIndex("CoachStatusId");

                    b.HasIndex("PlayerStatusId");

                    b.HasIndex("RefereeStatusId");

                    b.HasIndex("StaffStatusId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("HStats.Models.PlayerStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PStatus");

                    b.HasKey("Id");

                    b.ToTable("PlayerStatus");
                });

            modelBuilder.Entity("HStats.Models.RefereeStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RStatus");

                    b.HasKey("Id");

                    b.ToTable("RefereeStatus");
                });

            modelBuilder.Entity("HStats.Models.StaffStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SStatus");

                    b.HasKey("Id");

                    b.ToTable("StaffStatus");
                });

            modelBuilder.Entity("HStats.Models.Person", b =>
                {
                    b.HasOne("HStats.Models.Club", "Club")
                        .WithMany()
                        .HasForeignKey("ClubId");

                    b.HasOne("HStats.Models.Club", "Club1")
                        .WithMany()
                        .HasForeignKey("ClubId1");

                    b.HasOne("HStats.Models.CoachStatus", "CoachStatus")
                        .WithMany()
                        .HasForeignKey("CoachStatusId");

                    b.HasOne("HStats.Models.PlayerStatus", "PlayerStatus")
                        .WithMany()
                        .HasForeignKey("PlayerStatusId");

                    b.HasOne("HStats.Models.RefereeStatus", "RefereeStatus")
                        .WithMany()
                        .HasForeignKey("RefereeStatusId");

                    b.HasOne("HStats.Models.StaffStatus", "StaffStatus")
                        .WithMany()
                        .HasForeignKey("StaffStatusId");
                });
#pragma warning restore 612, 618
        }
    }
}