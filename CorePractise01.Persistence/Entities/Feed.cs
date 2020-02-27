using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CorePractise01.Persistence.Entities
{
    public class Feed : AuditDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public int TotalSizeInMl { get; set; }
        public int TotalConsumedInMl { get; set; }
        public DateTime TimeOfFeed { get; set; }
        public IdentityUser AspNetUserId { get; set; }
    }
}
