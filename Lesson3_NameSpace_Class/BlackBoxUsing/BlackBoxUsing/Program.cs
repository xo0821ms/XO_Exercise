using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBoxUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            double resV = XO_ElectricitySystem.XO_Electricity.GetV(2.2,3);
            double resI = XO_ElectricitySystem.XO_Electricity.GetI(4.2,2);
            double resR = XO_ElectricitySystem.XO_Electricity.GetR(8.8,1);
            Console.WriteLine("v={0}\nI={1}\nR={2}",resV,resI,resR);
            Console.WriteLine("...........................................");
            double resrR = XO_ElectricitySystem.XO_Electricity.GetR(0, 3);
            double resrr = XO_ElectricitySystem.XO_Electricity.GetR(0,0);
            double resRr = XO_ElectricitySystem.XO_Electricity.GetR(2.2,0);
            Console.WriteLine("rR="+resrR+"\r\n"+"rr="+resrr + "\r\n" + "Rr="+resRr);
            Console.WriteLine("...........................................");
            Console.WriteLine('1'+"\r"+'2');//回車:回到本行行首，所以會覆蓋。
        }
    }
}
