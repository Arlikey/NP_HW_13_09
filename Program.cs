using System.Net.Http.Json;
using System.Threading.Tasks;

internal class Program
{
    static private readonly string url = "https://zenquotes.io/api/random";
    static private readonly HttpClient client = new HttpClient();

    static async Task Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Чтобы получить цитату нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();

            Quote quote = await GetQuoteAsync();
            Console.WriteLine($"\"{quote.q}\" - {quote.a}\n");
        }
    }

    static public async Task<Quote> GetQuoteAsync()
    {
        try
        {
            var quote = await client.GetFromJsonAsync<List<Quote>>(url);
            return quote.FirstOrDefault();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }
}

class Quote
{
    public string q { get; set; }
    public string a { get; set; }
}