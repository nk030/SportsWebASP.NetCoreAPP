using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportsWebASP.NetCoreAPP.Models;

namespace SportsWebASP.NetCoreAPP.Data
{
    public class SportsWebASPNetCoreAPPContext : DbContext
    {
        public SportsWebASPNetCoreAPPContext (DbContextOptions<SportsWebASPNetCoreAPPContext> options)
            : base(options)
        {
        }

        public DbSet<SportsWebASP.NetCoreAPP.Models.Team> Team { get; set; }

        public DbSet<SportsWebASP.NetCoreAPP.Models.Division> Division { get; set; }

        public DbSet<SportsWebASP.NetCoreAPP.Models.Sport> Sport { get; set; }

        public DbSet<SportsWebASP.NetCoreAPP.Models.Player> Player { get; set; }
    }
}
