﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chart
{
    internal class Sinus:Function
    {
        override public double[] Draw(int left, int right)
        {
            double[] chart = new double[right-left+1];
            for (int x = left; x <= right; x++)
            {
                chart[x-left] = Math.Sin(Math.PI / 180 * this.A * x) + this.B;
            }
            return chart;
        }
    }
}