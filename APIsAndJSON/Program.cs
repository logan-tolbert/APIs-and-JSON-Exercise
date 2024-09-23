using System.Reflection.Metadata.Ecma335;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            var quoteApi = new RonVSKanyeAPI();
            bool endProgram = false;

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

            
            Console.ReadLine();
           
        }
    }
}
