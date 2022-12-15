using System.ComponentModel.DataAnnotations;

namespace BooksAPI_Server.Models
{
    public class Favorite
    {
        [Key]
        public string Id { get; set; }
        public string Key { get; set; }
        public string Title { get; set; }

        public string TenDigitIsbn { get; set; }
        public string ThirteenDigitIsbn { get; set; }

        //Sets many to many relationship
        public ICollection<Author> Author { get; set; }
    }
}
