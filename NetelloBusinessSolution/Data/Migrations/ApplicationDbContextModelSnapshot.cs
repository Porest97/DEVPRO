﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetelloBusinessSolution.Data;

namespace NetelloBusinessSolution.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview5.19227.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("NetelloBusinessSolution.Models.BusinessCentre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CentreName");

                    b.Property<string>("CentreNotes");

                    b.Property<int?>("CentreNumber");

                    b.Property<int?>("CompanyId");

                    b.Property<string>("Country");

                    b.Property<string>("County");

                    b.Property<int?>("NumberOfFloors");

                    b.Property<int?>("PersonId");

                    b.Property<int?>("PersonId1");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("PersonId");

                    b.HasIndex("PersonId1");

                    b.ToTable("BusinessCentre");
                });

            modelBuilder.Entity("NetelloBusinessSolution.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("CompanyName");

                    b.Property<string>("CompanyRegNO");

                    b.Property<string>("Country");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("PhoneNumber1");

                    b.Property<string>("PhoneNumber2");

                    b.Property<string>("PhoneNumber3");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("NetelloBusinessSolution.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("NetelloBusinessSolution.Models.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BusinessCentreId");

                    b.Property<int?>("CourseId");

                    b.Property<string>("DocumentDescription");

                    b.Property<string>("DocumentName");

                    b.Property<int?>("PersonId");

                    b.Property<DateTime>("TimeStamp");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("BusinessCentreId");

                    b.HasIndex("CourseId");

                    b.HasIndex("PersonId");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("NetelloBusinessSolution.Models.DworkinWiFiSurveyResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("A");

                    b.Property<int?>("AccessPoints");

                    b.Property<string>("AccessPointsBrandModel");

                    b.Property<string>("B");

                    b.Property<int?>("BusinessCentreId");

                    b.Property<string>("C");

                    b.Property<string>("D");

                    b.Property<string>("E");

                    b.Property<string>("F");

                    b.Property<string>("G");

                    b.Property<int?>("PersonId");

                    b.Property<DateTime?>("ReportDate");

                    b.Property<decimal?>("TimeOnSite");

                    b.Property<string>("Version");

                    b.HasKey("Id");

                    b.HasIndex("BusinessCentreId");

                    b.HasIndex("PersonId");

                    b.ToTable("DworkinWiFiSurveyResult");
                });

            modelBuilder.Entity("NetelloBusinessSolution.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<int?>("CompanyId");

                    b.Property<string>("Country");

                    b.Property<int?>("CourseId");

                    b.Property<string>("FirstName");

                    b.Property<string>("IdentityUserId");

                    b.Property<string>("LastName");

                    b.Property<int?>("PersonTypeId");

                    b.Property<string>("PhoneNumber1");

                    b.Property<string>("PhoneNumber2");

                    b.Property<string>("Ssn");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CourseId");

                    b.HasIndex("IdentityUserId");

                    b.HasIndex("PersonTypeId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("NetelloBusinessSolution.Models.PersonType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PersonTypeName");

                    b.HasKey("Id");

                    b.ToTable("PersonType");
                });

            modelBuilder.Entity("NetelloBusinessSolution.Models.PurchaseOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BusinessCentreId");

                    b.Property<string>("Descrition");

                    b.Property<DateTime?>("JobbEnded");

                    b.Property<DateTime?>("JobbScheduled");

                    b.Property<DateTime?>("JobbStarted");

                    b.Property<decimal>("KostPerHour");

                    b.Property<int?>("PersonId");

                    b.Property<int?>("PersonId1");

                    b.Property<string>("PurchaseOrderNumber");

                    b.Property<decimal>("TimeOnSite");

                    b.Property<decimal>("TotalKost");

                    b.HasKey("Id");

                    b.HasIndex("BusinessCentreId");

                    b.HasIndex("PersonId");

                    b.HasIndex("PersonId1");

                    b.ToTable("PurchaseOrder");
                });

            modelBuilder.Entity("NetelloBusinessSolution.Models.SupportCase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BusinessCentreId");

                    b.Property<string>("Descrition");

                    b.Property<int?>("PersonId");

                    b.Property<int?>("PersonId1");

                    b.Property<int?>("PurchaseOrderId");

                    b.Property<DateTime?>("TimeFEScheduled");

                    b.Property<DateTime?>("TimeReported");

                    b.Property<DateTime?>("TimeSolved");

                    b.Property<DateTime?>("TimeStarted");

                    b.Property<decimal?>("TotalTimeOnSite");

                    b.HasKey("Id");

                    b.HasIndex("BusinessCentreId");

                    b.HasIndex("PersonId");

                    b.HasIndex("PersonId1");

                    b.HasIndex("PurchaseOrderId");

                    b.ToTable("SupportCase");
                });

            modelBuilder.Entity("NetelloBusinessSolution.Models.SupportTicket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BusinessCentreId");

                    b.Property<string>("FaultDescription");

                    b.Property<string>("FaultReport");

                    b.Property<int?>("PersonId");

                    b.Property<int?>("PersonId1");

                    b.Property<string>("TicketLog");

                    b.Property<DateTime?>("TimeStampClosed");

                    b.Property<DateTime>("TimeStampCreated");

                    b.Property<DateTime?>("TimeStampResolved");

                    b.HasKey("Id");

                    b.HasIndex("BusinessCentreId");

                    b.HasIndex("PersonId");

                    b.HasIndex("PersonId1");

                    b.ToTable("SupportTicket");
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

            modelBuilder.Entity("NetelloBusinessSolution.Models.BusinessCentre", b =>
                {
                    b.HasOne("NetelloBusinessSolution.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("NetelloBusinessSolution.Models.Person", "CentreContact")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.HasOne("NetelloBusinessSolution.Models.Person", "CentreManager")
                        .WithMany()
                        .HasForeignKey("PersonId1");
                });

            modelBuilder.Entity("NetelloBusinessSolution.Models.Document", b =>
                {
                    b.HasOne("NetelloBusinessSolution.Models.BusinessCentre", null)
                        .WithMany("BCDocuments")
                        .HasForeignKey("BusinessCentreId");

                    b.HasOne("NetelloBusinessSolution.Models.Course", null)
                        .WithMany("Documents")
                        .HasForeignKey("CourseId");

                    b.HasOne("NetelloBusinessSolution.Models.Person", "Owner")
                        .WithMany()
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("NetelloBusinessSolution.Models.DworkinWiFiSurveyResult", b =>
                {
                    b.HasOne("NetelloBusinessSolution.Models.BusinessCentre", "BusinessCentre")
                        .WithMany()
                        .HasForeignKey("BusinessCentreId");

                    b.HasOne("NetelloBusinessSolution.Models.Person", "AssignedFE")
                        .WithMany()
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("NetelloBusinessSolution.Models.Person", b =>
                {
                    b.HasOne("NetelloBusinessSolution.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("NetelloBusinessSolution.Models.Course", null)
                        .WithMany("People")
                        .HasForeignKey("CourseId");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");

                    b.HasOne("NetelloBusinessSolution.Models.PersonType", "PersonType")
                        .WithMany()
                        .HasForeignKey("PersonTypeId");
                });

            modelBuilder.Entity("NetelloBusinessSolution.Models.PurchaseOrder", b =>
                {
                    b.HasOne("NetelloBusinessSolution.Models.BusinessCentre", "BusinessCentre")
                        .WithMany()
                        .HasForeignKey("BusinessCentreId");

                    b.HasOne("NetelloBusinessSolution.Models.Person", "OrderedBy")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.HasOne("NetelloBusinessSolution.Models.Person", "AssignedFE")
                        .WithMany()
                        .HasForeignKey("PersonId1");
                });

            modelBuilder.Entity("NetelloBusinessSolution.Models.SupportCase", b =>
                {
                    b.HasOne("NetelloBusinessSolution.Models.BusinessCentre", "BusinessCentre")
                        .WithMany()
                        .HasForeignKey("BusinessCentreId");

                    b.HasOne("NetelloBusinessSolution.Models.Person", "OrderedBy")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.HasOne("NetelloBusinessSolution.Models.Person", "AssignedFE")
                        .WithMany()
                        .HasForeignKey("PersonId1");

                    b.HasOne("NetelloBusinessSolution.Models.PurchaseOrder", "PurchaseOrder")
                        .WithMany()
                        .HasForeignKey("PurchaseOrderId");
                });

            modelBuilder.Entity("NetelloBusinessSolution.Models.SupportTicket", b =>
                {
                    b.HasOne("NetelloBusinessSolution.Models.BusinessCentre", "BusinessCentre")
                        .WithMany()
                        .HasForeignKey("BusinessCentreId");

                    b.HasOne("NetelloBusinessSolution.Models.Person", "OrderedBy")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.HasOne("NetelloBusinessSolution.Models.Person", "AssignedFE")
                        .WithMany()
                        .HasForeignKey("PersonId1");
                });
#pragma warning restore 612, 618
        }
    }
}
