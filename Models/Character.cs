using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TibiaApi.Models.Enums;
using TibiaApi.Models;
using System.Text.Json.Serialization;

namespace TibiaApi.Models
{
    public class Character
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Name { get; set; } = string.Empty;
        public GenderEnum Gender { get; set; }
        public VocationEnum Vocation { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime AcessDate { get; set; }
        
        [JsonIgnore]
        public Skill Skills { get; set; }

        //Accounting
        [JsonIgnore]
        public Account Account { get; set; }
    }
}