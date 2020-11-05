using ParserCls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ReprterCls
{
    public class JsonRepoter : Reporter
    {
        public override byte[] CreateReport(params Parser[] parsers)
        {
            JObject json = new JObject();
            foreach (Parser prs in parsers)
            {
                Dictionary<string, string> dic = prs.getNextValue();
                if (dic == null) continue;
                string type = dic["type"];
                JArray arr = new JArray();

                while (dic != null)
                {
                    arr.Add(new JObject((from string key in dic.Keys
                                         select new JProperty(key, dic[key])).ToArray()));
                    dic = prs.getNextValue();
                }

                json.Add(new JProperty(type, arr));
            }

            return Encoding.Unicode.GetBytes(json.ToString());
        }
    }
}
