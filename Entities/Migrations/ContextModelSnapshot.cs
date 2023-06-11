﻿// <auto-generated />
using System;
using Entities.AppContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entities.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Entities.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Court")
                        .HasColumnType("int");

                    b.Property<DateTime>("Schedule")
                        .HasColumnType("datetime2");

                    b.Property<int>("Score1")
                        .HasColumnType("int");

                    b.Property<int>("Score1Old")
                        .HasColumnType("int");

                    b.Property<int>("Score2")
                        .HasColumnType("int");

                    b.Property<int>("Score2Old")
                        .HasColumnType("int");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.Property<int>("Team1Id")
                        .HasColumnType("int");

                    b.Property<int>("Team2Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.HasIndex("Team1Id");

                    b.HasIndex("Team2Id");

                    b.ToTable("Games", null, t =>
                        {
                            t.HasTrigger("T_update_game");
                        });

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Court = 1,
                            Schedule = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Score1 = 2,
                            Score1Old = 0,
                            Score2 = 15,
                            Score2Old = 0,
                            StaffId = 2,
                            Team1Id = 1,
                            Team2Id = 2
                        },
                        new
                        {
                            Id = 2,
                            Court = 2,
                            Schedule = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Score1 = 21,
                            Score1Old = 0,
                            Score2 = 1,
                            Score2Old = 0,
                            StaffId = 2,
                            Team1Id = 3,
                            Team2Id = 1
                        });
                });

            modelBuilder.Entity("Entities.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "MasculinoA"
                        },
                        new
                        {
                            Id = 2,
                            Name = "MasculinoB"
                        },
                        new
                        {
                            Id = 3,
                            Name = "MasculinoC"
                        },
                        new
                        {
                            Id = 4,
                            Name = "FemeninoA"
                        },
                        new
                        {
                            Id = 5,
                            Name = "FemeninoB"
                        });
                });

            modelBuilder.Entity("Entities.Entities.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NIF")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<bool>("WantPics")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("NIF")
                        .IsUnique()
                        .HasFilter("[NIF] IS NOT NULL");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Instagram = "playerIg",
                            NIF = "12354678Z",
                            Name = "playerM1A1",
                            Phone = "111222333",
                            TeamId = 1,
                            WantPics = true
                        },
                        new
                        {
                            Id = 3,
                            Instagram = "playerIg",
                            NIF = "12354678A",
                            Name = "playerM1A2",
                            Phone = "111222333",
                            TeamId = 1,
                            WantPics = true
                        },
                        new
                        {
                            Id = 4,
                            Instagram = "playerIg",
                            NIF = "12354678B",
                            Name = "playerM1A3",
                            Phone = "111222333",
                            TeamId = 1,
                            WantPics = true
                        },
                        new
                        {
                            Id = 5,
                            Instagram = "playerIg",
                            NIF = "12354678C",
                            Name = "playerM2A1",
                            Phone = "111222333",
                            TeamId = 2,
                            WantPics = true
                        },
                        new
                        {
                            Id = 6,
                            Instagram = "playerIg",
                            NIF = "12354678D",
                            Name = "playerM2A2",
                            Phone = "111222333",
                            TeamId = 2,
                            WantPics = true
                        },
                        new
                        {
                            Id = 7,
                            Instagram = "playerIg",
                            NIF = "12354678E",
                            Name = "playerM2A3",
                            Phone = "111222333",
                            TeamId = 2,
                            WantPics = true
                        },
                        new
                        {
                            Id = 8,
                            Instagram = "playerIg",
                            NIF = "12354678F",
                            Name = "playerM3A1",
                            Phone = "111222333",
                            TeamId = 3,
                            WantPics = true
                        },
                        new
                        {
                            Id = 9,
                            Instagram = "playerIg",
                            NIF = "12354678G",
                            Name = "playerM3A2",
                            Phone = "111222333",
                            TeamId = 3,
                            WantPics = true
                        },
                        new
                        {
                            Id = 10,
                            Instagram = "playerIg",
                            NIF = "12354678H",
                            Name = "playerM3A3",
                            Phone = "111222333",
                            TeamId = 3,
                            WantPics = true
                        },
                        new
                        {
                            Id = 11,
                            Instagram = "playerIg",
                            NIF = "12354678I",
                            Name = "playerF1A1",
                            Phone = "111222333",
                            TeamId = 10,
                            WantPics = true
                        },
                        new
                        {
                            Id = 12,
                            Instagram = "playerIg",
                            NIF = "12354678J",
                            Name = "playerF1A2",
                            Phone = "111222333",
                            TeamId = 10,
                            WantPics = true
                        },
                        new
                        {
                            Id = 13,
                            Instagram = "playerIg",
                            NIF = "12354678K",
                            Name = "playerF2B1",
                            Phone = "111222333",
                            TeamId = 10,
                            WantPics = true
                        },
                        new
                        {
                            Id = 14,
                            Instagram = "playerIg",
                            NIF = "12354678ZL",
                            Name = "playerF2B3",
                            Phone = "111222333",
                            TeamId = 10,
                            WantPics = true
                        });
                });

            modelBuilder.Entity("Entities.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Classification_points")
                        .HasColumnType("int");

                    b.Property<int>("Defeats")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Pay")
                        .HasColumnType("bit");

                    b.Property<int>("Points_diff")
                        .HasColumnType("int");

                    b.Property<int>("Wins")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Masculino",
                            Classification_points = 0,
                            Defeats = 0,
                            GroupId = 1,
                            Name = "teamMasc1A",
                            Pay = false,
                            Points_diff = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 2,
                            Category = "Masculino",
                            Classification_points = 0,
                            Defeats = 0,
                            GroupId = 1,
                            Name = "teamMasc2A",
                            Pay = false,
                            Points_diff = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 3,
                            Category = "Masculino",
                            Classification_points = 0,
                            Defeats = 0,
                            GroupId = 1,
                            Name = "teamMasc3A",
                            Pay = false,
                            Points_diff = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 4,
                            Category = "Masculino",
                            Classification_points = 0,
                            Defeats = 0,
                            GroupId = 2,
                            Name = "teamMasc1B",
                            Pay = false,
                            Points_diff = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 5,
                            Category = "Masculino",
                            Classification_points = 0,
                            Defeats = 0,
                            GroupId = 2,
                            Name = "teamMasc2B",
                            Pay = false,
                            Points_diff = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 6,
                            Category = "Masculino",
                            Classification_points = 0,
                            Defeats = 0,
                            GroupId = 2,
                            Name = "teamMasc3B",
                            Pay = false,
                            Points_diff = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 7,
                            Category = "Masculino",
                            Classification_points = 0,
                            Defeats = 0,
                            GroupId = 3,
                            Name = "teamMasc1C",
                            Pay = false,
                            Points_diff = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 8,
                            Category = "Masculino",
                            Classification_points = 0,
                            Defeats = 0,
                            GroupId = 3,
                            Name = "teamMasc2C",
                            Pay = false,
                            Points_diff = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 9,
                            Category = "Masculino",
                            Classification_points = 0,
                            Defeats = 0,
                            GroupId = 3,
                            Name = "teamMasc3C",
                            Pay = false,
                            Points_diff = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 10,
                            Category = "Femenino",
                            Classification_points = 0,
                            Defeats = 0,
                            GroupId = 4,
                            Name = "teamFem1A",
                            Pay = false,
                            Points_diff = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 11,
                            Category = "Femenino",
                            Classification_points = 0,
                            Defeats = 0,
                            GroupId = 4,
                            Name = "teamFem2A",
                            Pay = false,
                            Points_diff = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 12,
                            Category = "Femenino",
                            Classification_points = 0,
                            Defeats = 0,
                            GroupId = 5,
                            Name = "teamFem1B",
                            Pay = false,
                            Points_diff = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 13,
                            Category = "Femenino",
                            Classification_points = 0,
                            Defeats = 0,
                            GroupId = 5,
                            Name = "teamFem2B",
                            Pay = false,
                            Points_diff = 0,
                            Wins = 0
                        });
                });

            modelBuilder.Entity("Entities.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlayerId")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Mail")
                        .IsUnique();

                    b.HasIndex("PlayerId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Mail = "kingofthetower3x3@gmail.com",
                            Name = "José Ramón",
                            Role = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Mail = "jorapijo42@gmail.com",
                            Name = "José Ramón",
                            Role = "staff"
                        },
                        new
                        {
                            Id = 3,
                            Mail = "jorapijo@gmail.com",
                            Name = "José Ramón",
                            Role = "base_user"
                        });
                });

            modelBuilder.Entity("Entities.Entities.Game", b =>
                {
                    b.HasOne("Entities.Entities.User", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Entities.Team", "Team1")
                        .WithMany()
                        .HasForeignKey("Team1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Entities.Team", "Team2")
                        .WithMany()
                        .HasForeignKey("Team2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Staff");

                    b.Navigation("Team1");

                    b.Navigation("Team2");
                });

            modelBuilder.Entity("Entities.Entities.Player", b =>
                {
                    b.HasOne("Entities.Entities.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Entities.Entities.Team", b =>
                {
                    b.HasOne("Entities.Entities.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("Entities.Entities.User", b =>
                {
                    b.HasOne("Entities.Entities.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId");

                    b.Navigation("Player");
                });
#pragma warning restore 612, 618
        }
    }
}
