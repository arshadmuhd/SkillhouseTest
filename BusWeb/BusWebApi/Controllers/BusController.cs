
using BusWebApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        public BusRepository BusRepository { get;set; }

    public BusController() 
        {
            this.BusRepository = new BusRepository();
        }

        [HttpGet("GetAllBusses")]
        public List<BusInfo> GetAllBuses()
        {
            return this.BusRepository.GetAllBusesInfo();
        }

        [HttpGet("GetBuss")]
        public BusInfo GetBuss(string destination)
        {
            return this.BusRepository.GetBus(destination);
        }


        [HttpDelete("Staff/DeleteBus")]
        public void DeleteBuss(int BusNumber)
        {
            this.BusRepository.DeleteBus(BusNumber);
        }


        [HttpPost("Staff/AddBus")]
        public void AddBuss(BusInfo busInfo)
        {
            this.BusRepository.AddBus(busInfo);
        }

       /* [HttpPut("Staff/UpdateBus")]
        public void UpdateBuss()
        {
            this.BusRepository.UpdateBus();
        }*/
    }
}
