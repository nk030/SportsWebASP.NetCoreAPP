using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsWebASP.NetCoreAPP.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; } // PK for player entity
        public string Name { get; set; } // to store the player name
        public string Postition { get; set; } // to store the player position


        // defining player relations with other entities
        public int TeamId { get; set; }
        public Team TeamObj { get; set; }

        public int DivisionId { get; set; }
        public Division DivisionObj { get; set; }


        public int SportId { get; set; }
        public Sport SportObj { get; set; }

    }
}
