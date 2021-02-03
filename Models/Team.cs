using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsWebASP.NetCoreAPP.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; } // PK of the team entity
        public string Name { get; set; }// to save team name
        [DataType(DataType.Date)]
        public DateTime Year { get; set; } // year of the team
    }
}
