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
    [Migration("20231205114417_CharacterSkills")]
    partial class CharacterSkills
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PasswordString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_ACCOUNTS");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "beta.tester@gmail.com",
                            PasswordHash = new byte[] { 206, 63, 207, 173, 32, 117, 60, 225, 183, 32, 126, 188, 56, 109, 15, 22, 55, 66, 245, 123, 105, 65, 218, 128, 125, 216, 221, 167, 227, 43, 169, 94, 190, 80, 16, 145, 57, 212, 200, 161, 134, 36, 254, 124, 119, 145, 105, 84, 37, 185, 169, 192, 241, 44, 82, 40, 221, 67, 137, 75, 192, 161, 149, 45 },
                            PasswordSalt = new byte[] { 198, 47, 249, 115, 253, 255, 186, 236, 3, 202, 100, 63, 188, 228, 116, 113, 245, 81, 103, 242, 142, 251, 97, 144, 157, 203, 234, 180, 213, 51, 73, 65, 238, 53, 9, 134, 250, 200, 204, 12, 219, 148, 145, 25, 54, 146, 247, 30, 68, 65, 193, 205, 87, 233, 251, 217, 128, 178, 173, 74, 155, 242, 72, 142, 209, 131, 43, 138, 38, 142, 44, 101, 186, 107, 54, 31, 111, 121, 159, 139, 242, 35, 89, 42, 193, 99, 187, 131, 173, 191, 128, 139, 121, 109, 214, 60, 84, 177, 11, 39, 22, 199, 5, 138, 43, 53, 167, 169, 237, 52, 144, 46, 77, 18, 83, 20, 236, 131, 37, 252, 152, 100, 1, 189, 141, 50, 209, 82 },
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

                    b.HasIndex("CharacterId")
                        .IsUnique();

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
                    b.HasOne("TibiaApi.Models.Character", "Character")
                        .WithOne("Skills")
                        .HasForeignKey("TibiaApi.Models.Skill", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("TibiaApi.Models.Character", b =>
                {
                    b.Navigation("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}
