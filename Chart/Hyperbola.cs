using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chart
{
    internal class Hyperbola:Function
    {
        override public double[] Draw(int left, int right)
        {
            double[] chart = new double[right-left+1];
            for (int x = left; x <= right; x++)
            {
                if (x!=0) 
                    chart[x-left] = this.A / x;
            }
            return chart;
        }
    }
}
