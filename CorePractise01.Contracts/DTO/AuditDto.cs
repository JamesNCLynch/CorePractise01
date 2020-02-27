using System;
using System.Collections.Generic;
using System.Text;

namespace CorePractise01.Contracts.DTO
{
    public class AuditDto
    {
        public DateTime CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
