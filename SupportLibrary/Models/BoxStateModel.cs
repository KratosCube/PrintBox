using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary.Models
{
    public class BoxStateModel : IBoxStateModel
    {
        public string BoxId { get; set; }
        public Boolean Led1State { get; set; }
        public Boolean Led2State { get; set; }
        public Boolean Led3State { get; set; }
        public Boolean Led4State { get; set; }
        public Boolean DoorState { get; set; }

    }
}
