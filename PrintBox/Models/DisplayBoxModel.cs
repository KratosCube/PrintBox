
using SupportLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace PrintBox.Models
{
    public class DisplayBoxModel : IBoxModel
    {
        public int BoxId { get; set; }
        [Required]
        public string NameOfBox { get; set; }
        [Required]
        public string Organization { get; set; }
        [Required]
        public string GroupName { get; set; }
        public int FanId { get; set; }
        public string FanFW { get; set; }
        public int TempHumId { get; set; }
        public string TempHumFW { get; set; }
        public int LedId { get; set; }
        public string LedFW { get; set; }
        public DateTime CurrentTime { get; set; }

    }
}
