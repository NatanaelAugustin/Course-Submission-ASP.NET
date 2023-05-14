using ASP.NET_App.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_App.Models.ViewModels;

public class ContactUsViewModel
{
	[Display(Name = "First Name")]
	[Required(ErrorMessage = "You must provide a first name")]
	public string FirstName { get; set; } = null!;

	[Display(Name = "Last Name")]
	[Required(ErrorMessage = "You must provide a last name")]
	public string LastName { get; set; } = null!;

	[Display(Name = "Email")]
	[Required(ErrorMessage = "You must provide an email")]
	public string Email { get; set; } = null!;
	public string? PhoneNumber { get; set; }

	[Display(Name = "Message")]
	[Required(ErrorMessage = "You must provide a message")]
	public string Message { get; set; } = null!;


	public static implicit operator ContactUsEntity(ContactUsViewModel viewModel)
	{
		return new ContactUsEntity
		{
			FirstName = viewModel.FirstName,
			LastName = viewModel.LastName,
			Email = viewModel.Email,
			PhoneNumber = viewModel.PhoneNumber,
			Message = viewModel.Message
		};
	}
}
