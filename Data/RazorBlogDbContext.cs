using Microsoft.EntityFrameworkCore;
using RazorBlog.Models.Domain;

namespace RazorBlog.Data
{
    public class RazorBlogDbContext : DbContext
    {
        public RazorBlogDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
