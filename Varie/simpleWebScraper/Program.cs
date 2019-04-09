using System;
using System.Net;
namespace simpleWebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using  (WebClient client = new WebClient()){
                string googleMainPage = client.DownloadString("http://www.google.com");
                Console.WriteLine(googleMainPage);
                //<a href="(.*?)" data-id="(.*?)" class="result-title hdrlnk">(.*?)<\/a>

            }
        }
    }
}
