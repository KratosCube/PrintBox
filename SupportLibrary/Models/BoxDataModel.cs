using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary.Models
{
    public class BoxDataModel : IBoxDataModel
    {

        public string NameOfBox { get; set; }
        public decimal Humidity { get; set; }
        public decimal Temperature { get; set; }
        public string Door { get; set; }
        public int LedIntensity { get; set; }
        public decimal FanSpeed { get; set; }
        public int Id { get; set; }
        public DateTime Time_recieved { get; set; }

    }
}
