using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Skyline.BitrateCalculation.API.Database;
using Skyline.BitrateCalculation.API.DTOs;
using Skyline.BitrateCalculation.API.Models;
using Skyline.BitrateCalculation.API.Services.IRepository;
using System.Net;

namespace Skyline.BitrateCalculation.API.Services.Repository
{
    public class VideoRepository : IVideoRepository
    {
        private readonly BirateCalculationDbContext _context;
        private readonly IMapper _mapper;

        public VideoRepository(BirateCalculationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public VideoDto AddVideo(string json)
        {
            var data = JsonConvert.DeserializeObject<Video>(json);

            int poolingRate = 2; // Hz
            foreach (var nic in data.NIC)
            {
                nic.Rx = nic.Rx * 8 / poolingRate;
                nic.Tx = nic.Tx * 8 / poolingRate;
            }

            _context.Videos.Add(data);
            _context.SaveChanges();

            var returnData = _mapper.Map<VideoDto>(data);

            return returnData;
        }

        public void DeleteVideo(int id)
        {
            var data = _context.Videos.FirstOrDefault(x => x.Id == id);

            _context.Videos.Remove(data);
            _context.SaveChanges();

        }

        public IEnumerable<VideoDto> GetAllVideos()
        {
            var data = _context.Videos.Include(x => x.NIC).ToList();

            var returnData = _mapper.Map<IEnumerable<VideoDto>>(data);
            return returnData;
        }

        public VideoDto GetVideo(int id)
        {
            var data = _context.Videos.Include(x => x.NIC).FirstOrDefault(x => x.Id == id);

            var returnData = _mapper.Map<VideoDto>(data);
            return returnData;
        }

        public VideoDto UpdateVideo(int id, VideoDto video)
        {
            Video data = _context.Videos.FirstOrDefault(x => x.Id == id);
            _mapper.Map(video, data);
            var returnData = _mapper.Map<VideoDto>(data);

            _context.Videos.Update(data);
            _context.SaveChanges();

            return returnData;
        }
    }
}
