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
            try
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
                if (a2 != b2 || c2 != d2)
                {
                    if (a1 == b1 & d1 == c1 & a2 == d2 & b2 == c2)
                    { label5.Text = "Прямоугольник"; label5.ForeColor = Color.BlueViolet; }
                    else if (a2 == d2 & c2 == b2 & Math.Abs(d1 - c1) == Math.Abs(a1 - b1) & d == b)
                    { label5.Text = "Параллелограмм"; label5.ForeColor = Color.Orange; }
                    else
                    {
                        if (a2 == d2 & c2 == b2)
                        { label5.Text = "Трапеция"; label5.ForeColor = Color.Lime; }
                        else { label5.Text = "Произвольный четырёхугольник"; label5.ForeColor = Color.Red; }
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
                else
                { label5.Text = "Невозможно построить"; label5.ForeColor = Color.Red; }
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                if (tb.Text.Length == 2 && tb.Text.Length <= 2)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    return;
                }
            }
            e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Четырехугольник ABCD задан координатами своих вершин на плоскости: А(х1,у1), В(х2,у2), С(х2,у2), D(x4,y4) Определить тип четырехугольника: прямоугольник, параллелограмм, трапеция, произвольный четырехугольник. Учесть погрешность вычислений", "Задание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
