using boutiq.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace boutiq.Data
{
    public class StockContext : DbContext
    {
        public StockContext()
        {
        }

        public StockContext(DbContextOptions<StockContext> options) : base(options)
        {

        }
        public DbSet<Stock> Stock { get; set; }
    }
}

