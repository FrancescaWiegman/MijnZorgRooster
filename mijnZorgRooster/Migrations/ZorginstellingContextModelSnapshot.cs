﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mijnZorgRooster.DAL;

namespace mijnZorgRooster.Migrations
{
    [DbContext(typeof(ZorginstellingContext))]
    partial class ZorginstellingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("mijnZorgRooster.Models.Entities.Medewerker", b =>
                {
                    b.Property<int>("MedewerkerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Achternaam");

                    b.Property<string>("Adres");

                    b.Property<string>("Emailadres");

                    b.Property<DateTime>("Geboortedatum");

                    b.Property<string>("MobielNummer");

                    b.Property<string>("Postcode");

                    b.Property<string>("Telefoonnummer");

                    b.Property<string>("Tussenvoegsels");

                    b.Property<string>("Voornaam");

                    b.Property<string>("Woonplaats");

                    b.HasKey("MedewerkerID");

                    b.ToTable("Medewerker");
                });

            modelBuilder.Entity("mijnZorgRooster.Models.Entities.Rol", b =>
                {
                    b.Property<int>("RollID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MedewerkerID");

                    b.Property<string>("Naam");

                    b.HasKey("RollID");

                    b.HasIndex("MedewerkerID");

                    b.ToTable("Rol");
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

            modelBuilder.Entity("mijnZorgRooster.Models.Entities.Rol", b =>
                {
                    b.HasOne("mijnZorgRooster.Models.Entities.Medewerker")
                        .WithMany("Rollen")
                        .HasForeignKey("MedewerkerID");
                });
#pragma warning restore 612, 618
        }
    }
}
