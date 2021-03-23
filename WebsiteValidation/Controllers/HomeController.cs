using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebsiteValidation.Models;

namespace WebsiteValidation.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index(RegistrationModel registration)
		{
			return View();
		}
	}
}
