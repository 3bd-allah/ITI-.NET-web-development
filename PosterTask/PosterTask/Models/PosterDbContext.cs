using Microsoft.EntityFrameworkCore;

namespace PosterTask.Models
{
    public class PosterDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Post> Posts{ get; set; }
        public virtual DbSet<Role> Roles{ get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                ("Data Source=.; Initial Catalog=PosterDb; Integrated Security=True ;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
