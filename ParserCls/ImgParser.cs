using HtmlAgilityPack;
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
        public override void parseContent(string elemType, HtmlDocument htmlDoc)
        {
            object[] elems = GetElements(elemType, x => new int[] { x.GetAttributeValue("height", 0), x.GetAttributeValue("width", 0) }, htmlDoc);
            _imgs = (from el in elems
                     select (int[])el).ToArray();
        }

        public override Dictionary<string, object> getNextValue()
        {
            if (n >= _imgs.Count()) return null;

            Dictionary<string, object> ret = new Dictionary<string, object>
            {
                { "type",  "image" },
                {"height",  _imgs[n][0]},
                {"width",  _imgs[n][1]}
            };

            n++;

            return ret;
        }

    }
}
