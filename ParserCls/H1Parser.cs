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
        public override void parseContent(object[] elements)
        {
            _h1s = (string[])elements;
        }

        public override Dictionary<string, string> getNextValue()
        {
            if (n >= _h1s.Count()) return null;

            Dictionary<string, string> ret = new Dictionary<string, string>
            {
                { "type",  "h1" },
                {"innertext",  _h1s[n]}
            };

            n++;

            return ret;
        }
    }
}
