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
        public double A { get { return a; } set { a = value; } }
        public double B { get { return b; } set { b=value; }}
        abstract public double[] Draw(int left, int right);
    }
}
