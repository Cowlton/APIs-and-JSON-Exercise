
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************** RON |VS| Kanye ******************");
            RonVSKanyeAPI.Conversation(5);
            Console.WriteLine("****************************************************");
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("********************** Whether *********************");
            OpenWeatherMapAPI.WhetherAPI();
            Console.WriteLine("****************************************************");

        }
        
    }
}
