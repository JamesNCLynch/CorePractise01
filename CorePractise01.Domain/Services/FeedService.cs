using System;
using System.Collections.Generic;
using System.Text;
using CorePractise01.Contracts.Services;
using CorePractise01.Contracts.DTO;
using CorePractise01.Contracts.Commands;
using CorePractise01.Contracts.Queries;
using CorePractise01.Contracts.ViewModels;

namespace CorePractise01.Domain.Services
{
    public class FeedService : IFeedService
    {
        private readonly IFeedReader _feedReader;
        private readonly IFeedWriter _feedWriter;

        public FeedService(IFeedReader feedReader, IFeedWriter feedWriter)
        {
            _feedReader = feedReader;
            _feedWriter = feedWriter;
        }

        public void AddNewFeed(FeedDto newFeedDto)
        {
            _feedWriter.AddFeed(newFeedDto);
        }

        public IList<FeedDto> GetFeedsWithinDateRange(DateTime startDate, DateTime endDate)
        {
            var feedDtos = _feedReader.GetFeeds(startDate, endDate);

            return feedDtos;
        }
    }
}
