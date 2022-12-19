using BooksAPI_Server.Data;
using BooksAPI_Server.Models;
using Microsoft.Win32.SafeHandles;

namespace BooksAPI_Server.Repositories
{
    public class ToReadRepository
    {
        private readonly ApplicationDbContext _context;

        public ToReadRepository(ApplicationDbContext context) 
        {
            this._context = context;
        }

        internal List<ToRead> GetToReads() 
        {
            return _context.ToReads.ToList();
        }

        internal ToRead CreateToRead(ToRead newToRead) 
        {
            _context.ToReads.Add(newToRead);
            _context.SaveChanges();
            return newToRead;
        }

        internal ToRead GetToReadById(int id) 
        {
            ToRead toRead = _context.ToReads.FirstOrDefault(r => r.Id == id);
            return toRead;
        }

        internal void DeleteToRead(int id) 
        {
            ToRead toRead = GetToReadById(id);
            if(toRead != null)
            {
                _context.ToReads.Remove(toRead);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Book ToRead not found");
            }
        }
    }
}
