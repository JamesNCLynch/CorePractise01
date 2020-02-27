using System;
using System.Collections.Generic;
using System.Text;
using CorePractise01.Contracts.Queries;
using CorePractise01.Contracts.Commands;
using CorePractise01.Contracts.ViewModels;
using CorePractise01.Contracts.DTO;

namespace CorePractise01.Contracts.Services
{
    public interface IFeedService
    {
        IList<FeedDto> GetFeedsWithinDateRange(DateTime startDate, DateTime endDate);
        void AddNewFeed(FeedDto newFeedDto);
    }
}
