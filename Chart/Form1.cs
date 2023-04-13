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
            Hyperbola chart = new Hyperbola();
            chart.A = A;
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
        private void DrawParabola(string name, double A, double B, double C, int left, int right)
        {
            Parabola chart = new Parabola();
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
        private void DrawSinus(string name, double A, double B, int left, int right) 
        { 
            Sinus chart = new Sinus();
            chart.A = A;
            chart.B = B;

            var graf = chart.Draw(left, right);
            Graf.Series.Add(name);
            Graf.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = left; i <= right; i++)
            {
                Graf.Series[name].Points.AddXY(i, graf[i - left]);
            }
        }
        private void DrawCosinus(string name, double A, double B, int left, int right)
        {
            Cosinus chart = new Cosinus();
            chart.A = A;
            chart.B = B;

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
        private void DrawCube(string name, double A, double B, int left, int right)
        {
            Cube chart = new Cube();
            chart.A = A;
            chart.B = B;

            var graf = chart.Draw(left, right);
            Graf.Series.Add(name);
            Graf.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = left; i < right; i++)
            {
                Graf.Series[name].Points.AddXY(i, graf[i - left]);
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
            double A=0;
            bool haveCooficientA = coeffA.Text != "" && Double.TryParse(coeffA.Text, out A);
            double B=0;
            bool haveCooficientB = coeffB.Text != "" && Double.TryParse(coeffB.Text, out B);
            double C=0;
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
                    if (rightEnter && haveCooficientA && haveCooficientB)
                        DrawCosinus(chartName.Text, A, B, left, right);
                    break;
                case 1:
                    if (rightEnter && haveCooficientA && haveCooficientB)
                        DrawSinus(chartName.Text, A, B, left, right);
                    break;
                case 2:
                    if (rightEnter && haveCooficientA && haveCooficientB && haveCooficientC)
                        DrawParabola(chartName.Text, A, B, C, left, right);
                    break;
                case 3:
                    if (rightEnter && haveCooficientA && A!=0)
                        DrawHyperbola(chartName.Text, A, left, right);
                    break;
                case 4:
                    if (rightEnter && haveCooficientA && haveCooficientB)
                        DrawCube(chartName.Text, A, B, left, right);
                    break;
                case 5:
                    if (rightEnter && haveCooficientR)
                        DrawCircle(chartName.Text, R);
                    break;
                default:
                    break;
            }
            chartName.Text = "";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                case 1:
                case 4:
                    coeffA.Enabled = true;
                    coeffB.Enabled = true;
                    coeffC.Enabled = false;
                    coeffR.Enabled = false;
                    break;
                case 3:
                    coeffA.Enabled = true;
                    coeffB.Enabled = false;
                    coeffC.Enabled = false;
                    coeffR.Enabled = false;
                    break;
                case 2:
                    coeffA.Enabled = true;
                    coeffB.Enabled = true;
                    coeffC.Enabled = true;
                    coeffR.Enabled = false;
                    break;
                case 5:
                    coeffA.Enabled = false;
                    coeffB.Enabled = false;
                    coeffC.Enabled = false;
                    coeffR.Enabled = true;
                    break;
                default:
                    coeffA.Enabled = false;
                    coeffB.Enabled = false;
                    coeffC.Enabled = false;
                    coeffR.Enabled = false;
                    break;
            }
        }
    }
}
