using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XO_ElectricitySystem;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double res = XO_Electricity.GetV(3.0,2.0);
            Console.WriteLine(res);
        }
    }
}
