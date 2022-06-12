using SupportLibrary.DataAccess;
using SupportLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary.Data
{
    public class BoxSqlDataService : IBoxDataService
    {
        private readonly ISqlDataAccess _dataAccess;

        public BoxSqlDataService(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task CreateBox(IBoxModel box)
        {
            var b = new
            {
                box.NameOfBox,
                box.Organization,
                box.GroupName
            };
            await _dataAccess.SaveData("dbo.spBox_Create", b, "SQLDB");
        }

        public async Task CreateData(IBoxDataModel boxdata)
        {
            var b = new
            {
                boxdata.NameOfBox,
                boxdata.Door,
                boxdata.LedIntensity,
                boxdata.Temperature
            };
            await _dataAccess.SaveData("dbo.spBox_CreateData", b, "SQLDB");
        }

        public async Task<List<IBoxModel>> ReadBox()
        {
            var box = await _dataAccess.LoadData<BoxModel, dynamic>("dbo.spBox_Read",
                                                                    new { },
                                                                    "SQLDB");
            return box.ToList<IBoxModel>();
        }

        public async Task<List<IBoxDataModel>> ReadBoxData()
        {
            var box = await _dataAccess.LoadData<BoxDataModel, dynamic>("dbo.spBox_ReadData",
                                                                    new { },
                                                                    "SQLDB");
            return box.ToList<IBoxDataModel>();
        }

        public async Task<IBoxStateModel> ReadState(string boxid)
        {
            var box = await _dataAccess.LoadData<BoxStateModel, dynamic>("dbo.spBox_ReadStates",
                                                                    new { BoxId = boxid },
                                                                    "SQLDB");
            return box.FirstOrDefault();
        }

        public async Task<IBoxModel> ReadBoxByName(string NameOfBox)
        {
            var box = await _dataAccess.LoadData<BoxModel, dynamic>("dbo.spBox_ReadDataByName",
                                                                    new { NameOfBox = NameOfBox },
                                                                    "SQLDB");
            return box.FirstOrDefault();
        }

        public async Task UpdateState(IBoxStateModel box)
        {
            await _dataAccess.SaveData("dbo.spBox_UpdateStates", box, "SQLDB");
        }



        public async Task UpdateStateText(IBoxStateModel box, string BoxId, Boolean led1, Boolean led2, Boolean led3, Boolean led4, Boolean led5, Boolean led6, Boolean led7)
        {
            string sql = "update dbo.DataStateTB set Led1State = @Led1State, Led2State = @Led2State, Led3State = @Led3State, Led4State = @Led4State, Led5State = @Led5State, Led6State = @Led6State, Led7State = @Led7State, DoorState = @DoorState where BoxId = @BoxId"; //"update dbo.DataStateTB set Led1State = " + led1 + ", Led2State = " + led2 + ", Led3State = " + led3 + ", Led4State = " + led4 + ", Led5State = " + led5 + ", Led6State = " + led6 + ", Led7State = " + led7 + " where " + BoxId;

            await _dataAccess.SaveDataText(sql, box, "SQLDB");
        }

        public async Task<List<IBoxDataModel>> ReadLastXData(int rowscount)
        {
            var box = await _dataAccess.LoadData<BoxDataModel, dynamic>("dbo.spBox_ReadLastXData",
                                                                    new { countoflastrecords = rowscount },
                                                                    "SQLDB");
            return box.ToList<IBoxDataModel>();
        }

    }
}
