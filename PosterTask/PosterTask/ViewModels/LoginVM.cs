using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace PosterTask.ViewModels
{
    public class LoginVM
    {
		[Required]
		[EmailAddress()]
		[Display(Name = "Email Address")]
		public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
