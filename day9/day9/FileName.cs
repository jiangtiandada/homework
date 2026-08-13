using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    internal class FileName
    {
        public Action<int,int> add = (a,b) =>
        {
            Console.WriteLine(a + b);
        };
    }
}
