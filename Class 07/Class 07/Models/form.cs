using System.ComponentModel.DataAnnotations;

namespace Class_07.Models
{
	public class form
	{
		[Key]
		public int id { get; set; }

		[Required(ErrorMessage = "Please enter name")]
		[StringLength(100)]
		public string Name { get; set; }

		[Required(ErrorMessage = "Please choose gender")]
		public string Gender { get; set; }

		[Required(ErrorMessage = "Please enter date of birth")]
		[Display(Name = "Date of Birth")]
		[DataType(DataType.Date)]
		public DateTime DateofBirth { get; set; }

		[Required(ErrorMessage = "Choose Batch Time")]
		[Display(Name = "Batch Time")]
		[DataType(DataType.Time)]
		public DateTime BatchTime { get; set;}

		[Required(ErrorMessage = "Please Enter Phone Number")]
		[Display(Name = "Phone Number")]
		[Phone]
		public string PhoneNumber { get; set; }

		[Required(ErrorMessage = "Please Enter Email Address")]
		[Display(Name = "Email Address")]
		[EmailAddress]
		public string Email { get; set; }

		[Required(ErrorMessage = "Please Enter Website URL")]
		[Display(Name = "Website URL")]
		[Url]
		public string Website { get; set; }

		[Required(ErrorMessage = "Please Enter Password")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required(ErrorMessage = "Confirm Password")]
		[Display(Name = "Confirm Password")]
		[Compare("Password", ErrorMessage = "Password does not match")]
		public string ConfirmPassword { get; set;}

	}
}
