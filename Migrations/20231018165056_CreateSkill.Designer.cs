﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TibiaApi.Data;

#nullable disable

namespace TibiaApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231018165056_CreateSkill")]
    partial class CreateSkill
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TibiaApi.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("AcessDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PasswordString")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_ACCOUNTS");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "beta.tester@gmail.com",
                            PasswordHash = new byte[] { 190, 163, 235, 11, 232, 6, 243, 222, 47, 192, 14, 99, 153, 10, 12, 6, 96, 134, 127, 75, 143, 78, 169, 244, 220, 5, 76, 134, 83, 110, 214, 39, 103, 232, 250, 4, 98, 251, 14, 140, 189, 196, 22, 87, 162, 167, 242, 43, 217, 144, 100, 166, 26, 161, 159, 210, 111, 68, 92, 90, 83, 138, 213, 217 },
                            PasswordSalt = new byte[] { 169, 78, 123, 76, 62, 193, 7, 74, 96, 132, 63, 97, 162, 214, 36, 60, 236, 239, 96, 28, 61, 172, 151, 13, 112, 27, 55, 113, 23, 57, 222, 221, 142, 180, 177, 58, 113, 178, 199, 185, 147, 126, 5, 235, 84, 32, 158, 54, 244, 169, 180, 127, 15, 143, 147, 2, 87, 137, 133, 189, 154, 162, 246, 166, 227, 89, 126, 147, 8, 159, 1, 112, 234, 195, 234, 45, 155, 15, 76, 119, 167, 215, 79, 59, 12, 199, 244, 94, 63, 220, 103, 34, 158, 180, 239, 101, 239, 143, 252, 52, 56, 210, 104, 179, 247, 184, 23, 137, 127, 62, 7, 65, 176, 84, 196, 187, 123, 209, 45, 117, 31, 81, 171, 146, 130, 16, 215, 34 },
                            PasswordString = "",
                            Username = "BetaTester"
                        });
                });

            modelBuilder.Entity("TibiaApi.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<DateTime>("AcessDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Vocation")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("TB_CHARACTERS");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountId = 1,
                            AcessDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreationDate = new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = 1,
                            Name = "BetaCharacter",
                            Vocation = 1
                        });
                });

            modelBuilder.Entity("TibiaApi.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AxeFigthing")
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("ClubFigthing")
                        .HasColumnType("int");

                    b.Property<int>("DistanceFigthing")
                        .HasColumnType("int");

                    b.Property<int>("Fishing")
                        .HasColumnType("int");

                    b.Property<int>("FistFigthing")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("MagicLevel")
                        .HasColumnType("int");

                    b.Property<int>("Shielding")
                        .HasColumnType("int");

                    b.Property<int>("SwordFigthing")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("TB_SKILLS");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AxeFigthing = 10,
                            CharacterId = 1,
                            ClubFigthing = 10,
                            DistanceFigthing = 10,
                            Fishing = 10,
                            FistFigthing = 10,
                            Level = 8,
                            MagicLevel = 1,
                            Shielding = 10,
                            SwordFigthing = 10
                        });
                });

            modelBuilder.Entity("TibiaApi.Models.Character", b =>
                {
                    b.HasOne("TibiaApi.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("TibiaApi.Models.Skill", b =>
                {
                    b.HasOne("TibiaApi.Models.Character", null)
                        .WithMany("Skills")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TibiaApi.Models.Character", b =>
                {
                    b.Navigation("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}
