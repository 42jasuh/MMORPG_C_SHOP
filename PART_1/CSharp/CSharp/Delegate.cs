using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Delegate
    {
        /* 
        delegate -> 함수를 인자로 넘겨주는 형식
        반환: int, 입력: void
        delegate 이름 OnClick
        */

        delegate int Example(int a, int b);

        Example add = SumValue;
        Example multiply = MultiplyValue;

        static int SumValue(int a, int b) { return a + b; }
        static int MultiplyValue(int a, int b) { return a * b; }
    }
}
