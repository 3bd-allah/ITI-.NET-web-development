using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace PosterTask.Models
{
    [PrimaryKey("RoleId", "UserId")]
    public class UserRole
    {
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }

        // Navagation Properties
        public User User { get; set; }
        public Role Role { get; set; }
    }
}
