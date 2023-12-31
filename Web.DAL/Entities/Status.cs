﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.DAL.Enums;

namespace Web.DAL.Entities
{
    public class Status
    {
        public Guid Id { get; set; }
        public StatusType Type { get; set; }
        public string Code { get; set; }
        public StatusDisplay Display { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
