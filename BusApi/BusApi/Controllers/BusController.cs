using BusApi.Repositories;
using BusManagement.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace BusApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        public BusRepsitory BusRepsitory { get; set; }
        public BusController() {
            this.BusRepsitory=new BusRepsitory();
        }

        [HttpGet("GetAllBusDetails")]
        public List<TblBusInfo> GetAllBus()
        {
            return BusRepsitory.GetBus();

        }

        [HttpGet("GetBusDetails")]
        public TblBusInfo GetBus(string destination)
        {
            return BusRepsitory.GetBus(destination);

        }

        [HttpPost("AddBusDetails")]
        public void AddBus(TblBusInfo tblBusInfo)
        {
            TblBusInfo tblBusInfo1=new TblBusInfo();
            tblBusInfo1.BusNumber= tblBusInfo.BusNumber;
            tblBusInfo1.SourceCity= tblBusInfo.SourceCity;
            tblBusInfo1.Departure= tblBusInfo.Departure;
            tblBusInfo1.Arrival= tblBusInfo.Arrival;
            tblBusInfo1.Destination= tblBusInfo.Destination;
            tblBusInfo1.Capacity= tblBusInfo.Capacity;
            tblBusInfo1.Type= tblBusInfo.Type;
            BusRepsitory.AddBus(tblBusInfo1);

        }
        [HttpDelete("DeleteBusDetails")]
        public void DeleteBus(int BusNumber)
        {
            BusRepsitory.DeleteBus(BusNumber);

        }


        [HttpPut("UpdateBusDetails")]
        public void UpdateBus(TblBusInfo tblBusInfo)
        {
            
            TblBusInfo tblBusInfo1 = new TblBusInfo();
            tblBusInfo1.BusNumber = tblBusInfo.BusNumber;
            tblBusInfo1.SourceCity = tblBusInfo.SourceCity;
            tblBusInfo1.Departure = tblBusInfo.Departure;
            tblBusInfo1.Arrival = tblBusInfo.Arrival;
            tblBusInfo1.Destination = tblBusInfo.Destination;
            tblBusInfo1.Capacity = tblBusInfo.Capacity;
            tblBusInfo1.Type = tblBusInfo.Type;
            BusRepsitory.UpdateBus(tblBusInfo1);

        }



    }
}
