﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mijnZorgRooster.DAL;

namespace mijnZorgRooster.Migrations
{
    [DbContext(typeof(ZorginstellingDbContext))]
    [Migration("20190115210706_Rooster-Medewerke-Update")]
    partial class RoosterMedewerkeUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

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
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

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

            modelBuilder.Entity("mijnZorgRooster.Models.Entities.Certificaat", b =>
                {
                    b.Property<int>("CertificaatID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum");

                    b.Property<int>("MedewerkerID");

                    b.Property<DateTime>("geldigTot");

                    b.HasKey("CertificaatID");

                    b.HasIndex("MedewerkerID");

                    b.ToTable("Certificaat");
                });

            modelBuilder.Entity("mijnZorgRooster.Models.Entities.Contract", b =>
                {
                    b.Property<int>("ContractID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BeginDatum");

                    b.Property<int>("ContractUren");

                    b.Property<DateTime>("Einddatum");

                    b.Property<int?>("MedewerkerID");

                    b.Property<int>("ParttimePercentage");

                    b.Property<int>("VerlofDagenPerJaar");

                    b.HasKey("ContractID");

                    b.HasIndex("MedewerkerID");

                    b.ToTable("Contract");
                });

            modelBuilder.Entity("mijnZorgRooster.Models.Entities.Dienst", b =>
                {
                    b.Property<int>("DienstID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum");

                    b.Property<int?>("DienstProfielID");

                    b.Property<int?>("RoosterID");

                    b.HasKey("DienstID");

                    b.HasIndex("DienstProfielID");

                    b.HasIndex("RoosterID");

                    b.ToTable("Dienst");
                });

