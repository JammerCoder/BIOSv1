using System;
using System.Collections.Generic;

namespace BIOS.Model.Models
{
    public class Supplier
    {
        public Supplier()
        {
            Products = new List<Product>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}