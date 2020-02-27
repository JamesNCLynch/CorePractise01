using System;
using System.Collections.Generic;
using System.Text;

namespace CorePractise01.Contracts.ViewModels
{
    public class BaseFeedViewModel
    {
        public int TotalSizeInMl { get; set; }
        public int TotalConsumedInMl { get; set; }
        public DateTime TimeOfFeed { get; set; }
    }
}