using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.DAL.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public double TotalAmount { get; set; }
        public string Note { get; set; }
        public string CancelReason { get; set; }
        public Guid PaymentId { get; set; }
        public Guid StatusId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ApplicationUser UpdatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public ApplicationUser CreatedBy { get; set; }


    }
}
