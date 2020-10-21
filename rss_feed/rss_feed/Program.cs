using System;
using System.Linq;
using System.Xml.Linq;

namespace rss_feed
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument bbc = XDocument.Load("bbc.xml");
            XDocument index = XDocument.Load("index.xml");
            XDocument origo = XDocument.Load("origo.xml");
            XDocument telex = XDocument.Load("telex.xml");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("BBC News:");
            bbc.Root.Descendants("item").Select(x => x.Element("title").Value).ToList().ForEach(x => Console.WriteLine(x));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Index News:");
            index.Root.Descendants("item").Select(x => x.Element("title").Value).ToList().ForEach(x => Console.WriteLine(x));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Origo News:");
            origo.Root.Descendants("item").Select(x => x.Element("title").Value).ToList().ForEach(x => Console.WriteLine(x));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Telex News:");
            telex.Root.Descendants("item").Select(x => x.Element("title").Value).ToList().ForEach(x => Console.WriteLine(x));

            Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine(bbc);
        }
    }
}
