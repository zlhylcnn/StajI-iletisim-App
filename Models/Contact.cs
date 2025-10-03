using System.ComponentModel.DataAnnotations;

namespace StajIletisimApp.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }  = string.Empty;

        [Required]
        [Phone]
        public string Phone { get; set; }  = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; }  = string.Empty;

        [Required]
        public string Department { get; set; }  = string.Empty;

        public string Message { get; set; }  = string.Empty;
    }
}
