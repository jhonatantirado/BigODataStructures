using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO
{
    class LogLine
    {
        int counter;

        public LogLine (int counter)
        {
            this.counter = counter;
        }

        public string getIP()
        {
            return "ip-" + counter;
        }
    }
}
