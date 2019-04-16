using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_HanoiTower
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 64; i++)
            {
                Console.WriteLine(i + ":"+Hanoi.Hanoi_Recursively(i));
                Console.WriteLine(i + ":"+Hanoi.Hanoi_Loop(i));
                Console.WriteLine(i + ":"+Hanoi.Hanoi_binary(i));
                Console.WriteLine(i + ":"+Hanoi.Hanoi_programmingBehaviour(i));
                Console.WriteLine(i + ":"+Hanoi.Hanoi_programmingBehaviour_2(i));
                Console.WriteLine(i + ":"+Hanoi.Hanoi_programmingBehaviour_3(i));
                Console.WriteLine("......................................");
            }
        }
    }

    class Hanoi//.....2s+1;;上面沒拿完不可能動得到最下面的，全部移出(S)+位移(1)+再全部移過去(~S)_stack
    {
        public static ulong Hanoi_Recursively(int x)//v1.0
        {
            ulong t = 0;
            if (x > 0)
                return x > 1 ? t += 2 * Hanoi_Recursively(x - 1) + 1 : 1;
            else return 0;
        }

        public static ulong Hanoi_Loop(int x)//v2.0
        {
            if (x > 0)
            {
                ulong t = 0;
                for (int i = 0; i < x; i++)
                {
                    t = 2 * t + 1;
                }
                return t;
            }
            else { return 0; }
        }

        public static ulong Hanoi_binary(int x)//v3.0
                                               //2S(1000) = S(0100)+S(0100)
                                               //2S(0100) = S(0010)+S(0010)
                                               //2S(0010) = S(0001)+S(0001)
        {
            ulong t = 0;
            for (int i = 0; i < x; i++)
            {
                t = (t << 1) + 1;
            }
            return t;
        }

        public static ulong Hanoi_programmingBehaviour(int x)//v4.0
        {
            return x > 0 ? ~(~(ulong)0 << x) : 0;
        }

        public static ulong Hanoi_programmingBehaviour_2(int x)//v4.1
        {
            return x > 0 ? ~(~0ul << x) : 0;
        }

        public static ulong Hanoi_programmingBehaviour_3(int x)//v4.2
        {
            return x > 0 ? ~(ulong.MaxValue << x) : 0;
        }

    }
}
