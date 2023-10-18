using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TibiaApi.Models
{
    public class CharacterStats
    {
        public int Level { get; set; }
        public int MagicLevel { get; set; }
        public int FistFigthing { get; set; }
        public int ClubFigthing { get; set; }
        public int SwordFigthing { get; set; }
        public int AxeFigthing { get; set; }
        public int DistanceFigthing { get; set; }
        public int Shielding { get; set; }
        public int Fishing { get; set; }
    }
}