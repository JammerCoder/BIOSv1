using BIOS.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIOS.Data.Context
{
    public class BIOSContext : DbContext
    {
        public BIOSContext() : base("BIOSConnectionString")
        {

        }

        public DbSet<Rack> Racks { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
