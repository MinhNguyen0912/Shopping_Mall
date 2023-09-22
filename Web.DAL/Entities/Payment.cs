using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.DAL.Entities
{
    public class Payment
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
        public Guid TransactionId { get; set; }
        public string PaymentMethod { get; set; }// chưa rõ
        public string PaymentCode { get; set; }
        public DateTime TransactionDate { get; set; }
        public Decimal Fee { get; set; }    
        public Guid SatusId { get; set; }
        public bool isDeleted { get; set; }
        public Guid UpdatedAt { get; set; }
        public Guid PudatedBy { get; set; }
        public Guid CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
