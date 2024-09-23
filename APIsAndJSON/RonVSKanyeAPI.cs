using System.Text.Json.Nodes;
namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        HttpClient client = new HttpClient();

        public void GetKanyeQuote()
        {
            var kanyeURL = "https://api.kanye.rest/";
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            JsonNode kanyeQuote = JsonNode.Parse(kanyeResponse);

            Console.WriteLine($"Kanye: {kanyeQuote["quote"].ToString()}{Environment.NewLine}");
        }

        public void GetRonQuote()
        {
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = client.GetStringAsync(ronURL).Result;
            string ronQuote = JsonNode.Parse(ronResponse).ToString()
                .Replace('[', ' ').Replace(']', ' ')
                .Replace('"', ' ').Trim();

            Console.WriteLine($"Ron Swanson: {ronQuote}{Environment.NewLine}");
        }
    }
}
