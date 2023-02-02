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

        internal Favorite GetFavoriteById(int id) 
        {
            Favorite favorite = _context.Favorites.FirstOrDefault(f => f.Id == id);
            return favorite;
        }

        internal void DeleteFavorite(int id) 
        {
            Favorite favorite = GetFavoriteById(id);
            if (favorite != null)
            {
                _context.Favorites.Remove(favorite);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Book not found");
            }
        }
    }
}
