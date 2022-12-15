using System.ComponentModel.DataAnnotations;

namespace BooksAPI_Server.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        public string AuthorName { get; set; }
    }
}