            modelBuilder.Entity("mijnZorgRooster.Models.Entities.DienstProfiel", b =>
                {
                    b.Property<int>("DienstProfielID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan>("Begintijd");

                    b.Property<string>("Beschrijving");

                    b.Property<TimeSpan>("Eindtijd");

                    b.Property<int>("MinimaleBezetting");

                    b.Property<int>("VolgordeNr");

                    b.HasKey("DienstProfielID");

                    b.ToTable("DienstProfiel");
                });

            modelBuilder.Entity("mijnZorgRooster.Models.Entities.Medewerker", b =>
                {
                    b.Property<int>("MedewerkerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Achternaam");

                    b.Property<string>("Adres");

                    b.Property<int?>("DienstID");

                    b.Property<string>("Emailadres")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<DateTime>("Geboortedatum");

                    b.Property<string>("MobielNummer");

                    b.Property<string>("Postcode");

                    b.Property<string>("Telefoonnummer");

                    b.Property<string>("Tussenvoegsels");

                    b.Property<string>("Voornaam");

                    b.Property<string>("Woonplaats");

                    b.HasKey("MedewerkerID");

                    b.HasIndex("DienstID");

                    b.ToTable("Medewerker");
                });

            modelBuilder.Entity("mijnZorgRooster.Models.Entities.MedewerkerDienst", b =>
                {
                    b.Property<int>("MedewerkerId");

                    b.Property<int>("DienstId");

                    b.HasKey("MedewerkerId", "DienstId");

                    b.HasIndex("DienstId");

                    b.ToTable("MedewerkerDiensten");
                });

            modelBuilder.Entity("mijnZorgRooster.Models.Entities.MedewerkerRol", b =>
                {
                    b.Property<int>("MedewerkerId");

                    b.Property<int>("RolId");

                    b.HasKey("MedewerkerId", "RolId");

                    b.HasIndex("RolId");

                    b.ToTable("MedewerkersRollen");
                });

            modelBuilder.Entity("mijnZorgRooster.Models.Entities.Rol", b =>
                {
                    b.Property<int>("RolID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam");

                    b.HasKey("RolID");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("mijnZorgRooster.Models.Entities.Rooster", b =>
                {
                    b.Property<int>("RoosterID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AanmaakDatum");

                    b.Property<bool>("IsGevalideerd");

                    b.Property<int>("Jaar");

                    b.Property<DateTime>("LaatsteWijzigingsDatum");

                    b.Property<int>("Maand");

                    b.HasKey("RoosterID");

                    b.ToTable("Rooster");
                });

            modelBuilder.Entity("mijnZorgRooster.Models.Entities.RoosterDienst", b =>
                {
                    b.Property<int>("RoosterId");

                    b.Property<int>("DienstId");

                    b.HasKey("RoosterId", "DienstId");

                    b.HasIndex("DienstId");

                    b.ToTable("RoosterDiensten");
                });

            modelBuilder.Entity("mijnZorgRooster.Models.Entities.RoosterDienstProfiel", b =>
                {
                    b.Property<int>("RoosterId");

                    b.Property<int>("DienstProfielId");

                    b.HasKey("RoosterId", "DienstProfielId");

                    b.HasIndex("DienstProfielId");

                    b.ToTable("RoosterDienstProfielen");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("mijnZorgRooster.Models.Entities.Certificaat", b =>
                {
                    b.HasOne("mijnZorgRooster.Models.Entities.Medewerker", "Medewerker")
                        .WithMany("Certificaten")
                        .HasForeignKey("MedewerkerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("mijnZorgRooster.Models.Entities.Contract", b =>
                {
                    b.HasOne("mijnZorgRooster.Models.Entities.Medewerker", "Medewerker")
                        .WithMany("Contracten")
                        .HasForeignKey("MedewerkerID");
                });

            modelBuilder.Entity("mijnZorgRooster.Models.Entities.Dienst", b =>
                {
                    b.HasOne("mijnZorgRooster.Models.Entities.DienstProfiel", "DienstProfiel")
                        .WithMany()
                        .HasForeignKey("DienstProfielID");

                    b.HasOne("mijnZorgRooster.Models.Entities.Rooster")
                        .WithMany("Diensten")
                        .HasForeignKey("RoosterID");
                });

            modelBuilder.Entity("mijnZorgRooster.Models.Entities.Medewerker", b =>
                {
                    b.HasOne("mijnZorgRooster.Models.Entities.Dienst")
                        .WithMany("Medewerkers")
                        .HasForeignKey("DienstID");
                });

            modelBuilder.Entity("mijnZorgRooster.Models.Entities.MedewerkerDienst", b =>
                {
                    b.HasOne("mijnZorgRooster.Models.Entities.Dienst", "Dienst")
                        .WithMany()
                        .HasForeignKey("DienstId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("mijnZorgRooster.Models.Entities.Medewerker", "Medewerker")
                        .WithMany()
                        .HasForeignKey("MedewerkerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("mijnZorgRooster.Models.Entities.MedewerkerRol", b =>
                {
                    b.HasOne("mijnZorgRooster.Models.Entities.Medewerker", "Medewerker")
                        .WithMany("MedewerkersRollen")
                        .HasForeignKey("MedewerkerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("mijnZorgRooster.Models.Entities.Rol", "Rol")
                        .WithMany("MedewerkersRollen")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("mijnZorgRooster.Models.Entities.RoosterDienst", b =>
                {
                    b.HasOne("mijnZorgRooster.Models.Entities.Dienst", "Dienst")
                        .WithMany()
                        .HasForeignKey("DienstId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("mijnZorgRooster.Models.Entities.Rooster", "Rooster")
                        .WithMany()
                        .HasForeignKey("RoosterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("mijnZorgRooster.Models.Entities.RoosterDienstProfiel", b =>
                {
                    b.HasOne("mijnZorgRooster.Models.Entities.DienstProfiel", "DienstProfiel")
                        .WithMany()
                        .HasForeignKey("DienstProfielId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("mijnZorgRooster.Models.Entities.Rooster", "Rooster")
                        .WithMany("RoosterDienstProfielen")
                        .HasForeignKey("RoosterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
