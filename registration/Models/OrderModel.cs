using System.ComponentModel.DataAnnotations;

namespace registration.Models
{
    public class OrderModel
    {
        [Key]
        public int Id { get; set; }
        public decimal OrderAmount { get; set; }
        public decimal OrderAmountInSubUnits
        {
            get
            {
                return OrderAmount * 100;
            }
        }
        public string Currency { get; set; }
        public int Payment_Capture { get; set; }
       /* public Dictionary<string, string> Notes { get; set; }*/
    }
}
