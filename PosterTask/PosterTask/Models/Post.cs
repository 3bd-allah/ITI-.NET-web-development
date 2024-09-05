using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosterTask.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category{ get; set; }
        public string Body{ get; set; }
        public int Likes{ get; set; }
        public int Share{ get; set; }

        [ForeignKey("User")]
        [Display(Name ="User Name")]
        public int UserId { get; set; }

        // Navagation Property 
        public User User { get; set; }

    }
}
