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
}
