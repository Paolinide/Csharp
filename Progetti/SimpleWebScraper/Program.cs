using System;
using System.Net;
using System.Text.RegularExpressions;
using SimpleWebScraper.Builders;
using SimpleWebScraper.Data;
using SimpleWebScraper.Workers;

namespace SimpleWebScraper
{
    class Program
    {
        private const string method = "search";
        static void Main(string[] args)
        {
            Console.Clear();
            // MatchCollection matches = Regex.Matches("This is my bat... This is my rat... This is my fat... This is my cat... This is my chat",
            //                                          "This is my [a-z]at");
            // foreach(var match in matches)
            //     Console.WriteLine(match);


            try
            {
                Console.Write("Inserissci il nome del luogo: ");
                var craigListCity = Console.ReadLine() ?? "";
                Console.Write("Inserissci la categoria craigList: ");
                string craigListCategory = Console.ReadLine();

                using (WebClient client = new WebClient()) // using e parentesi per liberare spazio una volta finito
                {
                    string indirizzo = $"http://{craigListCity.Replace(" ", string.Empty)}.craigList.org/{method}/{craigListCategory}";
                    Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<" + indirizzo);
                    string content = client.DownloadString(
                                $"http://{craigListCity.Replace(" ", string.Empty)}.craigList.org/{method}/{craigListCategory}");
                    ScrapeCriteria scrapeCriteria = new ScrapeCriteriaBuilder()
                    .WithData(content)
                    .WithRegex(@"<a href=\""(.*?)\"" data-id=\""(.*?)\"" class=\""result-title hdrlnk\"">(.*?)</a>")
                    .WithRegexOption(RegexOptions.ExplicitCapture)
                    .WithPart(new ScrapeCriteriaPartBuilder()
                      .WithRegex(@">(.*?)</a>")
                      .WithRegexOption(RegexOptions.Singleline)
                      .Build())
                    .WithPart(new ScrapeCriteriaPartBuilder()
                      .WithRegex(@"href=\""(.*?)\""")
                      .WithRegexOption(RegexOptions.Singleline)
                      .Build())
                    .Build();

                    Scraper scraper = new Scraper();

                    var scrapedElements = scraper.Scrape(scrapeCriteria);

                    if (scrapedElements.Count != 0)
                    {
                        foreach (var scrapedElement in scrapedElements)
                        {
                            Console.WriteLine("• " + scrapedElement);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Non ho trovato niente!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
