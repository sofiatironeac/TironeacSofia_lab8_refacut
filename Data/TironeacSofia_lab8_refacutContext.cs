using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TironeacSofia_lab8_refacut.Models;

namespace TironeacSofia_lab8_refacut.Data
{
    public class TironeacSofia_lab8_refacutContext : DbContext
    {
        public TironeacSofia_lab8_refacutContext (DbContextOptions<TironeacSofia_lab8_refacutContext> options)
            : base(options)
        {
        }

        public DbSet<TironeacSofia_lab8_refacut.Models.Book> Book { get; set; }

        public DbSet<TironeacSofia_lab8_refacut.Models.Publisher> Publisher { get; set; }

        public DbSet<TironeacSofia_lab8_refacut.Models.Category> Category { get; set; }
    }
}
