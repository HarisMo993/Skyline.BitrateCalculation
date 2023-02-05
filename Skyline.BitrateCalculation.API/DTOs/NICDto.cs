namespace Skyline.BitrateCalculation.API.DTOs
{
    public class NICDto
    {
        public string Description { get; set; }
        public string MAC { get; set; }
        public DateTime Timestamp { get; set; }
        public long Rx { get; set; }
        public long Tx { get; set; }
    }
}
