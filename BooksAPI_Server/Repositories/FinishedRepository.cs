using BooksAPI_Server.Data;
using BooksAPI_Server.Models;
using Microsoft.EntityFrameworkCore;

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

        internal List<Finished> GetFictionFinished()
        {
            return _context.Finished.Include("FinishedAuthors").Include("FinishedAuthors.Author").ToList();
        }

        internal Finished GetFinishedById(int id)
        {
            Finished finished = _context.Finished.FirstOrDefault(f => f.Id == id);
            return finished;
        }

        internal void DeleteFinished(int id)
        {
            Finished finished = GetFinishedById(id);
            if (finished != null)
            {
                _context.Finished.Remove(finished);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Book not found");
            }
        }
    }
}
