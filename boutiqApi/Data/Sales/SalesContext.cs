using boutiq.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace boutiq.Data
{
    public class SalesContext : DbContext
    {
        public SalesContext()
        {
        }

        public SalesContext(DbContextOptions<SalesContext> options) : base(options)
        {

        }
        public DbSet<Sale> Sales { get; set; }
    }
}

