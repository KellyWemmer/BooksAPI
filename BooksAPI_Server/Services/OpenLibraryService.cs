using BooksAPI_Server.Models;
using Newtonsoft.Json;

namespace BooksAPI_Server.Services  
{
    public class OpenLibraryService
    {
        private readonly HttpClient httpClient;

        //Depency injection of httpclient, httpclient allows me to access data on the web
        public OpenLibraryService(HttpClient httpClient)
        {;
            this.httpClient = httpClient;
        }

        public async Task<BooksResponse> Search(string query)
        {
            var url = "https://openlibrary.org/search.json?q="+System.Net.WebUtility.UrlEncode(query)+"/anand&offset=0&limit=20";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var response = await httpClient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<BooksResponse>(responseBody);

                
            }
            else
            {
                throw new Exception("error occurred");
            }
        }


    }
}
