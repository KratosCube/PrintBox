using SupportLibrary.Models;

namespace PrintBox.Models
{
    public class DisplayBoxStateModel : IBoxStateModel
    {
        public string BoxId { get; set; }
        public Boolean Led1State { get; set; }
        public Boolean Led2State { get; set; }
        public Boolean Led3State { get; set; }
        public Boolean Led4State { get; set; }
        public Boolean Led5State { get; set; }
        public Boolean Led6State { get; set; }
        public Boolean Led7State { get; set; }
        public Boolean DoorState { get; set; }
    }
}
