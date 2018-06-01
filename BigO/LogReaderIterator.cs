using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO
{
    class LogReaderIterator: IEnumerator<LogLine>
    {
        private int counter = 0;
        private int sizeLogLines;
        private int sizeUniqueIps;
        private LogLine _current;

        public LogReaderIterator(int sizeLogLines, int sizeUniqueIps)
        {
            this.sizeLogLines = sizeLogLines;
            this.sizeUniqueIps = sizeUniqueIps;
        }

        public LogLine Current => _current;

        //public LogLine Current
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        object IEnumerator.Current => Current;

        //object IEnumerator.Current
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        public bool hasNext()
        {
            return this.counter < this.sizeLogLines;
        }

        public void Dispose()
        {
            _current = null;
        }

        public bool MoveNext()
        {
            if (this.hasNext())
            {
                this.counter++;
                _current = new LogLine(this.counter % this.sizeUniqueIps);
                return true;
            }

            return false;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
