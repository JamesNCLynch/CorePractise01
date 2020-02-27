using System;
using System.Collections.Generic;
using System.Text;

namespace CorePractise01.Contracts.DTO
{
    public class FeedDto : AuditDto
    {
        public Guid Id { get; set; }
        public int TotalSizeInMl { get; set; }
        public int TotalConsumedInMl { get; set; }
        public DateTime TimeOfFeed { get; set; }
        public string UserId { get; set; }
    }
}
