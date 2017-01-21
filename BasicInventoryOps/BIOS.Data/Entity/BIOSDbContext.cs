using BIOS.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIOS.Data.Entity
{
    public class BIOSDbContext : DbContext
    {
        public BIOSDbContext() : base("BIOSConnectionString")
        {
        }

        public DbSet<Rack> Racks { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
