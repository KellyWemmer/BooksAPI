using Microsoft.EntityFrameworkCore;
using BooksAPI_Server.Models;

namespace BooksAPI_Server.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<FavoriteAuthor> FavoritesAuthors { get; set; }
        public DbSet<ToRead> ToReads { get; set; }
        public DbSet<ToReadAuthor> ToReadsAuthors { get; set; }
        public DbSet<Finished> Finished { get; set; }   
        public DbSet<FinishedAuthor> FinishedAuthors { get; set; }

        public DbSet<Author> Authors { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
        }
     }
}
