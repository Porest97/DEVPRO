using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HStats.Models;

namespace HStats.Models
{
    public class HStatsContext : DbContext
    {
        public HStatsContext (DbContextOptions<HStatsContext> options)
            : base(options)
        {
        }

        public DbSet<HStats.Models.Person> Person { get; set; }

        public DbSet<HStats.Models.TSMRef> TSMRef { get; set; }

        public DbSet<HStats.Models.Game> Game { get; set; }

        public DbSet<HStats.Models.Arena> Arena { get; set; }

        public DbSet<HStats.Models.Series> Series { get; set; }
    }
}
