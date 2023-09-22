using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.DAL.Entities
{
    public class Status
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }
        public bool Display { get; set; }// chưa rõ
        public bool IsDeleted { get; set; }
        public Guid UpdatedAt { get; set; }
        public Guid PudatedBy { get; set; }
        public Guid CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
