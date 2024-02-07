using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc9.Models;

namespace SalesWebMvc9.Data
{
    public class SalesWebMvc9Context : DbContext
    {
        public SalesWebMvc9Context (DbContextOptions<SalesWebMvc9Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller{ get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
