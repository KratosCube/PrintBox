using SupportLibrary.Models;

namespace SupportLibrary.Data
{
    public interface IBoxDataService
    {
        Task CreateBox(IBoxModel box);
        Task CreateData(IBoxDataModel boxdata);
        Task<List<IBoxModel>> ReadBox();
        Task<List<IBoxDataModel>> ReadBoxData();
        Task<List<IBoxDataModel>> ReadLastXData(int rowscount);
        Task<IBoxStateModel> ReadState(string boxid);
        Task UpdateState(IBoxStateModel box);
        Task UpdateStateText(IBoxStateModel box, string BoxId, bool led1, bool led2, bool led3, bool led4, bool led5, bool led6, bool led7);
    }
}