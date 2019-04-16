using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO_ElectricitySystem
{
    public class XO_Electricity
    {
        public static double GetV(double i,double r) {
            return i * r;
        }

        public static double GetI(double v,double r) {
            return GetDiv(v,r);
            //if (r!=0)
            //{
            //    return v / r;
            //}
            //else if(v == 0)
            //{
            //    return float.NaN;
            //}
            //else { return v  > 0 ? float.PositiveInfinity : float.NegativeInfinity; }
        }

        public static double GetR(double v, double i)
        {
           return GetDiv(v,i);
            //if (i != 0)
            //{
            //    return v / i;
            //}
            //else if (i == 0)
            //{
            //    return float.NaN;
            //}
            //else { return v > 0 ? float.PositiveInfinity : float.NegativeInfinity; }
        }

        private static double GetDiv(double a,double b)//Refactoring_Extract Method
        {
            if (b != 0){ return a / b;}
            else if (a == 0){return double.NaN;}
            else { return a > 0 ? double.PositiveInfinity : double.NegativeInfinity; }
        }
    }
}
