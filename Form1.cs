using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FractalTest
{
    public partial class Form1 : Form
    {
        int Red=255, Green=255, Blue = 255;
        int RedBack = 12, GreenBack = 12, BlueBack = 0;
        double Constant = 2, ConstantReal=0, ConstantImg = 0;
        double lenx = 3, leny = 3, lx = 0, ly = 0;
        bool Mouse_Down = false, Mouse_Up = false, rectangle = false;
        double xs = 0, ys = 0, xe = 0, ye = 0;
        double xzoom=0, yzoom=0;
        double xstart = 0, ystart=0, xend = 3, yend = 3;
        int pl = 1;
        bool Julia = false, Mondelbrod = true, Fractal1 = false;
        bool action = false;
        private Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            bmp = new Bitmap(FractalPict.Width, FractalPict.Height);
        }

        public double getRX(double x)
        {
            return (x - (double)FractalPict.Width / 2.0) * (lenx / (double)FractalPict.Width) + lx;
        }

        public double getRY(double y)
        {
            return -(y - (double)FractalPict.Height / 2.0) * (leny / (double)FractalPict.Height) + ly;
        }

        public void Zoom()
        {
            pl++;
            double RSx = Math.Min(getRX(xstart), getRX(xend)), RSy = Math.Min(getRY(ystart), getRY(yend));
            double REx = Math.Max(getRX(xstart), getRX(xend)), REy = Math.Max(getRY(ystart), getRY(yend));
            lx += (RSx + REx) / 2.0 - getRX(FractalPict.Width / 2.0); 
            ly += (RSy + REy) / 2.0 - getRY(FractalPict.Height / 2.0);
            lenx=REx-RSx; leny=REy-RSy;
        }

        public void DrawFractal_MondelBrod()
        {
            //bmp = new Bitmap(FractalPict.Width, FractalPict.Height);
            
            for (int x=0; x<FractalPict.Width; x++)
            {
                for (int y=0; y<FractalPict.Height; y++)
                {
                    double a = getRX(x);
                    double b = getRY(y);
                    Complex c = new Complex(a, b);
                    Complex zer = new Complex(ConstantReal, ConstantImg);
                    int it = 0;
                    while (it < 100 * pl)
                    {
                        zer.Square();
                        zer.Plus(c);
                        it++;
                        if (zer.ABS() > Constant)
                        {
                            break;
                        }
                    }
                    if (it < 100 * pl)
                    {
                        bmp.SetPixel(x, y, Color.FromArgb(RedBack * it % 256, GreenBack * it % 256, BlueBack * it % 256));
                    }
                    else
                    {
                        bmp.SetPixel(x,y,Color.FromArgb(Red, Blue, Green));
                    }
                }
            }
            Iterations.Text = " Iterations: " + (100 * pl).ToString();
            FractalPict.Image = bmp;
        }

        public void DrawFractal_Julia()
        {
            //bmp = new Bitmap(FractalPict.Width, FractalPict.Height);
            for (int x = 0; x < FractalPict.Width; x++)
            {
                for (int y = 0; y < FractalPict.Height; y++)
                {
                    double zx = getRX(x);// 1.5 * (x - pictureBox.Width / 2) / (0.5 * Zoom) + OffsetX;
                    double zy = getRY(y);// (y - pictureBox.Height / 2) / (0.5 * Zoom) + OffsetY;

                    int it = 0;
                    while (it < 100 * pl)
                    {
                        double temp = zx * zx - zy * zy + ConstantReal;
                        zy = 2.0 * zx * zy + ConstantImg;
                        zx = temp;

                        if (zx * zx + zy * zy > Constant)
                            break;

                        it++;
                    }
                    if (it < 100 * pl)
                    {
                        bmp.SetPixel(x, y, Color.FromArgb(RedBack * it % 256, BlueBack * it % 256, GreenBack * it % 256));
                    }
                    else
                    {
                        bmp.SetPixel(x, y, Color.FromArgb(Red, Blue, Green));
                    }
                }
            }
            Iterations.Text = " Iterations: " + (100 * pl).ToString();
            FractalPict.Image = bmp;
        }

        public void DrawFractal1()
        {
            //bmp = new Bitmap(FractalPict.Width, FractalPict.Height);
            for (int x = 0; x < FractalPict.Width; x++)
            {
                for (int y = 0; y < FractalPict.Height; y++)
                {
                    double zx = getRX(x);// 1.5 * (x - pictureBox.Width / 2) / (0.5 * Zoom) + OffsetX;
                    double zy = getRY(y);// (y - pictureBox.Height / 2) / (0.5 * Zoom) + OffsetY;

                    int it = 0;
                    while (it < 100 * pl)
                    {
                        double temp = zx * zx - zy * zy + ConstantReal;
                        zy = 2.0 * zx * zy + ConstantImg;
                        zx = temp;

                        if (Math.Cos(zx * zx + zy * zy) > Constant)
                            break;

                        it++;
                    }
                    if (it < 100 * pl)
                    {
                        bmp.SetPixel(x, y, Color.FromArgb(RedBack * it % 256, BlueBack * it % 256, GreenBack * it % 256));
                    }
                    else
                    {
                        bmp.SetPixel(x, y, Color.FromArgb(Red, Blue, Green));
                    }
                }
            }
            Iterations.Text = " Iterations: " + (100 * pl).ToString();
            FractalPict.Image = bmp;
        }

        Point ORIGIN = new Point(0,0);
        private void FractalPict_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(bmp, ORIGIN);
            if (rectangle)
            {
                Pen pLine = new Pen(Color.White, 2);
                int xs=(int)xstart, ys=(int)ystart;
                int x = (int)xe, y = (int)ye;
            if (xs < xe)
                {
                    if (ys < ye) g.DrawRectangle(pLine, xs, ys, (x - xs), (y - ys));
                    else g.DrawRectangle(pLine, xs, y, (x - xs), (ys - y));
                }
                else
                {
                    if (ys < ye) g.DrawRectangle(pLine, x, ys, (xs - x), (y - ys));
                    else g.DrawRectangle(pLine, x, y, (xs - x), (ys - y));
                }
            }
            FractalPict.Image = bmp;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Mondelbrod)
            {
                Red = 255; Green = 255; Blue = 255;
                RedBack = 12; GreenBack = 12; BlueBack = 0;
                Constant = 2; ConstantReal = 0; ConstantImg = 0;
                lenx = 3; leny = 3; lx = 0; ly = 0;
                Mouse_Down = false; Mouse_Up = false; rectangle = false;
                xs = 0; ys = 0; xe = 0; ye = 0;
                xzoom = 0; yzoom = 0;
                xstart = 0; ystart = 0; xend = 3; yend = 3;
                pl = 1;
                if (Mondelbrod) DrawFractal_MondelBrod();
            }
            if (Julia)
            {
                Constant = 4; ConstantReal = 0.28; ConstantImg = 0.0113;
                Red = 255; Green = 255; Blue = 255;
                RedBack = 12; GreenBack = 12; BlueBack = 0;
                lenx = 3; leny = 3; lx = 0; ly = 0;
                Mouse_Down = false; Mouse_Up = false; rectangle = false;
                xs = 0; ys = 0; xe = 0; ye = 0;
                xzoom = 0; yzoom = 0;
                xstart = 0; ystart = 0; xend = 3; yend = 3;
                action = true;
                pl = 1;
                DrawFractal_Julia();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void Draw_Click(object sender, EventArgs e)
        {
            if (Mondelbrod) DrawFractal_MondelBrod();
            if (Julia) DrawFractal_Julia();
        }

        private void juliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mondelbrod = false;
            Julia = true;
            Constant = 4; ConstantReal = 0.28; ConstantImg = 0.0113;
            Red = 255; Green = 255; Blue = 255;
            RedBack = 12; GreenBack = 12; BlueBack = 0;
            lenx = 3; leny = 3; lx = 0; ly = 0;
            Mouse_Down = false; Mouse_Up = false; rectangle = false;
            xs = 0; ys = 0; xe = 0; ye = 0;
            xzoom = 0; yzoom = 0;
            xstart = 0; ystart = 0; xend = 3; yend = 3;
            action = true;
            pl = 1;
            if (Mondelbrod) DrawFractal_MondelBrod();
            if (Julia) DrawFractal_Julia();

            textBox16.Text = ConstantReal.ToString();
            textBox15.Text = ConstantImg.ToString();
            textBox8.Text = Constant.ToString();
            action = false;
        }

        private void mondelbrodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mondelbrod = true;
            Julia = false;
            Constant = 2; ConstantReal = 0; ConstantImg = 0;
            Red = 255; Green = 255; Blue = 255;
            RedBack = 12; GreenBack = 12; BlueBack = 0;
            lenx = 3; leny = 3; lx = 0; ly = 0;
            Mouse_Down = false; Mouse_Up = false; rectangle = false;
            xs = 0; ys = 0; xe = 0; ye = 0;
            xzoom = 0; yzoom = 0;
            xstart = 0; ystart = 0; xend = 3; yend = 3;
            action = true;
            pl = 1;
            if (Mondelbrod) DrawFractal_MondelBrod();
            if (Julia) DrawFractal_Julia();

            textBox16.Text = ConstantReal.ToString();
            textBox15.Text = ConstantImg.ToString();
            textBox8.Text = Constant.ToString();
            action = false;
        }

        private void traclBarCnstReal_Scroll(object sender, EventArgs e)
        {
            ConstantReal=(double)traclBarCnstReal.Value / 5.0;
            textBox16.Text= ConstantReal.ToString();
        }

        private void trackBarCnstImg_Scroll(object sender, EventArgs e)
        {
            ConstantImg = (double)trackBarCnstImg.Value / 5.0;
            textBox15.Text = ConstantImg.ToString();
        }

        private void fractal1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fractal1 = true;
            DrawFractal1();

        }

        private void FractalPict_MouseMove(object sender, MouseEventArgs e)
        {
            xe = e.X;
            ye = e.Y;
            CordXY.Text = "X: " + xe + " Y: " + ye;
            textBox17.Text = "X:" + Math.Round(getRX(xe), 5); textBox18.Text = " Y:" + Math.Round(getRY(ye), 5);           
        }


        private void FractalPict_MouseDown(object sender, MouseEventArgs e)
        {
            if (!rectangle)
            {
                xstart = e.X; ystart = e.Y;
                rectangle = true;
            }
            xe = e.X; ye = e.Y;
        }

        private void FractalPict_MouseUp(object sender, MouseEventArgs e)
        {
            if (rectangle)
            {
                xend = e.X; yend = e.Y;
                Zoom();
                if (Mondelbrod) DrawFractal_MondelBrod();
                if (Julia) DrawFractal_Julia();
                rectangle = false;
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (action)
            {
                return;
            }
            if (int.TryParse(textBox4.Text, out int number))
            {
                Red = number;
                if (Mondelbrod) DrawFractal_MondelBrod();
                if (Julia) DrawFractal_Julia();
            }
            else if (textBox4.Text != "")
            {
                MessageBox.Show("Преобразование не удалось. Введенное значение не является числом.");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (action)
            {
                return;
            }
            if (int.TryParse(textBox7.Text, out int number))
            {
                Green = number;
                if (Mondelbrod) DrawFractal_MondelBrod();
                if (Julia) DrawFractal_Julia();
            }
            else if (textBox7.Text != "")
            {
                MessageBox.Show("Преобразование не удалось. Введенное значение не является числом.");
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (action)
            {
                return;
            }
            if (textBox16.Text == "") return;
            ConstantReal = Convert.ToDouble(textBox16.Text);
            if (Mondelbrod) DrawFractal_MondelBrod();
            if (Julia) DrawFractal_Julia();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (action)
            {
                return;
            }
            if (textBox15.Text == "") return;
            ConstantReal = Convert.ToDouble(textBox15.Text);
            if (Mondelbrod) DrawFractal_MondelBrod();
            if (Julia) DrawFractal_Julia();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (action)
            {
                return;
            }
            if (int.TryParse(textBox11.Text, out int number))
            {
                RedBack = number;
                if (Mondelbrod) DrawFractal_MondelBrod();
                if (Julia) DrawFractal_Julia();
            }
            else if (textBox11.Text != "")
            {
                MessageBox.Show("Преобразование не удалось. Введенное значение не является числом.");
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (action)
            {
                return;
            }
            if (int.TryParse(textBox9.Text, out int number))
            {
                GreenBack = number; 
                if (Mondelbrod) DrawFractal_MondelBrod();
                if (Julia) DrawFractal_Julia();
            }
            else if (textBox9.Text != "")
            {
                MessageBox.Show("Преобразование не удалось. Введенное значение не является числом.");
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (action)
            {
                return;
            }
            if (int.TryParse(textBox10.Text, out int number))
            {
                BlueBack = number;
                if (Mondelbrod) DrawFractal_MondelBrod();
                if (Julia) DrawFractal_Julia();
            }
            else if (textBox10.Text != "")
            {
                MessageBox.Show("Преобразование не удалось. Введенное значение не является числом.");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (action)
            {
                return;
            }
            if (int.TryParse(textBox6.Text, out int number))
            {
                Blue = number;
                if (Mondelbrod) DrawFractal_MondelBrod();
                if (Julia) DrawFractal_Julia();
            }
            else if (textBox6.Text != "")
            {
                MessageBox.Show("Преобразование не удалось. Введенное значение не является числом.");
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (action)
            {
                return;
            }
            if (textBox8.Text == "") return;
            Constant = Convert.ToDouble(textBox8.Text);
            if (Mondelbrod) DrawFractal_MondelBrod();
            if (Julia) DrawFractal_Julia();
        }

        private void CordXY_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox17_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void FractalPict_Click(object sender, EventArgs e)
        {

        }
        private void progressBarFractalDraw_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
        }

    }
}
