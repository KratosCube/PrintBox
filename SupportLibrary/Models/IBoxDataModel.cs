
namespace SupportLibrary.Models
{
    public interface IBoxDataModel
    {
         string NameOfBox { get; set; }
         float Humidity { get; set; }
         float Tamperature { get; set; }
         string Door { get; set; }
         int LedIntensity { get; set; }
         float FanSpeed { get; set; }
         int Id { get; set; }
         DateTime Time_recieved { get; set; }
    }
}