using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TibiaApi.Models;
using TibiaApi.Utils;

namespace TibiaApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){

        }

        public DbSet<Account> TB_ACCOUNTS { get; set; }
        public DbSet<Character> TB_CHARACTERS { get; set; }
        public DbSet<Skill> TB_SKILLS { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Creating first Account for tests
            Cryptography.CreatePasswordHash("123456", out byte[] hash, out byte[]salt);
            Account account = new Account()
            {
                Id = 1,
                Username = "BetaTester",
                Email = "beta.tester@gmail.com",
                PasswordString = string.Empty,
                PasswordHash = hash,
                PasswordSalt = salt,
                CreationDate = DateTime.Now,
            };
            modelBuilder.Entity<Account>().HasData(account);

            //Creating skills for BetaCharacter
            modelBuilder.Entity<Skill>().HasData(
                new Skill()
                {
                    Id = 1,
                    CharacterId = 1,
                    Level = 8,
                    MagicLevel = 1,
                    FistFigthing = 10,
                    ClubFigthing = 10,
                    SwordFigthing = 10,
                    AxeFigthing = 10,
                    DistanceFigthing = 10,
                    Shielding = 10,
                    Fishing = 10
                }
            );

            //Creating first Character for tests
            Character character = new Character()
            {
                Id = 1,
                AccountId = 1,
                Name = "BetaCharacter",
                Gender = Models.Enums.GenderEnum.Male,
                Vocation = Models.Enums.VocationEnum.Knight,
                CreationDate = DateTime.Now,
            };
            modelBuilder.Entity<Character>().HasData(character);
        }
    }
}