﻿using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_App.Controllers
{
	public class ContactsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}