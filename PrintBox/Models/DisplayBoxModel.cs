
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

        public DateTime CurrentTime { get; set; }

    }
}
