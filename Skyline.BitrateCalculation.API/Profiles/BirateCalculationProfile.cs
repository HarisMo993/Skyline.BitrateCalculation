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
            CreateMap<List<NIC>, NIC>()
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src[0].Description))
                .ForMember(dest => dest.MAC, opt => opt.MapFrom(src => src[0].MAC))
                .ForMember(dest => dest.Timestamp, opt => opt.MapFrom(src => src[0].Timestamp))
                .ForMember(dest => dest.Rx, opt => opt.MapFrom(src => src[0].Rx))
                .ForMember(dest => dest.Tx, opt => opt.MapFrom(src => src[0].Tx));
            CreateMap<Video, VideoDto>().ReverseMap();
            CreateMap<Video, VideoUpdateDto>().ReverseMap();
        }
    }
}
