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
            SSS S1 = new SSS() { Name = "wahaha"};
            Console.WriteLine("Hashcode={0},Name={1}", S1.GetHashCode(), S1.Name);
            C1(ref S1);
            Console.WriteLine("Hashcode={0},Name={1}",S1.GetHashCode(),S1.Name);

            Console.WriteLine("...........................................................");

            SSS S2 = new SSS() {Name = "kakaka" };
            Console.WriteLine("Hashcode={0},Name={1}", S2.GetHashCode(), S2.Name);
            C2(ref S2);
            Console.WriteLine("Hashcode={0},Name={1}", S2.GetHashCode(), S2.Name);

            //......................................................................................
            Console.WriteLine("''''''''''''''''''''''''''''''''''''''");
            AAA b = new BBB();
            b.CW();
            Test(ref b);
            b.CW();
            //小測試，感覺蠻好玩的
        }

        static void  C1(ref SSS S_name)
        {
            S_name.Name = "Tim";
            Console.WriteLine("Hashcode={0},Name={1}", S_name.GetHashCode(), S_name.Name);
            //S1變量空間存放著堆上的 0001實例起始地址
            //呼叫函式時S_name.name是取得S1的0001地址再更改0001地址裡面的name。
            //取得的是0001實例地址裡面更改過後的Name
        }

        static void C2(ref SSS S_name) {
            S_name = new SSS() { Name ="Tim"};
            Console.WriteLine("Hashcode={0},Name={1}",S_name.GetHashCode(), S_name.Name);
            //S2變量空間存著堆上的 0001實例起始地址
            //呼叫函式時把函式裡面創建的 0002實例地址交給S2，覆蓋掉本來存在S2的0001地址。
            //取得的是0002實例地址裡面實例化時賦予的的Name
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

    public class SSS
    {
        public string Name { get; set; }
    }

}
