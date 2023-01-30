using BooksAPI_Server.Data;
using BooksAPI_Server.Models;

namespace BooksAPI_Server.Repositories
{
    public class FinishedAuthorRepository
    {
        private readonly ApplicationDbContext _context;

        public FinishedAuthorRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        internal FinishedAuthor CreateFinishedAuthor(FinishedAuthor newFinishedAuthor) 
        {
            _context.FinishedAuthors.Add(newFinishedAuthor);
            _context.SaveChanges();
            return newFinishedAuthor;
        }
    }
}
