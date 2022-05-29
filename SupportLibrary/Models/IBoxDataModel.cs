
namespace SupportLibrary.Models
{
    public interface IBoxDataModel
    {
        string NameOfBox { get; set; }
        float Tamperature { get; set; }
        string Door { get; set; }
        string Led { get; set; }

        float Fan { get; set; }
        int Id { get; set; }
        DateTime Time_recieved { get; set; }
    }
}