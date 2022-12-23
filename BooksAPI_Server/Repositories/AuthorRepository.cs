using BooksAPI_Server.Data;
using BooksAPI_Server.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksAPI_Server.Repositories
{
    public class AuthorRepository
    {
        private readonly ApplicationDbContext _context;

        public AuthorRepository(ApplicationDbContext context) 
        {
            this._context = context;
        }
        internal Author GetAuthorByName(string authorName)
        {
            Author findAuthor = _context.Authors.FirstOrDefault(a => a.AuthorName == authorName);
            return findAuthor;
        }

        internal Author CreateAuthor(Author newAuthor) 
        {
            _context.Authors.Add(newAuthor);
            _context.SaveChanges();
            return newAuthor;
        }
    }
}
