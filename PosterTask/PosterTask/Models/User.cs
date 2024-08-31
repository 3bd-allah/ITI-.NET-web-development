using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace PosterTask.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string  Name { get; set; }
        public int  Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
