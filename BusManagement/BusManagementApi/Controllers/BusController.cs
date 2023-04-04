using BusManagement.Data.Entities;
using BusManagementApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        public Repository Repository { get; set; }
        public BusController() {
             this.Repository = new Repository();
        }
        [HttpGet("GetAllBusses")]
        public List<TblBu> GetAllBus()
        {
            return Repository.GetAllBus();
        }

        [HttpGet("GetBus")]
        public TblBu GetBus(string destination)
        {
            return Repository.GetBus(destination);
        }
        [HttpPost("AddBus")]
        public void AddBus(TblBu tblBu)
        {
            TblBu tblBu1= new TblBu();
            tblBu1.BusNumber = tblBu.BusNumber;
            tblBu1.BusSourceCity = tblBu.BusSourceCity;
            tblBu1.BusDestinationCity= tblBu.BusDestinationCity;
            tblBu1.BusCapacity = tblBu.BusCapacity;
            tblBu1.BusType = tblBu.BusType;
            tblBu1.BusArrival = tblBu.BusArrival;
            tblBu1.BusDeparture = tblBu.BusDeparture;
            Repository.AddBus(tblBu1);
        }

        [HttpPut("UpdateBus")]
        public void UpdateBus(TblBu tblBu)
        {
            TblBu tblBu1 = new TblBu();
            tblBu1.BusNumber = tblBu.BusNumber;
            tblBu1.BusSourceCity = tblBu.BusSourceCity;
            tblBu1.BusDestinationCity = tblBu.BusDestinationCity;
            tblBu1.BusCapacity = tblBu.BusCapacity;
            tblBu1.BusType = tblBu.BusType;
            tblBu1.BusArrival = tblBu.BusArrival;
            tblBu1.BusDeparture = tblBu.BusDeparture;
            Repository.UpdateBus(tblBu1);
        }

        [HttpDelete("DeleteBus")]
        public void DeleteBus(int BusNumber)
        {
            Repository.DeleteBus(BusNumber);
        }
    }
}
