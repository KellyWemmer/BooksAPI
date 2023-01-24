using BooksAPI_Server.Data;
using BooksAPI_Server.Models;

namespace BooksAPI_Server.Repositories
{
    public class FavoritesRepository
    {
        private readonly ApplicationDbContext _context;
        public FavoritesRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        internal Favorite CreateFavorite(Favorite newFavorite)
        {
            _context.Favorites.Add(newFavorite);   
            _context.SaveChanges();
            return newFavorite;
        }
    }
}
