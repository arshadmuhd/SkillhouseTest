using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Ap1.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Sku { get; set; }
       
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool isAvailable { get; set; }
       /* [Required]
        public int CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category? Category { get; set; }//? making nullable for post request*/

    }
}
