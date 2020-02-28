using System;
using System.Collections.Generic;
using System.Text;
using CorePractise01.Contracts.Commands;
using CorePractise01.Contracts.DTO;
using CorePractise01.Persistence.Entities;
using AutoMapper;
using NLog;
using System.Linq;

namespace CorePractise01.Persistence.Commands
{
    public class FeedWriter : BaseWriter, IFeedWriter
    {
        public FeedWriter(IMapper mapper, PractiseContext context) : base(mapper, context)
        {
        }

        public void AddFeed(FeedDto newFeedDto)
        {
            var newEntity = _mapper.Map<Feed>(newFeedDto);
            newEntity.User = _context.Users.FirstOrDefault(x => x.Id == newFeedDto.UserId);

            try
            {
                _context.Feeds.Add(newEntity);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.Error(e);
            }
        }
    }
}
