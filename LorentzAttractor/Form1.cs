using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LorentzAttractor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Red);
            SolidBrush sb2 = new SolidBrush(Color.Blue);
            SolidBrush sb3 = new SolidBrush(Color.Green);

            int size = 5000;
            double x, x2, x3;
            double y, y2, y3;
            double z, z2, z3;
            double t = 0, t2 = 0, t3 = 0;
            double rho = 28.0, sigma = 10.0, beta = 2.66667, dt = 0.01;
            double rho2 = 28.0, sigma2 = 10.0, beta2 = 2.66668, dt2 = 0.01;
            double rho3 = 28.0, sigma3 = 10.0, beta3 = 2.66669, dt3 = 0.01;
            x = 1;
            y = 1;
            z = 1;
            x2 = 1;
            y2 = 1;
            z2 = 1;
            x3 = 1;
            y3 = 1;
            z3 = 1;
            for (int i = 0; i < size - 1; i++)
            {
                x += (sigma * (y - x)) * dt;
                x2 += (sigma2 * (y2 - x2)) * dt2;
                x3 += (sigma3 * (y3 - x3)) * dt3;
                y += - (x * z - rho * x + y) * dt;
                y2 += -(x2 * z2 - rho2 * x2 + y2) * dt2;
                y3 += -(x3 * z3 - rho3 * x3 + y3) * dt3;
                z += + (x * y - beta * z) * dt;
                z2 += +(x2 * y2 - beta2 * z2) * dt2;
                z3 += +(x3 * y3 - beta3 * z3) * dt3;
                t += dt;
                t2 += dt2;
                t3 += dt3;

                gg.FillEllipse(sb, 900 + (float)x * 25, 10 + (float)z * 20 , 5, 5);
                gg.FillEllipse(sb2, 900 + (float)x2 * 25, 10 + (float)z2 * 20, 5, 5);
                gg.FillEllipse(sb3, 900 + (float)x3 * 25, 10 + (float)z3 * 20, 5, 5);
                Thread.Sleep(2);
            }
           
        }
    }
}
