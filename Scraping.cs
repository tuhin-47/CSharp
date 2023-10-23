//basic scraping
using System;
using HtmlAgilityPack;

namespace WebScraperNameSpace
{
    class WebScraperClass
    {
        public static void Main(string[] args)
        {
            var link = @"https://www.prothomalo.com/";
            var browser = new HtmlWeb();
            Console.WriteLine($"GET: {link}");
            var html = browser.Load(link);
            Console.WriteLine("Done");

            var title = html.DocumentNode.SelectSingleNode("//head/title");
            Console.WriteLine($"title.Name : { title.Name}\ntitle.OuterHtml : {title.OuterHtml}");


        }
    }
}
