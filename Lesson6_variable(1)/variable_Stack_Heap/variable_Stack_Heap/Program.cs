using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variable_Stack_Heap
{
    class Program
    {
        static void Main(string[] args)
        {

            SSS();   
        

        }


        static void SSS() {
            double res = 3.0 / 4.0;// 3.0(double)/4.0(double) = 0.75(double)
            double result = 3 / 4;//  4(int)/3(int) = 0(int)然後才把0放到result(double)裡
            Console.WriteLine(res);
            Console.WriteLine(result);
        }

        

       static void GetMyType()//得到具體類型方式
        {
            Type myType = typeof(Form);
            Console.WriteLine(myType.BaseType.BaseType.FullName);

            PropertyInfo[] pInfos =  myType.GetProperties();
            foreach (var v in pInfos)
            {
                Console.WriteLine(v.Name);
            }
            Console.WriteLine(".....................................................");
            MethodInfo[] mInfos = myType.GetMethods();
            foreach (var v in mInfos)
            {
                Console.WriteLine(v.Name);
            }

        }

       static void Class_Dynamic()//Dynamic練習
        {
            dynamic myVar = 100;
            Console.WriteLine(myVar);
            myVar = "hahaha";
            Console.WriteLine(myVar);
        }

    }


    


}
