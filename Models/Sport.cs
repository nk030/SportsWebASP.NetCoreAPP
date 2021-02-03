using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsWebASP.NetCoreAPP.Models
{
    public class Sport
    {
       [Key]
       public int SportId { get; set; } // PK for entity Sport
       public string Name { get; set; } // to store the name
       public string Description { get; set; } // to store the description
    }
}
