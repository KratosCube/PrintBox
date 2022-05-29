using SupportLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace PrintBox.Models
{
    public class DisplayBoxDataModel : IBoxDataModel
    {
        [Required]
        public string NameOfBox { get; set; }
        [Required]
        public float Tamperature { get; set; }
        [Required]
        public string Door { get; set; }
        [Required]
        public string Led { get; set; }
        [Required]
        public float Fan { get; set; }
        public int Id { get; set; }
        public DateTime Time_recieved { get; set; }
    }
}
