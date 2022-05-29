namespace SupportLibrary.Models
{
    public interface IBoxStateModel
    {
        string BoxId { get; set; }

        bool Led1State { get; set; }
        bool Led2State { get; set; }
        bool Led3State { get; set; }
        bool Led4State { get; set; }
        bool DoorState { get; set; }

    }
}