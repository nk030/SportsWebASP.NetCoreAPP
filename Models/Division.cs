using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsWebASP.NetCoreAPP.Models
{
    public class Division
    {
        [Key]
        public int DivisionId { get; set; } // PK for division entity
        public string Name { get; set; } // to store division name
    }
}
