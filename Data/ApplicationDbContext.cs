using BloggingApp.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BloggingApp.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        //Create BlogPosts databse relation
        public DbSet<BlogPost> BlogPosts { get; set; }

        //Create Categories databse relation
        public DbSet<Category> Categories { get; set; }
    }
}
