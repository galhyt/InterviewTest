using HtmlAgilityPack;
using ParserCls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTest
{
    class Program
    {
        static void Main(string[] args)
        {
         //   string url = args[0];
            string url = "http://ynet.co.il";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(url);
            int[][] imgs = htmlDoc.DocumentNode.SelectNodes("//img").Select(x => new int[] { x.GetAttributeValue("height", 0), x.GetAttributeValue("width", 0) }).ToArray();
            string[] h1s = htmlDoc.DocumentNode.SelectNodes("//h1").Select(x=> x.InnerText).ToArray();


            ImgParser imgp = new ImgParser();
            imgp.parseContent(imgs);

            H1Parser h1p = new H1Parser();
            h1p.parseContent(h1s);

        }
    }
}
