using AutoMapper;
using Jasmine_Akshil_GroupProject_COMP306.Dto;
using Jasmine_Akshil_GroupProject_COMP306.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jasmine_Akshil_GroupProject_COMP306.Profiles
{
    public class ReviewProfile:Profile
    {
        public ReviewProfile()
        {
            CreateMap<Review, ReviewReadDto>();
            CreateMap<ReviewCreateDto, Review>();
            CreateMap<ReviewUpdateDto, Review>();
        }

       
    }
}
