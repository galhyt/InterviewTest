using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserCls
{
    public class ImgParser : Parser
    {
        private int n = 0;
        private int[][] _imgs;
        public override void parseContent(object[] elements)
        {
            _imgs = (int[][])elements;
        }

        public override Dictionary<string, string> getNextValue()
        {
            if (n >= _imgs.Count()) return null;

            Dictionary<string, string> ret = new Dictionary<string, string>
            {
                { "type",  "image" },
                {"height",  _imgs[n][0].ToString()},
                {"width",  _imgs[n][1].ToString()}
            };

            n++;

            return ret;
        }

    }
}
