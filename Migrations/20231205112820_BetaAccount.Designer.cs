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
    [Migration("20231205112820_BetaAccount")]
    partial class BetaAccount
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
                            PasswordHash = new byte[] { 207, 116, 158, 21, 198, 199, 138, 187, 101, 62, 210, 248, 38, 8, 134, 138, 81, 177, 11, 65, 192, 196, 23, 101, 227, 144, 224, 172, 161, 77, 26, 6, 94, 200, 249, 141, 63, 48, 205, 148, 12, 45, 56, 203, 46, 125, 243, 190, 117, 66, 87, 232, 32, 87, 174, 131, 67, 0, 177, 151, 70, 205, 10, 199 },
                            PasswordSalt = new byte[] { 36, 46, 203, 65, 196, 253, 234, 251, 210, 113, 208, 57, 144, 111, 134, 166, 31, 227, 70, 125, 91, 45, 198, 21, 9, 82, 130, 45, 150, 251, 104, 97, 84, 25, 23, 252, 133, 81, 164, 246, 13, 228, 112, 189, 254, 70, 74, 155, 19, 10, 127, 227, 210, 58, 239, 239, 235, 99, 42, 142, 255, 221, 49, 82, 143, 136, 173, 190, 255, 92, 168, 214, 47, 7, 18, 24, 122, 59, 74, 56, 234, 189, 170, 43, 195, 212, 22, 223, 133, 229, 25, 167, 139, 82, 93, 10, 39, 224, 240, 99, 110, 91, 7, 53, 204, 129, 216, 20, 19, 28, 106, 68, 115, 216, 150, 186, 208, 62, 60, 78, 245, 57, 171, 92, 51, 87, 97, 20 },
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

                    b.Property<int>("SkillsId")
                        .HasColumnType("int");

                    b.Property<int>("Vocation")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("SkillsId");

                    b.ToTable("TB_CHARACTERS");
                });

            modelBuilder.Entity("TibiaApi.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AxeFigthing")
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

                    b.ToTable("TB_SKILLS");
                });

            modelBuilder.Entity("TibiaApi.Models.Character", b =>
                {
                    b.HasOne("TibiaApi.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TibiaApi.Models.Skill", "Skills")
                        .WithMany()
                        .HasForeignKey("SkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}