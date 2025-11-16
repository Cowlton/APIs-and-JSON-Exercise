using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {
        public static void Conversation(int sentenceNumber)
        {
            var client = new HttpClient();
            
            for (int i = 0; i <= sentenceNumber; i++)
            {
                if (i % 2 == 0)
                {
                    #region Ron Swanson API
            
                    string ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
                    var ronResponse = client.GetStringAsync(ronUrl).Result;
                    var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            
                    #endregion
                    
                    Console.WriteLine($"Ron: {ronQuote}");
                }
                else
                {
                    #region Kanye West API
            
                    string kanyeUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
                    var kanyeResponse = client.GetStringAsync(kanyeUrl).Result;
                    var kanyeQuote = JArray.Parse(kanyeResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            
                    #endregion
                    
                    Console.WriteLine($"Kanye: {kanyeQuote}");
                }
                
            }
            
        }
        
    }
}
