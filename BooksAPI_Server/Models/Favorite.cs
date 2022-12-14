using System.ComponentModel.DataAnnotations;

namespace BooksAPI_Server.Models
{
    public class Favorite
    {
        [Key]
        public string Id { get; set; }
        public string key { get; set; }
        public string title { get; set; }

        public List<string> isbn { get; set; }

        public List<string> author_name { get; set; }
    }
}
