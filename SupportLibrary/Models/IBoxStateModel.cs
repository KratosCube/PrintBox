namespace SupportLibrary.Models
{
    public interface IBoxStateModel
    {
        string BoxId { get; set; }
        bool DoorState { get; set; }
        bool Led1State { get; set; }
        bool Led2State { get; set; }
        bool Led3State { get; set; }
        bool Led4State { get; set; }
        bool Led5State { get; set; }
        bool Led6State { get; set; }
        bool Led7State { get; set; }
    }
}