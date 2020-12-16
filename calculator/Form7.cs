using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace calculator
{
    public partial class Form7 : Form
    {
        Point point_1 = new Point(400, 365);
        Point point_2 = new Point(400, 125);
        Point point_3 = new Point(555, 450);
        Point point_4 = new Point(245, 450);
        Point point_5 = new Point(245, 290);
        Point point_6 = new Point(555, 290);
        Point point_A;
        Point point_B;
        Point point_C;
        Point point_D;
        Stack<Point> S = new Stack<Point>();
        Point point;
        bool flag_create_parallelogram_shape_box = false;
        bool reset = false;
        Graphics graphics;
        int count;
        public Form7()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
        double distance(Point point_1, Point point_2)
        {
            return ((point_1.X - point_2.X)* (point_1.X - point_2.X) + (point_1.Y - point_2.Y) * (point_1.Y - point_2.Y));
        }
        void draw_paralleogram(Point p0, Point p1, Point p2, Point p3)
        {
            
            Brush brush = new SolidBrush(Color.Red);
            Pen pen = new Pen(brush);
            graphics.DrawLine(pen, p0.X, p0.Y, p1.X, p1.Y);
            graphics.DrawLine(pen, p2.X, p2.Y, p1.X, p1.Y);
            graphics.DrawLine(pen, p0.X, p0.Y, p3.X, p3.Y);
            graphics.DrawLine(pen, p2.X, p2.Y, p3.X, p3.Y);
        }
        void draw_parallelogram_shape_box()
        {
            
            Brush brush = new SolidBrush(Color.Red);
            Pen pen = new Pen(brush);
            Point[] xoy = new Point[3];
            Point point_choose = point_A;
            int min_p = point_A.Y;
            int[] y_axis = { point_A.Y, point_B.Y, point_C.Y, point_D.Y };
            for(int i = 0; i < 4; i++)
            {
                
                if (min_p > y_axis[i])
                    min_p = y_axis[i];
            }
            if (min_p == point_A.Y)
                point_choose = point_A;
            else if (min_p == point_B.Y)
                point_choose = point_B;
            else if (min_p == point_C.Y)
                point_choose = point_C;
            else if (min_p == point_D.Y)
                point_choose = point_D;
            int j = 0;
            while(S.Count > 0)
            {
                if (S.Peek() == point_choose)
                    S.Pop();
                else
                {
                    xoy[j] = S.Pop();
                    j = j + 1;
                }
            }
            Point point_D_1 = new Point(xoy[0].X+xoy[2].X-xoy[1].X, xoy[0].Y + xoy[2].Y- xoy[1].Y);
            draw_paralleogram(xoy[0],xoy[1],xoy[2],point_D_1);
            Point point_D_2 = new Point(xoy[1].X + point_choose.X - xoy[0].X, xoy[1].Y + point_choose.Y - xoy[0].Y);
            draw_paralleogram(xoy[0], xoy[1],point_D_2,point_choose);
            Point point_D_3 = new Point(xoy[2].X + point_D_2.X - xoy[1].X, xoy[2].Y + point_D_2.Y - xoy[1].Y);
            draw_paralleogram(xoy[2], xoy[1], point_D_2, point_D_3);
            Point point_D_4 = new Point(point_D_1.X + point_choose.X - xoy[0].X, point_D_1.Y + point_choose.Y - xoy[0].Y);
            draw_paralleogram(point_D_1, xoy[0], point_choose, point_D_4);
            graphics.DrawLine(new Pen(brush), point_D_4.X, point_D_4.Y, point_D_3.X, point_D_3.Y);
            }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (count < 4)
            {


                point = ((MouseEventArgs)e).Location;
                switch (count)
                {
                    case 0:
                        point_A = point;
                        break;
                    case 1:
                        point_B = point;
                        break;
                    case 2:
                        point_C = point;
                        break;
                    case 3:
                        point_D = point;
                        break;
                }
                
                Brush brush = new SolidBrush(Color.Red);
                graphics.FillRectangle(brush, new Rectangle(point, new Size(10, 10)));
                S.Push(point);
                count = count + 1;
                if (count == 4)
                    draw_parallelogram_shape_box();
            }

        }
        
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox_location.Clear();
            Point point = ((MouseEventArgs)e).Location;
            Graphics graphics = pictureBox1.CreateGraphics();
            textBox_location.Text += point.X;
            textBox_location.Text += ",";
            textBox_location.Text += point.Y;
        }

        private void draw_all_Click(object sender, EventArgs e)
        {
            flag_create_parallelogram_shape_box = true;
            count = 0;
        }

        private void button_undo_Click(object sender, EventArgs e)
        {
           
            if (S.Count > 0)
                point = S.Pop();
            graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(point, new Size(10, 10)));
            if (count > 0)
                count = count - 1;
        }
    }
}
