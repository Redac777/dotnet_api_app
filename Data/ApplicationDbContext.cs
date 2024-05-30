using BloggingApp.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BloggingApp.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        //Create BlogPosts database relation
        public DbSet<BlogPost> BlogPosts { get; set; }

        //Create Categories database relation
        public DbSet<Category> Categories { get; set; }
    }
}
