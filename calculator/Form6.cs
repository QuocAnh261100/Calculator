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
    public partial class Form6 : Form
    {
        Point point_1 = new Point(320, 295);
        Point point_2 = new Point(320, 100);
        Point point_3 = new Point(442, 360);
        Point point_4 = new Point(198, 360);
        Point point_5 = new Point(198, 230);
        Point point_6 = new Point(442, 230);
        Point point_A;
        Point point_B;
        Point point_C;
        Point point_D;
        Stack<Point> S = new Stack<Point>();
        Point point;
        bool flag_create_parallelogram_shape_box = false;
        bool reset = false;
        int count;
        Graphics graphics;
        public Form6()
        {
            InitializeComponent();
            graphics = panel1.CreateGraphics();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
            
            Brush brush = new SolidBrush(Color.Black);
            Pen pen_1 = new Pen(Color.Black,2.0F);
            pen_1.DashStyle = DashStyle.Dot;
            Pen pen = new Pen(brush,2.0F);
            graphics.DrawLine(pen,point_1.X,point_1.Y,point_2.X,point_2.Y);
            graphics.DrawLine(pen, point_1.X, point_1.Y, point_3.X, point_3.Y);
            graphics.DrawLine(pen, point_1.X, point_1.Y, point_4.X, point_4.Y);
            graphics.DrawLine(pen_1, point_1.X, point_1.Y, point_5.X, point_5.Y);
            graphics.DrawLine(pen_1, point_1.X, point_1.Y, point_6.X, point_6.Y);
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
            for (int i = 0; i < 4; i++)
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
            while (S.Count > 0)
            {
                if (S.Peek() == point_choose)
                    S.Pop();
                else
                {
                    xoy[j] = S.Pop();
                    j = j + 1;
                }
            }
            Point point_D_1 = new Point(point_A.X + point_C.X - point_B.X, point_A.Y + point_C.Y - point_B.Y);
            draw_paralleogram(point_A, point_B, point_C, point_D_1);
            Point point_D_2 = new Point(xoy[1].X + point_choose.X - xoy[0].X, xoy[1].Y + point_choose.Y - xoy[0].Y);
            draw_paralleogram(xoy[0], xoy[1], point_D_2, point_choose);
            Point point_D_3 = new Point(xoy[2].X + point_D_2.X - xoy[1].X, xoy[2].Y + point_D_2.Y - xoy[1].Y);
            draw_paralleogram(xoy[2], xoy[1], point_D_2, point_D_3);
            Point point_D_4 = new Point(point_D_1.X + point_choose.X - xoy[0].X, point_D_1.Y + point_choose.Y - xoy[0].Y);
            draw_paralleogram(point_D_1, xoy[0], point_choose, point_D_4);
            graphics.DrawLine(new Pen(brush), point_D_4.X, point_D_4.Y, point_D_3.X, point_D_3.Y);
        }
        private void panel_click(object sender, EventArgs e)
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
                    graphics.FillRectangle(brush, new Rectangle(point, new Size(4, 4)));
                    S.Push(point);
                    count = count + 1;
                if (count == 4)
                    draw_parallelogram_shape_box();
            }
            
        }

        private void panel1_LocationChanged(object sender, EventArgs e)
        {
           
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox_location.Clear();
            Point point = ((MouseEventArgs)e).Location;
            Graphics graphics = panel1.CreateGraphics();
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
            {
                point = S.Pop();
                graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(point, new Size(4, 4)));
                List<Point> new_list = new List<Point>(S);
                Brush brush = new SolidBrush(Color.Black);
                Brush brush_1 = new SolidBrush(Color.Red);
                Pen pen_1 = new Pen(Color.Black, 2.0F);
                pen_1.DashStyle = DashStyle.Dot;
                Pen pen = new Pen(brush, 2.0F);
                graphics.DrawLine(pen, point_1.X, point_1.Y, point_2.X, point_2.Y);
                graphics.DrawLine(pen, point_1.X, point_1.Y, point_3.X, point_3.Y);
                graphics.DrawLine(pen, point_1.X, point_1.Y, point_4.X, point_4.Y);
                graphics.DrawLine(pen_1, point_1.X, point_1.Y, point_5.X, point_5.Y);
                graphics.DrawLine(pen_1, point_1.X, point_1.Y, point_6.X, point_6.Y);
                for(int k=0;k<S.Count;k++)
                    graphics.FillRectangle(brush_1, new Rectangle(new_list[k], new Size(4, 4)));
            }
            if(count > 0)
                count = count - 1;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
