using ASP.NET_App.Models.Entities;

namespace ASP.NET_App.Models.ViewModels;

public class ContactUsViewModel
{
	public string FirstName { get; set; } = null!;
	public string LastName { get; set; } = null!;
	public string Email { get; set; } = null!;
	public string? PhoneNumber { get; set; }
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
