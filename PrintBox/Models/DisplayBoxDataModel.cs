using SupportLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace PrintBox.Models
{
    public class DisplayBoxDataModel : IBoxDataModel
    {
        [Required]
        public string NameOfBox { get; set; }
        [Required]
        public float Humidity { get; set; }
        [Required]
        public float Tamperature { get; set; }
        [Required]
        public string Door { get; set; }
        [Required]
        public int LedIntensity { get; set; }
        [Required]
        public float FanSpeed { get; set; }
        public int Id { get; set; }
        public DateTime Time_recieved { get; set; }
    }
}
