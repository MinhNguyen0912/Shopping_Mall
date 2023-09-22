using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.DAL.Entities
{
    public class Products
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }
        public double Discount { get; set; }
        public string Currency { get; set; }
        public string DefaultImage { get; set; }
        public string OriginLinkDetail { get; set; }
        public string Url { get; set; }
        public int Stock { get; set; }
        public Guid StatusId { get; set; }
        public Guid BrandId { get; set; }
        public Guid CategoryId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }

    }
}
