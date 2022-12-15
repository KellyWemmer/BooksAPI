using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksAPI_Server.Models
{
    public class ToReadAuthor
    {
        [Key]
        public int Id { get; set; }
        public int ToReadId { get; set; }
        public int AuthorId { get; set; }

        [ForeignKey("ToReadId")]
        public ToRead ToRead { get; set; }
        
        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
    }
}
