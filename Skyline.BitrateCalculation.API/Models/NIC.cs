using System.ComponentModel.DataAnnotations;

namespace Skyline.BitrateCalculation.API.Models
{
    public class NIC
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string MAC { get; set; }
        public DateTime Timestamp { get; set; }
        public long Rx { get; set; }
        public long Tx { get; set; }
    }
}
