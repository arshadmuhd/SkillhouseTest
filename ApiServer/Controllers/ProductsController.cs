using Ap1.Data;
using Ap1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace Ap1.Controllers
{
    /*[Route("api/[Product]")]or*/

    [Route("api/[controller]")] //here api/controller means class name that api/Products
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly ShopContext DbContext;




        //constructor injecting Db context
        public ProductsController(ShopContext DbContext)
        {
            this.DbContext = DbContext;
        }

       

        [HttpGet]
        public IActionResult GetProducts() 
        {
            return Ok(DbContext.products.ToList());
        }

        






























        /* private readonly ShopContext _Context;

         public ProductsController(ShopContext context)
         {
             _Context = context;
             _Context.Database.EnsureCreated();//checking that data seeded or not
         }

         [HttpGet]

         *//*public IEnumerable<Product> GetAllProduct()
         {
             //return ok
             return _Context.Products.ToArray();


         }*//*



         //asynchronous async await mwthod
         public async Task<ActionResult> GetAllProduct()
         {
             //return ok
            *//* return Ok(_Context.Products.ToArray());*//*
            var product=await _Context.Products.ToArrayAsync();
             return Ok(product);

         }

         //finding by id
         [HttpGet("{id}")]
         //or [Http][Route("{id}")]

         //asynchronous async await mwthod
         public async Task<ActionResult> GetAllProduct(int id)
         {
             var product = await _Context.Products.FindAsync(id);//FindAsync(id)
             //Error Handling
             if(product == null)
             {
                 return NotFound();
             }
             return Ok(product);


         }


         //Post Method or Adding items

         [HttpPost]
         public async Task<ActionResult> PostProduct(Product product)
         {
             //Model state is checking data valid or not
 *//*            if (!ModelState.IsValid)
             {
                 return BadRequest();
             }*//*



             _Context.Products.Add(product);
             await _Context.SaveChangesAsync();

             return CreatedAtAction("GetProduct", new { id = product.Id }, product);

         }




         [HttpPut("{id}")]
         public async Task<ActionResult> PutProduct(int id, Product product)
         {
             if(id!=product.Id)
             {
                 return BadRequest();
             }
             _Context.Entry(product).State = EntityState.Modified;
             try
             {
                 await _Context.SaveChangesAsync();
             }
             catch(DbUpdateConcurrencyException)//checking product id or prduct details is exist or not
             {
                 if (!_Context.Products.Any(p => p.Id == id))
                 {
                     return NotFound();
 ;               }
                 else
                 {
                     throw;
                 }

             }
             return NoContent();
         }


         [HttpDelete("{id}")]
         public async Task<ActionResult<Product>>DeleteProduct(int id)
         {
             var product = await _Context.Products.FindAsync(id);
             if (product == null)
             { 
                 return NotFound(); 
             }


             _Context.Remove(product);
             await _Context.SaveChangesAsync();

             //if herer showing error add after actionresult <product>
             return product;
         }


         //deleting several items
         //post bcoz here using more ids
         [HttpPost]
         [Route("Delete")]

         public async Task<ActionResult<Product>> DeleteManyProduct([FromQuery] int[]ids)
         {
             var Tempproducts=new List<Product>();
             foreach(var id in ids)
             {
                 var product = await _Context.Products.FindAsync(id);
                 if (product == null)
                 {
                     return NotFound();
                 }
                 Tempproducts.Add(product);

             }


             _Context.Products.RemoveRange(Tempproducts);
             await _Context.SaveChangesAsync();

             //if herer showing error add after actionresult <product>
             return Ok(Tempproducts);
         }*/





    }
}
