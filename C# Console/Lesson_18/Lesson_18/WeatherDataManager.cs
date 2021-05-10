using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lesson_18
{
    public class WeatherDataManager
    {
        static string apikey = "619607d6b9523abaa7ee9d084538ca3d";
        static string urlBase = @$"http://api.openweathermap.org/data/2.5/weather?appid={apikey}&units=metric";
        WebClient web = new();

        public WeatherDataModel GetWeatherDataByCityName(string cityName)
        {
            var data = web.DownloadString($"{urlBase}&q={cityName}");
            return JsonSerializer.Deserialize<WeatherDataModel>(data);
        }
    }
}
