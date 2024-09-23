using System.Reflection.Metadata.Ecma335;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            var quoteApi = new RonVSKanyeAPI();
            var weatherApi = new OpenWeatherMapAPI();

           
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("  Random Conversations");
            Console.WriteLine("\twith");
            Console.WriteLine("Ron Swanson & Kanye West");
            Console.WriteLine("*-----------------------*");

            Console.WriteLine(Environment.NewLine);

         
                for (int i = 0; i < 5; i++)
                {
                    quoteApi.GetKanyeQuote();
                    quoteApi.GetRonQuote();
                }

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Current Weather Forecast for Dora,AL");
            Console.WriteLine("*----------------------------------*");
            weatherApi.GetCurrentWeather();
            Console.WriteLine("*----------------------------------*");


            Console.ReadLine();
           
        }
    }
}
