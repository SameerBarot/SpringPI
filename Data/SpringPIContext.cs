using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpringPI.Models;

namespace SpringPI.Data
{
    public class SpringPIContext : DbContext
    {
        public SpringPIContext (DbContextOptions<SpringPIContext> options)
            : base(options)
        {
        }

        public DbSet<SpringPI.Models.Furniture> Furniture { get; set; } = default!;
    }
}
