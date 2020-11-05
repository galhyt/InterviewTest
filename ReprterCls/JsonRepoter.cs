using ParserCls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReprterCls
{
    public class JsonRepoter : Reporter
    {
        public override byte[] CreateReport(Parser[] parsers)
        {
            string ret = "{";
            foreach (Parser prs in parsers)
            {
                StringBuilder json = new StringBuilder();
                Dictionary<string, string> dic = prs.getNextValue();
                string type = "";
                if (dic != null) type = dic["type"];
                while (dic != null)
                {
                    json.AppendFormat("{{height: {0}, width: {1} }}");
                    dic = prs.getNextValue();
                }

                ret = string.Format("{{ {0}: {{ {1} }}", 
            }
        }
    }
}
