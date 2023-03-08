using System.ComponentModel.DataAnnotations;

namespace registration.Models
{
    public class RegistrationModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Usn { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]

        public string Mobile { get; set; }
        [Required]
        public string CollageName { get; set; }
        public int Amount { get; set; }
        public string EventType { get; set; }
        public string EventName { get; set; }


    }
}
