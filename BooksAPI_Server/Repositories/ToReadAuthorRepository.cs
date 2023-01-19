using BooksAPI_Server.Data;
using BooksAPI_Server.Models;

namespace BooksAPI_Server.Repositories
{
    public class ToReadAuthorRepository
    {
        private readonly ApplicationDbContext _context;

        public ToReadAuthorRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        internal ToReadAuthor CreateToReadAuthor(ToReadAuthor newToReadAuthor) 
        {
            _context.ToReadAuthors.Add(newToReadAuthor);
            _context.SaveChanges();
            return newToReadAuthor;
        }
    }
}
