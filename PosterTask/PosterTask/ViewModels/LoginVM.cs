using System.ComponentModel.DataAnnotations;

namespace PosterTask.ViewModels
{
    public class LoginVM
    {
		[Required]
		[EmailAddress]
		[Display(Name = "Email Address")]
		public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
