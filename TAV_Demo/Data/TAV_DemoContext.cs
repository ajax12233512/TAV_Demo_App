using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TAV_Demo.Models;

namespace TAV_Demo.Data
{
    public class TAV_DemoContext : DbContext
    {
        public TAV_DemoContext (DbContextOptions<TAV_DemoContext> options)
            : base(options)
        {
        }

        public DbSet<TAV_Demo.Models.Car> Car { get; set; } = default!;
    }
}
