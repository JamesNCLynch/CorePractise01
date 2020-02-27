using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CorePractise01.Contracts.DTO;
using CorePractise01.Contracts.ViewModels;

namespace CorePractise01.Webapp.Mappings
{
    public class ViewToDomain : Profile
    {
        public ViewToDomain()
        {
            CreateMap<CreateFeedViewModel, FeedDto>();
                //.ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()));
            CreateMap<EditFeedViewModel, FeedDto>();
        }
    }
}
