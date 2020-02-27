using CorePractise01.Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CorePractise01.Contracts.Queries
{
    public interface IFeedReader
    {
        IList<FeedDto> GetFeeds(DateTime startDate, DateTime endDate);
    }
}
