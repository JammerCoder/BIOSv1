using System;

namespace BIOS.Model.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string BarCode { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public char Aisle { get; set; }
        public decimal OnHand { get; set; }
        public decimal Reorder { get; set; }
        public decimal Markup { get; set; }
        public DateTime LastUpdated { get; set; }

        public Guid RackId { get; set; }
        public Guid SupplierId { get; set; }

        public virtual Rack Rack { get; set; }
        public virtual Supplier Supplier { get; set; }

    }
}