using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XO_ElectricitySystem;
namespace WhiteBoxUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(XO_Electricity.GetV(2.1, 6.4));
        }
    }
}
