using CorePractise01.Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CorePractise01.Contracts.Commands
{
    public interface IFeedWriter
    {
        void AddFeed(FeedDto newFeedDto);
    }
}
