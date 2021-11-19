using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab2.MathMod;

namespace lab2
{
    public static class SystemFunction
    {
        public static double Calculate(double x)
        {
            if (x <= 0)
            {
                return (((Power((Power(Cos(x), 3) + Cot(x)), 2)) - Csc(x)) - Cos(x));
            }
            else
            {
                return ((((Power((Log(x, 10) / Log(x, 5)), 3)) + (Log(x, 2) + Log(x, 5))) - ((Log(x, 3) / Log(x, 3))) - (Log(x, 2) + Log(x, 5))));

            }
        }
        public static double CalculateByDefaultMethods(double x)
        {
            if (x <= 0)
            {
                return (((Math.Pow((Math.Pow(Math.Cos(x), 3) + MathCot(x)), 2)) - MathCsc(x)) - Cos(x));
            }
            else
            {
                return ((((Math.Pow((Math.Log(x, 10) / Math.Log(x, 5)), 3)) + (Math.Log(x, 2) + Math.Log(x, 5))) - (Math.Pow(Math.Log(x), 3) / Math.Log(x, 3))) - (Math.Log(x, 2) + Math.Log(x, 5)));
            }
        }
        private static double MathCot(double x)
        {
            return Math.Cos(x) / Math.Sin(x);
        }
        private static double MathCsc(double x)
        {
            return 1 / Math.Sin(x);
        }
    }
}
