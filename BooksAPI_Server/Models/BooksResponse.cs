using Newtonsoft.Json;

namespace BooksAPI_Server.Models
{
    public class BooksResponse
    {
        public int numFound { get; set; }
        public int start { get; set; }
        public bool numFoundExact { get; set; }
        public List<Book> docs { get; set; }

        [JsonProperty("num_found")]
        public int nummFound { get; set; }
        public string q { get; set; }
        public string offset { get; set; }
    }
}
