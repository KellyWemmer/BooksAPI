using BooksAPI_Server.Data;
using BooksAPI_Server.Models;
using Microsoft.EntityFrameworkCore;

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

        internal List<Favorite> GetFictionFavorites()
        {
            return _context.Favorites.Include("FavoriteAuthors").Include("FavoriteAuthors.Author").ToList();
        }
    }
}
