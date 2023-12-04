using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TibiaApi.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public int MagicLevel { get; set; }
        public int FistFigthing { get; set; }
        public int ClubFigthing { get; set; }
        public int SwordFigthing { get; set; }
        public int AxeFigthing { get; set; }
        public int DistanceFigthing { get; set; }
        public int Shielding { get; set; }
        public int Fishing { get; set; }

        public Character Character { get; set; }
        public int CharacterId { get; set; }

        public Skill DefaultSkills = new Skill(){
            Level = 8,
            MagicLevel = 0,
            FistFigthing = 10,
            ClubFigthing = 10,
            SwordFigthing = 10,
            AxeFigthing = 10,
            DistanceFigthing = 10,
            Shielding = 10,
            Fishing = 10
        };
        public Skill DefaultMageSkills = new Skill(){
            Level = 8,
            MagicLevel = 10,
            FistFigthing = 10,
            ClubFigthing = 10,
            SwordFigthing = 10,
            AxeFigthing = 10,
            DistanceFigthing = 10,
            Shielding = 10,
            Fishing = 10
        };
    }
}