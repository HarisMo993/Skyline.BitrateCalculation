using Skyline.BitrateCalculation.API.DTOs;
using Skyline.BitrateCalculation.API.Models;

namespace Skyline.BitrateCalculation.API.Services.IRepository
{
    public interface IVideoRepository
    {
        IEnumerable<VideoDto> GetAllVideos();
        VideoDto GetVideo(int id);
        VideoDto AddVideo(string json);
        VideoDto UpdateVideo(int id, string json);
        void DeleteVideo(int id);
    }
}
