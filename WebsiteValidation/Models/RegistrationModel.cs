using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebsiteValidation.Models
{
	public class RegistrationModel
	{
		[Required(ErrorMessage = "Enter a name.")]
		[StringLength(30, ErrorMessage = "Name must be at least 30 characters")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Enter an address.")]
		public string Address { get; set; }

		[Required(ErrorMessage = "Enter a phone number.")]
		[StringLength(10, ErrorMessage = "Phone number cannot be more than 10 numbers.")]
		public string Phone { get; set; }

		[Required(ErrorMessage = "Enter an email address.")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Enter an age.")]
		public int Age { get; set; }
	}
}
