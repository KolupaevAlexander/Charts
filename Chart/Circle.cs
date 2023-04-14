using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chart
{
    internal class Circle:Function
    {
        public Circle(double a, double b, double c) : base(a, b, c) { }
        double r;
        public double R { get { return R; } set { R = value; } }
        override public double[] Draw(int left, int right)
        {
            double[] chart = new double[right-left];
            for (int x = left; x < right; x+=2)
            {
                chart[x-left] = Math.Sqrt(R * R - x * x);

                chart[x-left+1] = -Math.Sqrt(R * R - x * x);
            }
            return chart;
        }
    }
}
