using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary.Models
{
    public class BoxModel : IBoxModel
    {
        public int BoxId { get; set; }
        public string NameOfBox { get; set; }
        public string Organization { get; set; }
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
