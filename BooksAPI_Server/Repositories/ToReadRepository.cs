using BooksAPI_Server.Data;
using BooksAPI_Server.Models;

namespace BooksAPI_Server.Repositories
{
    public class ToReadRepository
    {
        private readonly ApplicationDbContext _context;

        public ToReadRepository(ApplicationDbContext context) 
        {
            this._context = context;
        }

       
    }
}
