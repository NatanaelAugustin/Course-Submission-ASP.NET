using System.ComponentModel.DataAnnotations;

namespace ASP.NET_App.Models.ViewModels
{
    public class ContactUsViewModel
    {
        [Required(ErrorMessage = "Please enter your first name")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string? Email { get; set; }

        [Phone(ErrorMessage = "Please enter a valid phone number")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter your message")]
        public string? Message { get; set; }
    }
}