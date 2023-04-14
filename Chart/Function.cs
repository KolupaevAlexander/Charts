using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chart
{
    abstract internal class Function
    {
        double a;
        double b;
        double c;
        public double A { get { return a; } set { a = value; } }
        public double B { get { return b; } set { b=value; }}
        public double C { get { return c; } set { c = value; } }

        public Function(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        abstract public double[] Draw(int left, int right);
    }
}
