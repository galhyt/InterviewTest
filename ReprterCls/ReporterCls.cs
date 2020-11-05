using ParserCls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReprterCls
{
    public abstract class Reporter
    {
        public abstract byte[] CreateReport(params Parser[] parsers);
    }

    public class ReporterFactory
    {
        public static Reporter GetImpl(string type)
        {
            switch  (type)
            {
                case "json":
                default:
                    return new JsonRepoter();
                    break;
            }
        }
    }
}
