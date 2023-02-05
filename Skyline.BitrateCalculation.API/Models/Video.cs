using System.ComponentModel.DataAnnotations;

namespace Skyline.BitrateCalculation.API.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Device { get; set; }
        public string Model { get; set; }
        public int NICId { get; set; }
        public List<NIC> NIC { get; set; }
    }
}
