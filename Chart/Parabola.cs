﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chart
{
    internal class Parabola:Function
    {
        public Parabola(double a, double b, double c) : base(a, b, c) { }
        override public double[] Draw(int left, int right)
        {
            double[] chart = new double[right-left+1];
            for (int x = left; x <= right; x++)
            {
                chart[x-left] = this.A * x * x + this.B * x + this.C;
            }
            return chart;
        }
    }
}
