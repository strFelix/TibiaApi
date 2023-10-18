using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TibiaApi.Models.Enums;
using TibiaApi.Models;

namespace TibiaApi.Models
{
    public class Character
    {
        public int CharacterId { get; set; }
        public string CharacterName { get; set; } = string.Empty;
        public GenderEnum CharacterGender { get; set; }
        public VocationEnum CharacterVocation { get; set; }
        public DateTime CharacterCreationDate { get; set; }
        public DateTime CharacterAcessDate { get; set; }
        public List<CharacterStats>? CharInfo { get; set; }
    }
}