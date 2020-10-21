using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace rss_feed
{
    class RSS
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public DateTime PubDate { get; set; }

        public static List<RSS> LoadXml(string url)
        {
            XDocument rss = XDocument.Load(url);

            return rss.Root.Descendants("item")
                .Select(x => new RSS()
                {
                    Title = x.Element("title")?.Value,
                    Link = x.Element("link")?.Value,
                    PubDate = DateTime.Parse(x.Element("pubDate")?.Value)
                }).ToList();
        }

        public override string ToString()
        {
            return "Title: " + Title;
        }
    }
}
