using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Player
    {
        // private 변수의 경우 클래스 내부에서만 접근 가능
        private static int counter = 0;

        // static X -> 인스턴스 변수, public 키워드 -> 외부에서 접근 가능
        public int id;
        public int hp;
        public int attack;

        // 생성자
        public Player()
        {
            AddCounter();
            id = GetCounter();
            Console.WriteLine("Player 생성자 호출");
        }

        // 생성자 오버로딩
        public Player(int hp, int attack)
        {
            AddCounter();
            id = GetCounter();
            this.hp = hp;
            this.attack = attack;
            Console.WriteLine("Player hp attack 생성자 호출");
        }
        static private void AddCounter()
        {
            Player.counter++;
        }

        static public int GetCounter()
        {
            return Player.counter;
        }

        public int AttackValue
        {
            get { return attack; }

            // set 함수의 경우 외부 접근 불가
            private set { attack = value; }
        }

        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }

        // 상속 문법
        class Knight : Player
        {
            public Knight()
            {
                hp = 100;
                attack = 10;
                Console.WriteLine("Knight 생성자 호출");
            }

            public Knight(int hp, int attack) : base(100, 10)
            {
                this.hp = hp;
                this.attack = attack;
                Console.WriteLine("Knight hp attack 생성자 호출");
            }

        }

        // 인터페이스
        interface ISuperPower
        {
            void Power<T>(T power);
        }

        // 반드시 구현해야 하는 클래스, 생성자로 사용될 수 없음
        abstract class Base
        {
            public abstract void method();
        }

        class Child : Base
        {
            public override void method()
            {
                Console.WriteLine("Child Method");
            }
        }

        class Baby : Child, ISuperPower
        {
            public override void method()
            {
                Console.WriteLine("Child Method");
            }

            public void Power<T>(T power)
            {
                Console.WriteLine(power);
            }
        }
    }

}
