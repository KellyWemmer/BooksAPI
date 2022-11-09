using Newtonsoft.Json;

namespace BooksAPI_Server.Models
{
    public class Book
    {
        public string Id { get; set; }
        public string title { get; set; }
        
        public int first_publish_year { get; set; }
        public List<string> isbn { get; set; }
     
        public List<string> author_name { get; set; }
        
        public int cover_i { get; set; }
        public List<string> language { get; set; }
        public List<string> subject { get; set; }
    }
}
