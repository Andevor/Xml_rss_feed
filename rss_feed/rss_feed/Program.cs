using System;
using System.Collections.Generic;
using System.Linq;

namespace rss_feed
{
    class Program
    {
        static void Main(string[] args)
        {
            //XDocument bbc = XDocument.Load("bbc.xml");
            //XDocument index = XDocument.Load("index.xml");
            //XDocument origo = XDocument.Load("origo.xml");
            //XDocument telex = XDocument.Load("telex.xml");

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("BBC News:");
            //bbc.Root.Descendants("item").Select(x => x.Element("title").Value).ToList().ForEach(x => Console.WriteLine(x));
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("Index News:");
            //index.Root.Descendants("item").Select(x => x.Element("title").Value).ToList().ForEach(x => Console.WriteLine(x));
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Origo News:");
            //origo.Root.Descendants("item").Select(x => x.Element("title").Value).ToList().ForEach(x => Console.WriteLine(x));
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Telex News:");
            //telex.Root.Descendants("item").Select(x => x.Element("title").Value).ToList().ForEach(x => Console.WriteLine(x));

            //List<RSS> bbc = RSS.LoadXml("bbc.xml");
            List<RSS> bbc = RSS.LoadXml("http://feeds.bbci.co.uk/news/world/europe/rss.xml");
            //foreach (RSS item in bbc)
            //{
            //    Console.WriteLine(item);
            //}

            bbc.Where(x => x.PubDate.Hour == 12).Select(x => x.Link).ToList().ForEach(x => Console.WriteLine(x));

            //var links = bbc.Where(x => x.Title.Contains("Coronavirus")).Select(x => x.Link).ToList();

            var covid = bbc.Where(x => x.Title.Contains("Coronavirus")).Count();

            Console.WriteLine("Number of Covid news: " + covid);
            //foreach (string item in links)
            //{
            //    var psi = new ProcessStartInfo
            //    {
            //        FileName = item,
            //        UseShellExecute = true
            //    };
            //    Process.Start(psi);
            //}

            List<RSS> index = RSS.LoadXml("https://index.hu/24ora/rss/");

            foreach (RSS item in index)
            {
                if (item.Title.Contains("korona"))
                {
                    Console.WriteLine(item);
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine(bbc);
        }
    }
}
