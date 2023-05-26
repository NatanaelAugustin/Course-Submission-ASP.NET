using ASP.NET_App.Models.Entities;
using ASP.NET_App.Models.Identities;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_App.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You must provide a first name")]
        public string FirstName { get; set; } = null!;

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You must provide a last name")]
        public string LastName { get; set; } = null!;

        [Display(Name = "Street Name")]
        [Required(ErrorMessage = "You must provide a street name")]
        public string StreetName { get; set; } = null!;

        [Display(Name = "Postal code")]
        [Required(ErrorMessage = "You must provide a postal code")]
        public string PostalCode { get; set; } = null!;

        [Display(Name = "City")]
        [Required(ErrorMessage = "You must provide a city")]
        public string City { get; set; } = null!;

        [Display(Name = "Mobile")]
        [Required(ErrorMessage = "You must provide a mobile number")]
        public string? Mobile { get; set; }

        [Display(Name = "Company")]
        public string? Company { get; set; }

        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "You must provide an e-mail address")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "You must provide a valid email address")]
        public string Email { get; set; } = null!;

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[!@#$%^&*()_+-=[\\]{};':\"\\|,.<>/?])(?=.*[^\\da-zA-Z]).{8,}$", ErrorMessage = "You must provide a valid password")]
        [Required(ErrorMessage = "You must provide a password")]
        public string Password { get; set; } = null!;

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Your must confirm the password")]
        public string ConfirmPassword { get; set; } = null!;


        [Display(Name = "I have read and accepts the terms and agreements")]
        [Required(ErrorMessage = "You must agree to the terms and conditions")]
        public bool TermsAndConditions { get; set; } = false;

        public static implicit operator AppUser(RegisterViewModel viewModel)
        {

            return new AppUser
            {
                UserName = viewModel.Email,
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                Email = viewModel.Email,
                PhoneNumber = viewModel.Mobile,
                CompanyName = viewModel.Company,
            };
        }
        public static implicit operator AddressEntity(RegisterViewModel viewModel)
        {
            return new AddressEntity
            {
                StreetName = viewModel.StreetName,
                PostalCode = viewModel.PostalCode,
                City = viewModel.City,
            };
        }

    }
}
