using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = XElement.Load("http://news.google.com/news?pz=1&cf=all&ned=us&hl=en&output=rss");


            var q = root.Descendants("item").Select(x => new
            {
                Title = x.Element("title").Value
            });
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

        }
    }
}
