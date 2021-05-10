using System;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Lesson_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^\+994 (50|51|55|70|77) \d{3} \d{4}$");
            string phone = string.Empty;

            Console.Write("Insert phone number: ");
            phone = Console.ReadLine();

            while (!regex.IsMatch(phone))
            {
                Console.WriteLine("Phone number is invalid.");
                Console.Write("Insert phone number: ");
                phone = Console.ReadLine();
            }

            Console.WriteLine("That's OK");


            //WeatherDataManager manager = new();

            //var weatherData = manager.GetWeatherDataByCityName("Baku");

            //string c = weatherData.sys.country;
            //string n = weatherData.name;
            //float t = weatherData.main.temp;

            //Console.WriteLine($"\t{c}, {n} - {t}°C");



            //var movieData = GetMovieDataBySearch("Iron man");
            //Console.WriteLine("----------------------------------------------");

            //if (movieData.Response == "True")
            //{
            //    Console.WriteLine($"Search results({movieData.totalResults})\n");

            //    foreach (var movie in movieData.Search)
            //    {
            //        Console.WriteLine($"\t{movie.Title} - {movie.Type} - {movie.Year}");
            //        Console.WriteLine("----------------------------------------------");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Movie not found");
            //}





            //var data = web.DownloadString(@"https://www.bakubus.az/az/ajax/apiNew1");

            //File.WriteAllText(@"..\..\..\busdata.json", data);


            //    var web = new WebClient();
            //    var data = web.DownloadString(@"http://ip-api.com/json/");

            //    var ipModel = JsonSerializer.Deserialize<IpDataModel>(data);
            //    Console.WriteLine(ipModel.@as);

            // int @int = 12;
        }

        static MovieDataModel GetMovieDataBySearch(string search)
        {
            WebClient web = new();
            string url = @$"http://www.omdbapi.com/?apikey=f4e0873a&s={search}";

            var data = web.DownloadString(url);
            return JsonSerializer.Deserialize<MovieDataModel>(data);
        }
    }

}
