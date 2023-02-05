using AutoMapper;
using Skyline.BitrateCalculation.API.DTOs;
using Skyline.BitrateCalculation.API.Models;

namespace Skyline.BitrateCalculation.API.Profiles
{
    public class BirateCalculationProfile : Profile
    {
        public BirateCalculationProfile()
        {
            CreateMap<NIC, NICDto>().ReverseMap();
            CreateMap<Video, VideoDto>().ReverseMap();
        }
    }
}
