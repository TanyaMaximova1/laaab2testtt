using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Params
    {
        public Params(double start, double end, double step)
        {
            Start = start;
            End = end;
            Step = step;
        }

        public double Start { get; set; }
        public double End { get; set; }
        public double Step { get; set; }
    }
}
