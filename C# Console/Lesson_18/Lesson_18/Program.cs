using System;
using System.IO;
using System.Net;
using System.Text.Json;

namespace Lesson_18
{
    class Program
    {
        static void Main(string[] args)
        {
            var web = new WebClient();
            var data = web.DownloadString(@"https://www.bakubus.az/az/ajax/apiNew1");

            File.WriteAllText(@"..\..\..\busdata.json", data);


            //    var web = new WebClient();
            //    var data = web.DownloadString(@"http://ip-api.com/json/");

            //    var ipModel = JsonSerializer.Deserialize<IpDataModel>(data);
            //    Console.WriteLine(ipModel.@as);

            //int @int = 12;
        }
    }


    public class IpDataModel
    {
        public string status { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public string region { get; set; }
        public string regionName { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public float lat { get; set; }
        public float lon { get; set; }
        public string timezone { get; set; }
        public string isp { get; set; }
        public string org { get; set; }
        public string @as { get; set; }
        public string query { get; set; }
    }

}
