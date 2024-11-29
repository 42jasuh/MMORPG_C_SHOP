using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    // Observer Pattern
    class InputManager
    {
        // delegate 선언
        public delegate void OnlyInputKey();

        // 동일한 형식에 event 삽입 (접근 제어자와 이름 사이)
        public event OnlyInputKey InputKey;

        public void Update()
        {
            if (Console.KeyAvailable == false)
                return;

            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.A)
            {
                InputKey();
            }
        }
    }
}
