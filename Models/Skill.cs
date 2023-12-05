using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TibiaApi.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public int Level { get; set; }
        public int MagicLevel { get; set; }
        public int FistFigthing { get; set; }
        public int ClubFigthing { get; set; }
        public int SwordFigthing { get; set; }
        public int AxeFigthing { get; set; }
        public int DistanceFigthing { get; set; }
        public int Shielding { get; set; }
        public int Fishing { get; set; }

        [JsonIgnore]
        public Character Character { get; set; }
    }
}