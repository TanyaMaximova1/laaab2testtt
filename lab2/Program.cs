using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab2.MathMod;
using static lab2.SystemFunction;

namespace lab2
{
    public class Program
    {
        private delegate double Action(double x);

        static void Main(string[] args)
        {
            var paramsDefault = new Params(-10, 10, 0.01);

            CalculateValues(x => Sin(x), "sin", paramsDefault);
            CalculateValues(x => Cos(x), "cos", paramsDefault);
            CalculateValues(x => Exp(x), "exp", paramsDefault);

            var positiveParams = new Params(0, 10, 0.01);

            CalculateValues(x => Ln(x), "ln", positiveParams);
            CalculateValues(x => Sqrt(x), "sqrt", positiveParams);

            CalculateValues(x => Calculate(x), "Calculate", positiveParams);
            CalculateValues(x => CalculateByDefaultMethods(x), "CalculateByDefaultMethods", positiveParams);

        }

        private static void CalculateValues(Action action, string name, Params @params)
        {
            string path = $"{name}.csv";

            using (FileStream fs = File.Create(path))
            {
                fs.Close();
            }

            StreamWriter sw = new StreamWriter(path, false, Encoding.Unicode);

            for (double x = @params.Start; x < @params.End; x += @params.Step)
            {
                sw.WriteLine($"{x};{action(x)}");
            }
        }

    }
}
