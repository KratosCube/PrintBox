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
        public float Humidity { get; set; }
        public float Tamperature { get; set; }
        public string Door { get; set; }
        public int LedIntensity { get; set; }
        public float FanSpeed { get; set; }
        public int Id { get; set; }
        public DateTime Time_recieved { get; set; }

    }
}
