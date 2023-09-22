using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.DAL.Entities
{
    public class OrderItem
    {
        public Guid Id { get; set; }    
        public int Quantity { get; set; }   
        public decimal Price { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public Guid PromotionId { get; set; }
        public bool IsDeleted { get; set; }
        public Guid UpdatedAt { get; set; }
        public Guid PudatedBy { get; set; }
        public Guid CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
