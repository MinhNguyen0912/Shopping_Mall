using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.DAL.Enums;

namespace Web.DAL.Entities
{
    public class Payment
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public Guid TransactionId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string PaymentCode { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Fee { get; set; }    
        public Guid SatusId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid Updatedy { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
