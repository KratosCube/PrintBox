
namespace SupportLibrary.Models
{
    public interface IBoxDataModel
    {
         string NameOfBox { get; set; }
        decimal Humidity { get; set; }
        decimal Temperature { get; set; }
         string Door { get; set; }
         int LedIntensity { get; set; }
        decimal FanSpeed { get; set; }
         int Id { get; set; }
         DateTime Time_recieved { get; set; }
    }
}