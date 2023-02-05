using Skyline.BitrateCalculation.API.Models;

namespace Skyline.BitrateCalculation.API.DTOs
{
    public class VideoDto
    {
        public string Device { get; set; }
        public string Model { get; set; }
        public List<NICDto> NIC { get; set; }
    }
}
