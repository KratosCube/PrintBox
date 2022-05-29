
namespace SupportLibrary.Models
{
    public interface IBoxModel
    {
        int BoxId { get; set; }
        string NameOfBox { get; set; }
        string Organization { get; set; }
        string GroupName { get; set; }
        DateTime CurrentTime { get; set; }

    }
}