using Microsoft.EntityFrameworkCore;

namespace ABS3.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentReaction> Reactions { get; set; }

        public DbSet<CommentHistory> Histories { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

       
    }
}
