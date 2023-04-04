using DugStoreApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DugStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {

        public static List<Supplier> supplierList = new List<Supplier>()
        {
            new Supplier
            {
                SupplierId = 2000,
                Name = "Kalanad Supplier",
                Company = " Ajsx",
                Address = "Mangalore"
            },
            new Supplier
            {
                SupplierId= 2001,
                Name="aanand Supplier",
                Company=" qwerty",
                Address="bangalore"
            }
        };

        [HttpGet("GetAllsupplier")]
        public List<Supplier> GetAllAupplier()
        {
            return supplierList;
        }

        [HttpPost("AddSupplier")]
        public void AddSupplier(Supplier supplier)
        {
            supplierList.Add(supplier);
        }

        [HttpDelete("DeleteSupplier/{SupplierId}")]
        public void DeleteSupplier(int SupplierId)
        {
            var supplier=supplierList.Where(d=>d.SupplierId==SupplierId).FirstOrDefault();
            supplierList.Remove(supplier);
        }

        [HttpGet("GetSupplier/{SupplierId}")]
        public Supplier GetSupplier(int SupplierId)
        {
            var SupplierDetails=supplierList.Where(d=>d.SupplierId== SupplierId).FirstOrDefault();
            return SupplierDetails;
        }

    }
}
