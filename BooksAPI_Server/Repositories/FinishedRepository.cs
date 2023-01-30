using BooksAPI_Server.Data;
using BooksAPI_Server.Models;

namespace BooksAPI_Server.Repositories
{
    public class FinishedRepository
    {
        private readonly ApplicationDbContext _context;

        public FinishedRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        internal Finished CreateFinished(Finished newFinished)
        {
            _context.Finished.Add(newFinished);
            _context.SaveChanges();
            return newFinished;
        }
    }
}
