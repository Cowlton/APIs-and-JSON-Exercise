using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        public static void WhetherAPI()
        {
            GetWeather();
            
            static void GetWeather()
            {

                Console.WriteLine("What is the name of the city you live in??");
                
                var cityname = Console.ReadLine();
                
                try
                {
                    #region Wether API

                    var client = new HttpClient();

                    var key = "a3e0356ff107ddea8ae27e7f43905e55";

                    var wetherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityname}&appid={key}";

                    var response = client.GetStringAsync(wetherURL).Result;


                    JObject formattedRespons = JObject.Parse(response);
                    
                    #endregion
                    
                    var temp = formattedRespons["main"]["temp"];
                    var pressure = formattedRespons["main"]["pressure"];
                    var humidity = formattedRespons["main"]["humidity"];
                    var name = formattedRespons["name"];

                    var n = temp.ToObject<double>();
                    
                    var Fahrenheit  = Math.Round(((n - 273.15) * 9 / 5 + 32) ,2);

                    Console.WriteLine();
                    Console.WriteLine($"The Temperature is currently {Fahrenheit}∘ Fahrenheit.");
                    Console.WriteLine($"The current Air Pressure is {pressure}.");
                    Console.WriteLine($"And the Humidity in {name} is currently {humidity}.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please enter valid city name");

                    GetWeather();
                }

                

            }

        }
        
        
    }
}
