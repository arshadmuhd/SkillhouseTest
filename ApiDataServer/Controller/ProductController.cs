using ApiDataServer.Data;
using ApiDataServer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace ApiDataServer.Controller
{
    [Route("api/[controller]")] //here api/controller means class name that api/Products
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly ShopContext DbContext;




        //constructor injecting Db context
        public ProductController(ShopContext DbContext)
        {
            this.DbContext = DbContext;
        }



        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(DbContext.products.ToList());
        }



        [HttpPost]
        public async Task<IActionResult> PostProducts(AddProductRequest addProductRequest)/*("calling model   giving name)*/
        {
            var product = new Product()//creating object for modl Product.cs
            {
                Id = Guid.NewGuid(),
                Name = addProductRequest.Name,
                Sku = addProductRequest.Sku,
                Description = addProductRequest.Description,
                Price = addProductRequest.Price,
                isAvailable = addProductRequest.isAvailable
            };

            await DbContext.products.AddAsync(product);//this call dbcontext thar server and add to products
            await DbContext.SaveChangesAsync();

            return Ok(product);
        }


        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetProduct([FromRoute] Guid id)
        {
            var product = await DbContext.products.FindAsync(id);
            if(product != null)
            {
                return Ok(product);
            }
            return NotFound();
        }


        [HttpPut("{id:guid}")]

        public async Task<IActionResult> PutProduct([FromRoute] Guid id,UpdateProductRequest updateProductRequest)
        {
           var product= await DbContext.products.FindAsync(id);
            if (product != null)
            {
                product.Sku = updateProductRequest.Sku;
                product.Name = updateProductRequest.Name;
                product.Description = updateProductRequest.Description;
                product.Price = updateProductRequest.Price;
                product.isAvailable = updateProductRequest.isAvailable;

                await DbContext.SaveChangesAsync();
                return Ok(product);
            }
            return NotFound();
        }

        /*  [HttpDelete("{id:guid}")]
          public async Task<IActionResult> DeleteProduct([FromRoute] Guid id)
          {
              var product=DbContext.products.Find(id);
              if (product != null)
              {
                  DbContext.Remove(product);
                  await DbContext.SaveChangesAsync();

                  return Ok(product);

              }

              return NotFound();
          }*/

   





    }
}
