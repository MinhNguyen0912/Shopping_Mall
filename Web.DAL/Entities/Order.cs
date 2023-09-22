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
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public Decimal TotalAmount { get; set; }
        public string Note { get; set; }
        public string CancelReason { get; set; }
        public Guid StatusId { get; set; }
        public Guid PaymentId { get; set; }
        public bool IsDelete { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid Updatedy { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
