using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksAPI_Server.Models
{
    public class FinishedAuthor
    {
        [Key]
        public int Id { get; set; }
        public int FinishedId { get; set; }
        public int AuthorId { get; set; }

        [ForeignKey("FinishedId")]

        public Finished Finished { get; set; }

        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
    }
}
