using BusApiWeb.Repositories;
using BusManagement.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusApiWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        public BusRepository BusRepository { get; set; }
        public BusController() {
            this.BusRepository= new BusRepository();
        }
       
        [HttpGet("GetAllBus")]
        public List<TblBu> GetAllBus()
        {
           return BusRepository.GetAllBus();
        }



       /* [HttpPost("AddBus")]
        public void AddBus(TblBu tblbus)
        {
            TblBu Tb=new TblBu();
            Tb.BusNumber = tblbus.BusNumber;
            Tb.Destination=tblbus.Destination;
            Tb.Capacity = tblbus.Capacity;
            Tb.Departure= tblbus.Departure;
            Tb.Arrival= tblbus.Arrival;
            Tb.SourceCity= tblbus.SourceCity;
            busInfoContext.TblBus.Add(Tb);
        }*/
    }
}
