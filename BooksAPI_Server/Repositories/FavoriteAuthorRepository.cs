using BooksAPI_Server.Data;
using BooksAPI_Server.Models;

namespace BooksAPI_Server.Repositories
{
    public class FavoriteAuthorRepository
    {
        private readonly ApplicationDbContext _context;

        public FavoriteAuthorRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        internal FavoriteAuthor CreateFavoriteAuthor(FavoriteAuthor newFavoriteAuthor) 
        {
            _context.FavoriteAuthors.Add(newFavoriteAuthor);
            _context.SaveChanges();
            return newFavoriteAuthor;   
        
        }
    }

}
