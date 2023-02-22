namespace ApiDataServer.Models
{
    public class AddProductRequest
    {
       
        public string Sku { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool isAvailable { get; set; }
    }
}
