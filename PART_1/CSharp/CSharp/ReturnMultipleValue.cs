using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class ReturnMultipleValue
    {        
        static void Return(int a, int b, out int r1, out int r2)
        {
            r1 = a + b;
            r2 = a - b;
        }
    }
}
