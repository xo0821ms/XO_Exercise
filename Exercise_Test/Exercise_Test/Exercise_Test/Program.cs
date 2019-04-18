using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            AAA b = new BBB();
            b.CW();
            Test(ref b);
            b.CW();
        }

        private static void Test(ref AAA a)
        {
            a = new CCC();
        }
    }


    public class AAA
    {
        public virtual void CW()
        {
            Console.WriteLine("aaa");
        }
    }

    class BBB : AAA
    {
        public override void CW()
        {
            Console.WriteLine("bbb");
        }
    }

    class CCC : AAA
    {
        public override void CW()
        {
            Console.WriteLine("ccc");
        }
    }

}
