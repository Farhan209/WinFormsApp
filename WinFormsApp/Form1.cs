using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalcC_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(radius.Text);
            double area = Math.PI * Math.Pow(r, 2);
            area = Math.Round(area, 2);
            areaC.Text = "Area of Circle: " + area.ToString();
            double perimeter = 2 * Math.PI * r;
            perimeter = Math.Round(perimeter, 2);
            perimeterC.Text = "Perimete of Circle: " + perimeter.ToString();
        }

        private void CalcR_Click(object sender, EventArgs e)
        {
            double h = Convert.ToDouble(height.Text);
            double w = Convert.ToDouble(width.Text);
            double area = h * w;
            area = Math.Round(area, 2);
            areaR.Text = "Area of Rectangle: " + area.ToString();
            double perimeter = 2 * (h + w);
            perimeter = Math.Round(perimeter, 2);
            perimeterR.Text = "Perimeter of Rectangle: " + perimeter.ToString();
        }

        private void CalcT_Click(object sender, EventArgs e)
        {
            double sideA = Convert.ToDouble(a.Text);
            double sideB = Convert.ToDouble(b.Text);
            double sideC = Convert.ToDouble(c.Text);
            double s = (sideA + sideB + sideC) / 2;
            double formula = s * (s - sideA) * (s - sideB) * (s - sideC);
            double area = Math.Sqrt(formula);
            area = Math.Round(area, 2);
            areaT.Text = "Area of Triangle: " + area.ToString();
            double perimeter = sideA + sideB + sideC;
            perimeter = Math.Round(perimeter, 2);
            perimeterT.Text = "Perimeter of Triangle: " + perimeter.ToString();
        }
    }
}
