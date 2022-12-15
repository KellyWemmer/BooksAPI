using Microsoft.EntityFrameworkCore;
using BooksAPI_Server.Models;

namespace BooksAPI_Server.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public DbSet<Favorite> Favorite { get; set; }
        public DbSet<ToRead> ToRead { get; set; }
        public DbSet<Finished> Finished { get; set; }    

        public DbSet<Author> Author { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }
    }
}
