using HtmlAgilityPack;
using ParserCls;
using ReprterCls;
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
            string url = args[0];
            string reportType = args[1];

            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(url);

            // parsers
            ImgParser imgp = new ImgParser();
            imgp.parseContent("img", htmlDoc);

            H1Parser h1p = new H1Parser();
            h1p.parseContent("h1", htmlDoc);

            // reporter
            Reporter jrep = ReporterFactory.GetImpl(reportType);
            var ret = jrep.CreateReport(imgp, h1p);

            Console.Write(Encoding.Unicode.GetString(ret));
        }
    }
}
