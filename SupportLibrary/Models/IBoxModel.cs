
namespace SupportLibrary.Models
{
    public interface IBoxModel
    {
        int BoxId { get; set; }
        string NameOfBox { get; set; }
        string Organization { get; set; }
        string GroupName { get; set; }
        int FanId { get; set; }
        string FanFW { get; set; }
        int TempHumId { get; set; }
        string TempHumFW { get; set; }
        int LedId { get; set; }
        string LedFW { get; set; }
        DateTime CurrentTime { get; set; }

    }
}