using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Stat
    {
        public int Str { get; set; }
        public int Spd { get; set; }
        public int Lk { get; set; }
        public int Int { get; set; }

        public Stat(int st, int sp, int l, int i)
        {
            Str = st;
            Spd = sp;
            Lk = l;
            Int = i;
        }
        public static int StrGen()
        {
            Console.WriteLine("On a scale of 1-10, how much can you lift?");
            bool canLift = int.TryParse(Console.ReadLine(), out int s);
            return s;
        }
        public static int SpdGen()
        {
            Console.WriteLine("On a scale of 1-10, how fast can you go?");
            bool canGo = int.TryParse(Console.ReadLine(), out int s);
            return s;
        }
        public static int LkGen()
        {
            Console.WriteLine("Flip a coin 10 times, How many heads?");
            bool canLuck = int.TryParse(Console.ReadLine(), out int s);
            return s;
        }
        public static int IntGen()
        {
            int i = 10;
            Console.WriteLine("Next is a test of intellegence. Pay close attention, starting NOW:");
            Console.WriteLine("How many i's");
            bool canSmart = int.TryParse(Console.ReadLine(), out int s);
            if (canSmart = false || s != 1)
            {
                i -= 1;
            }
            Console.WriteLine("How many eyes");
            canSmart = int.TryParse(Console.ReadLine(), out s);
            if (canSmart = false || s != 2)
            {
                i -= 1;
            }
            Console.WriteLine("How many I's");
            canSmart = int.TryParse(Console.ReadLine(), out s);
            if (canSmart = false || s != 1)
            {
                i -= 1;
            }
            Console.WriteLine("How many u's");
            canSmart = int.TryParse(Console.ReadLine(), out s);
            if (canSmart = false || s != 1)
            {
                i -= 1;
            }
            Console.WriteLine("How many e's");
            canSmart = int.TryParse(Console.ReadLine(), out s);
            if (canSmart = false || s != 3)
            {
                i -= 1;
            }
            Console.WriteLine("How many a's");
            canSmart = int.TryParse(Console.ReadLine(), out s);
            if (canSmart = false || s != 7)
            {
                i -= 1;
            }
            Console.WriteLine("How many s's");
            canSmart = int.TryParse(Console.ReadLine(), out s);
            if (canSmart = false || s != 8)
            {
                i -= 1;
            }
            Console.WriteLine("How many is 10");
            canSmart = int.TryParse(Console.ReadLine(), out s);
            if (canSmart = false || s != 10)
            {
                i -= 1;
            }
            Console.WriteLine("How many to's");
            canSmart = int.TryParse(Console.ReadLine(), out s);
            if (canSmart = false || s != 0)
            {
                i -= 1;
            }
            Console.WriteLine("How many is two");
            canSmart = int.TryParse(Console.ReadLine(), out s);
            if (canSmart = false || s != 2)
            {
                i -= 1;
            }
            return i;
        }
    }
}
