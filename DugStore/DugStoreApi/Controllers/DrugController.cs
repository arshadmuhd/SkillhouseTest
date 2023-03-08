using DugStoreApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DugStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrugController : ControllerBase
    {
        public static List<Drug> DrugList = new List<Drug>()
        {
            new Drug
            {
                Id = 1000,
                Name = "Dolo234",
                SerialNumber = "DoloSer12",
                ManufactureDate = new DateTime(2022, 10, 3),
                ExpiryDate = new DateTime(2025, 10, 3)

            },
            new Drug
            {
                Id = 1001,
                Name = "Dolo234",
                SerialNumber = "DoloSer12",
                ManufactureDate = new DateTime(2022, 10, 3),
                ExpiryDate = new DateTime(2025, 10, 3)

            },

        };


        [HttpGet("GetAllDrugs")]
        public List<Drug> GetAllDrug()
        {
            return DrugList;
        }

        [HttpPost("AddDrug")]
        public void AddDrug(Drug drug)
        {
            DrugList.Add(drug);
        }

        [HttpDelete("DeleteDrug")]

        public void DeletDrug(int id)
        {
            var DrugToBeDeleted = DrugList.Where(d => d.Id == id).FirstOrDefault();
            DrugList.Remove(DrugToBeDeleted);
        }

        [HttpGet("GetDrug")]
        public Drug GetDrug(int id)
        {
            var DrugRecord=DrugList.Where(d=>d.Id==id).FirstOrDefault();
            return DrugRecord;
        }



    }
}
