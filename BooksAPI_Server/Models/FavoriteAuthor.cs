using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksAPI_Server.Models
{
    public class FavoriteAuthor
    {
        [Key]
        public int Id { get; set; }
        public int FavoriteId { get; set; }
        public int AuthorId { get; set; }

        [ForeignKey("FavoriteId")]
        public Favorite Favorite { get; set; }

        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
    }
}
