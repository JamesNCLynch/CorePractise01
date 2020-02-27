using System;
using System.Collections.Generic;
using System.Text;
using CorePractise01.Contracts.DTO;
using CorePractise01.Contracts.Queries;
using System.Linq;
using AutoMapper;

namespace CorePractise01.Persistence.Queries
{
    public class FeedReader : IFeedReader
    {
        private readonly PractiseContext _context;
        private readonly IMapper _mapper;
        public FeedReader(PractiseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IList<FeedDto> GetFeeds(DateTime startDate, DateTime endDate)
        {
            var entities = _context.Feeds.Where(f => f.TimeOfFeed > startDate && f.TimeOfFeed >= endDate).ToList();

            var dtos = _mapper.Map<IList<FeedDto>>(entities);
            return dtos;
        }
    }
}
