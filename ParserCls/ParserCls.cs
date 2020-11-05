using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserCls
{
    public abstract class Parser
    {
        public abstract void parseContent(string elemType, HtmlDocument htmlDoc);
        public abstract Dictionary<string, object> getNextValue();

        protected object[] GetElements(string elemType, Func<HtmlNode, object> lambda, HtmlDocument htmlDoc)
        {
            return htmlDoc.DocumentNode.SelectNodes("//"+ elemType).Select(lambda).ToArray();
        }
    }
}
