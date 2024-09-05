using System.ComponentModel.DataAnnotations;

namespace PosterTask.ViewModels
{
    public class UserVM
    {

        [Required(ErrorMessage ="Name field is required")]
        [MinLength(3, ErrorMessage ="Name must be '3' or more")]
        [MaxLength(50, ErrorMessage ="Name must be less than '50'")]
        public string Name { get; set; }


        [Required(ErrorMessage ="Age field is required")]
        [Range(18,45)]
        public int Age { get; set; }


        [Required(ErrorMessage ="Email field is required")]
        [EmailAddress]
        [Display(Name = "Email Address")]
        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", ErrorMessage = "Enter email in correct way 'example@test.com'")]
        public string Email { get; set; }


        [Required(ErrorMessage ="Password field is required")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{8,}$", ErrorMessage = "Minimum eight characters, at least one letter and one number")]
        public string Password { get; set; }


        [Required(ErrorMessage ="Repeat Password field is required")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name= "Repeat Password")]
        public string ConfirmPassword { get; set; }
    }
}
