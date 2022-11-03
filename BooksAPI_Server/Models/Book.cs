using Newtonsoft.Json;

namespace BooksAPI_Server.Models
{
    public class Book
    {
        public string? Id { get; set; }
        public string? title { get; set; }
        [JsonProperty("first_publish_year")]
        public int firstPublishYear { get; set; }
        public List<string>? isbn { get; set; }
        [JsonProperty("author_name")]
        public List<string> authorName { get; set; }
        [JsonProperty("cover_i")]
        public int coverI { get; set; }
        public List<string>? language { get; set; }
        public List<string>? subject { get; set; }
    }
}
