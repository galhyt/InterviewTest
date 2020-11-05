using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserCls
{
    public class H1Parser : Parser
    {
        private int n = 0;
        private string[] _h1s;
        public override void parseContent(string elemType, HtmlDocument htmlDoc)
        {
            object[] elems = GetElements(elemType, x => x.InnerText, htmlDoc);
            _h1s = (from el in elems
                    select (string)el).ToArray();
        }

        public override Dictionary<string, object> getNextValue()
        {
            if (n >= _h1s.Count()) return null;

            Dictionary<string, object> ret = new Dictionary<string, object>
            {
                { "type",  "h1" },
                {"innertext",  _h1s[n]}
            };

            n++;

            return ret;
        }
    }
}
