using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserCls
{
    public abstract class Parser
    {
        public abstract void parseContent(object[] elements);
        public abstract Dictionary<string, string> getNextValue();
    }
}
