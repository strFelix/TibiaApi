using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TibiaApi.Models.Enums;

namespace TibiaApi.Models
{
    public class Char
    {
        public int CharacterId { get; set; }
        public string CharacterName { get; set; } = string.Empty;
        public SexEnum CharacterSex { get; set; }
        public VocationEnum CharacterVocation { get; set; }
        public DateTime CharacterCreationDate { get; set; }
        public DateTime CharacterAcessDate { get; set; }
    }
}