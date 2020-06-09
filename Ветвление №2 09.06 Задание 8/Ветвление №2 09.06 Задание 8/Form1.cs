using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ветвление__2_09._06_Задание_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Bitmap bt;
        Graphics g;
        private void button1_Click(object sender, EventArgs e)
        {
            
            bt = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bt);
            double a1 = double.Parse(textBox1.Text);
            double a2 = double.Parse(textBox2.Text);

            double b1 = double.Parse(textBox3.Text);
            double b2 = double.Parse(textBox4.Text);

            double c1 = double.Parse(textBox5.Text);
            double c2 = double.Parse(textBox6.Text);

            double d1 = double.Parse(textBox7.Text);
            double d2 = double.Parse(textBox8.Text);

            double a = Math.Sqrt(Math.Pow(a1 - b1, 2) + Math.Pow(b2 - a2, 2));
            double b = Math.Sqrt(Math.Pow(b1 - c1, 2) + Math.Pow(c2 - b2, 2));
            double c = Math.Sqrt(Math.Pow(c2 - d2, 2) + Math.Pow(d1 - c1, 2));
            double d = Math.Sqrt(Math.Pow(d2 - a2, 2) + Math.Pow(a1 - d1, 2));

            if (a1 == b1 & d1 == c1 & a2 == d2 & b2 == c2)
                MessageBox.Show("Прямоугольник");
            else if (a2 == d2 & c2 == b2 & Math.Abs(d1 - c1) == Math.Abs(a1 - b1))
            {
                MessageBox.Show("Параллелограмм");
            }
            else
            {
                if (a2 == d2 & c2 == b2)
                    MessageBox.Show("Трапеция");
            }
  
            a1 *= 3;
            a2 *= 3;
            b1 *= 3;
            b2 *= 3;
            c1 *= 3;
            c2 *= 3;
            d1 *= 3;
            d2 *= 3;
            g.FillEllipse(Brushes.Red, (float)a1, (float)a2, 3, 3);
            g.FillEllipse(Brushes.Red, (float)b1, (float)b2, 3, 3);
            g.FillEllipse(Brushes.Red, (float)c1, (float)c2, 3, 3);
            g.FillEllipse(Brushes.Red, (float)d1, (float)d2, 3, 3);
            g.DrawLine(Pens.Blue, (float)a1, (float)a2, (float)b1, (float)b2);
            g.DrawLine(Pens.Blue, (float)b1, (float)b2, (float)c1, (float)c2);
            g.DrawLine(Pens.Blue, (float)c1, (float)c2, (float)d1, (float)d2);
            g.DrawLine(Pens.Blue, (float)d1, (float)d2, (float)a1, (float)a2);
            Font drawFont = new Font("Calibri", 14);
            g.DrawString("A", drawFont, Brushes.Red, (float)a1 - 20, (float)a2 - 20);
            g.DrawString("B", drawFont, Brushes.Red, (float)b1 - 20, (float)b2 - 20);
            g.DrawString("C", drawFont, Brushes.Red, (float)c1, (float)c2 - 20);
            g.DrawString("D", drawFont, Brushes.Red, (float)d1, (float)d2 - 20);
            pictureBox1.Image = bt;
            pictureBox1.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "10";
            textBox2.Text = "10";
            textBox3.Text = "10";
            textBox4.Text = "20";
            textBox5.Text = "20";
            textBox6.Text = "20";
            textBox7.Text = "20";
            textBox8.Text = "10";
        }
    }
}
