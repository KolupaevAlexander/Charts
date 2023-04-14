using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Chart
{
    public partial class Form1 : Form
    {
        public double MAX_X = 320;
        public double MIN_X = -320;
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Graf.Series.Clear();
        }

        private void DrawHyperbola(string name, double A, int left, int right)
        {
            Hyperbola chart = new Hyperbola(A, 0, 0);
           
            var graf = chart.Draw(left,right);

            Graf.Series.Add(name+"leftPart");
            Graf.Series[name + "leftPart"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = left; i < 0; i++)
            {
                Graf.Series[name + "leftPart"].Points.AddXY(i, graf[i - left]);
            }

            Graf.Series.Add(name+"rightPart");
            Graf.Series[name + "rightPart"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = 1; i <= right; i++)
            {
                Graf.Series[name + "rightPart"].Points.AddXY(i, graf[i - left]);
            }
        }
        private void DrawABC(string name, double A, double B, double C, int left, int right, Function chart)
        {
            chart.A = A;
            chart.B = B;
            chart.C = C;

            var graf = chart.Draw(left, right);
            Graf.Series.Add(name);
            Graf.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = left; i <= right; i++)
            {
                Graf.Series[name].Points.AddXY(i, graf[i - left]);
            }
        }     
        private void DrawCircle(string name, double r)
        {
            /* Circle chart = new Circle();
             chart.R = R;

             var graf = chart.Draw(0, 0);
             Graf.Series.Add("Окружность");
             for (int i = -320; i < 320; i++)
             {
                 Graf.Series["Окружность"].Points.AddXY(i, graf[i + 320]);
             }*/

            Graf.Series.Add(name);
            Graf.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (double i = -r; i <= r; i += 0.1)
            {
                //Graf.Series[name].Points.AddXY(i, -Math.Sqrt((Math.Pow(r, 2) - Math.Pow(i, 2))));
                Graf.Series[name].Points.AddXY(i, Math.Sqrt((Math.Pow(r, 2) - Math.Pow(i, 2))));
            }
            for (double i = r; i >= -r; i -= 0.1)
            {
                Graf.Series[name].Points.AddXY(i, -Math.Sqrt((Math.Pow(r, 2) - Math.Pow(i, 2))));
                //Graf.Series[name].Points.AddXY(i, Math.Sqrt((Math.Pow(r, 2) - Math.Pow(i, 2))));
            }
        }
        private bool IsRightEnter()
        {
            int left = 1;
            int right = -1;
            bool haveName = chartName.Text != "";
            bool haveBorders = leftBorder.Text != "" && rightBorder.Text != "" && Int32.TryParse(leftBorder.Text, out left) && Int32.TryParse(rightBorder.Text, out right);
            bool rightBorders = left < right;

            return haveName && haveBorders && rightBorders;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            
        }
        private void Changers()
        {
            if (Graf.Series.Count == 1)
            {
                Series s = Graf.Series[chartName.Text];
                Graf.Series.Remove(s);
            }
            if (Graf.Series.Count == 2)
            {
                Series sl = Graf.Series[chartName.Text + "leftPart"];
                Series sr = Graf.Series[chartName.Text + "rightPart"];
                Graf.Series.Remove(sl); Graf.Series.Remove(sr);
            }
            Function chart;
            double A = 0;
            bool haveCooficientA = coeffA.Text != "" && Double.TryParse(coeffA.Text, out A);
            double B = 0;
            bool haveCooficientB = coeffB.Text != "" && Double.TryParse(coeffB.Text, out B);
            double C = 0;
            bool haveCooficientC = coeffC.Text != "" && Double.TryParse(coeffC.Text, out C);
            double R = 0;
            bool haveCooficientR = coeffR.Text != "" && Double.TryParse(coeffR.Text, out R);

            int left = 1;
            int right = -1;
            Int32.TryParse(leftBorder.Text, out left);
            Int32.TryParse(rightBorder.Text, out right);

            bool rightEnter = IsRightEnter();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    chart = new Cosinus(A, B, C);
                    if (rightEnter && haveCooficientA && haveCooficientB)
                        DrawABC(chartName.Text, A, B, C, left, right, chart);
                    break;
                case 1:
                    chart = new Sinus(A, B, C);
                    if (rightEnter && haveCooficientA && haveCooficientB)
                        DrawABC(chartName.Text, A, B, C, left, right, chart);
                    break;
                case 2:
                    chart = new Parabola(A, B, C);
                    if (rightEnter && haveCooficientA && haveCooficientB && haveCooficientC) ;
                    DrawABC(chartName.Text, A, B, C, left, right, chart);
                    break;
                case 3:
                    if (rightEnter && haveCooficientA && A != 0)
                        DrawHyperbola(chartName.Text, A, left, right);
                    break;
                case 4:
                    chart = new Cube(A, B, C);
                    if (rightEnter && haveCooficientA && haveCooficientB)
                        DrawABC(chartName.Text, A, B, C, left, right, chart);
                    break;
                case 5:
                    if (rightEnter)
                        DrawCircle(chartName.Text, A);
                    break;
                default:
                    break;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Changers();
        }
        private void coeffA_TextChanged(object sender, EventArgs e)
        {
            Changers();
        }
        private void coeffB_TextChanged(object sender, EventArgs e)
        {
            Changers();
        }
        private void leftBorder_TextChanged(object sender, EventArgs e)
        {
            Changers();
        }
        private void rightBorder_TextChanged(object sender, EventArgs e)
        {
            Changers();
        }
        private void coeffC_TextChanged(object sender, EventArgs e)
        {
            Changers();
        }
    }
}
