using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.DAL.Entities
{
    public class ApplicationUser:IdentityUser<Guid>
    {
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime LastLoginDate { get; set; }
        public string Picture { get; set; }
        public string Introduction { get; set; }
        public string ReasonBlocked { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime BlockedDate { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid UpdatedBy { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public string NickName { get; set; }
    }
}
