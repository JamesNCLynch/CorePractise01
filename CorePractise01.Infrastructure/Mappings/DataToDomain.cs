﻿using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CorePractise01.Persistence.Entities;
using CorePractise01.Contracts.DTO;

namespace CorePractise01.Infrastructure.Mappings
{
    public class DataToDomain : Profile
    {
        public DataToDomain()
        {
            CreateMap<Feed, FeedDto>();
        }
    }
}
