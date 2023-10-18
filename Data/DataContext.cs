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
                CreationDate = DateTime.Parse("14/10/2023"),
            };
            modelBuilder.Entity<Account>().HasData(account);

            //Creating first Character for tests
            Character character = new Character()
            {
                Id = 1,
                AccountId = 1,
                Name = "BetaCharacter",
                Gender = Models.Enums.GenderEnum.Male,
                Vocation = Models.Enums.VocationEnum.Knight,
                CreationDate = DateTime.Parse("18/10/2023"),
            };
            modelBuilder.Entity<Character>().HasData(character);
        }
    }
}