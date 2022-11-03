namespace BooksAPI_Server.Models
{
    public class Book
    {
        public string? Id { get; set; }
        public string? title { get; set; }
        public int first_publish_year { get; set; }
        List<string>? isbn { get; set; }
        public string? author_name { get; set; }
        public int cover_i { get; set; }
        public string? language { get; set; }
        List<string>? subject { get; set; }
    }
}
