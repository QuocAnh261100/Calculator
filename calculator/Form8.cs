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
using AForge.Math;

namespace calculator
{
    public partial class Form8 : Form
    {
        TextBox[] tb_A;
        TextBox[] tb_B;
        TextBox[] tb_C;
        TextBox[] tb_D;
        Point point_A = new Point(0,0);
        Point point_B = new Point(0, 0);
        Point point_C = new Point(0, 0);
        Point point_D = new Point(0, 0);
        Vector3 A;
        Vector3 B;
        Vector3 C;
        Vector3 D;
        // bool[0]: a1, bool[1]: set_Z, bool[2]: done
        bool[] bool_A;
        bool[] bool_B;
        bool[] bool_C;
        bool[] bool_D;
        double epsilon = 5;
        List<Point> list_point;
        Point D_1;
        Point D_2;
        Point D_3;
        Point D_4;
        Vector3 vector_D_1;
        Vector3 vector_D_2;
        Vector3 vector_D_3;
        Vector3 vector_D_4;
        Stack<Point> S = new Stack<Point>();
        Point point;
        bool change = false;
        int count;
        Graphics graphics;
        public Form8()
        {
            InitializeComponent();
            graphics = panel1.CreateGraphics();
            tb_A = new TextBox[]{ textBox_Ax, textBox_Ay,textBox_Az};
            tb_B = new TextBox[] { textBox_Bx, textBox_By, textBox_Bz };
            tb_C = new TextBox[] { textBox_Cx, textBox_Cy, textBox_Cz };
            tb_D = new TextBox[] { textBox_Dx, textBox_Dy, textBox_Dz };
            bool_A = new bool[] {true,false,true };
            bool_B = new bool[] { true, false, true };
            bool_C = new bool[] { true, false, true };
            bool_D = new bool[] { true, false, true };
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        double distance(Point point_1, Point point_2)
        {
            return ((point_1.X - point_2.X) * (point_1.X - point_2.X) + (point_1.Y - point_2.Y) * (point_1.Y - point_2.Y));
        }
        void draw_paralleogram(Point p0, Point p1, Point p2, Point p3)
        {

            Brush brush = new SolidBrush(Color.Red);
            Pen pen = new Pen(brush, 4.0F);
            graphics.DrawLine(pen, p0.X, p0.Y, p1.X, p1.Y);
            graphics.DrawLine(pen, p2.X, p2.Y, p1.X, p1.Y);
            graphics.DrawLine(pen, p0.X, p0.Y, p3.X, p3.Y);
            graphics.DrawLine(pen, p2.X, p2.Y, p3.X, p3.Y);
        }

        List<Point> adjacent(Point point_choose)
        {
            List<Point> adjacent = new List<Point>(3);
            if (point_choose == point_A)
            {
                adjacent.Add(point_D);
                adjacent.Add(point_B);
                adjacent.Add(D_1);
            }
            else if (point_choose == point_B)
            {
                adjacent.Add(D_4);
                adjacent.Add(point_A);
                adjacent.Add(point_C);
            }
            else if (point_choose == point_C)
            {
                adjacent.Add(D_3);
                adjacent.Add(point_B);
                adjacent.Add(D_1);
            }
            else if (point_choose == point_D)
            {
                adjacent.Add(point_A);
                adjacent.Add(D_4);
                adjacent.Add(D_2);
            }
            else if (point_choose == D_1)
            {
                adjacent.Add(D_2);
                adjacent.Add(point_A);
                adjacent.Add(point_C);
            }
            else if (point_choose == D_2)
            {
                adjacent.Add(D_1);
                adjacent.Add(D_3);
                adjacent.Add(point_D);
            }
            else if (point_choose == D_3)
            {
                adjacent.Add(D_2);
                adjacent.Add(D_4);
                adjacent.Add(point_C);
            }
            else if (point_choose == D_4)
            {
                adjacent.Add(D_3);
                adjacent.Add(point_B);
                adjacent.Add(point_D);
            }
            return adjacent;
        }
        void draw_parallelogram_shape_box()
        {
            int i;
            int k = 0;
            Brush brush = new SolidBrush(Color.Red);
            Pen pen = new Pen(brush, 4.0F);
            Pen pen_1 = new Pen(Color.Black, 2.0F);
            pen_1.DashStyle = DashStyle.Dot;
            List<Point> list_point = new List<Point>(S);
            D_1 = new Point(point_C.X + point_A.X - point_B.X, point_C.Y + point_A.Y - point_B.Y);
            D_2 = new Point(D_1.X + point_D.X - point_A.X, D_1.Y + point_D.Y - point_A.Y);
            D_3 = new Point(point_C.X + D_2.X - D_1.X, point_C.Y + D_2.Y - D_1.Y);
            D_4 = new Point(point_B.X + D_3.X - point_C.X, point_B.Y + D_3.Y - point_C.Y);
            vector_D_1 = new Vector3(C.X + A.X - B.X, C.Y + A.Y - B.Y, C.Z + A.Z - B.Z);
            vector_D_2 = new Vector3(vector_D_1.X + D.X - A.X, vector_D_1.Y + D.Y - A.Y, vector_D_1.Z + D.Z - A.Z);
            vector_D_3 = new Vector3(C.X + vector_D_2.X - vector_D_1.X, C.Y + vector_D_2.Y - vector_D_1.Y, C.Z + vector_D_2.Z - vector_D_1.Z);
            vector_D_4 = new Vector3(B.X + vector_D_3.X - C.X, B.Y + vector_D_3.Y - C.Y, B.Z + vector_D_3.Z - C.Z);
            draw_paralleogram(point_A, point_B, point_C, D_1);
            draw_paralleogram(point_A, point_B, D_4, point_D);
            draw_paralleogram(D_3, D_2, point_D, D_4);
            draw_paralleogram(point_B, point_C, D_3, D_4);
            draw_paralleogram(point_C, D_3, D_2, D_1);
            draw_paralleogram(point_D, point_A, D_1, D_2);

            List<Point> list_point_1 = new List<Point> { point_A, point_B, point_C, point_D, D_1, D_2, D_3, D_4 };
            List<Point> adjacent_list;
            double angle1, angle2, angle3;
            for (i = 0; i < list_point_1.Count; i++)
            {
                adjacent_list = adjacent(list_point_1[i]);
                Vector3 vector1 = new Vector3(list_point_1[i].X - adjacent_list[0].X, list_point_1[i].Y - adjacent_list[0].Y, 0);
                Vector3 vector2 = new Vector3(list_point_1[i].X - adjacent_list[1].X, list_point_1[i].Y - adjacent_list[1].Y, 0);
                Vector3 vector3 = new Vector3(list_point_1[i].X - adjacent_list[2].X, list_point_1[i].Y - adjacent_list[2].Y, 0);
                angle1 = Math.Acos(Vector3.Dot(vector1, vector2) / ((Math.Sqrt(vector1.Square) * Math.Sqrt(vector2.Square))));
                angle2 = Math.Acos(Vector3.Dot(vector1, vector3) / ((Math.Sqrt(vector1.Square) * Math.Sqrt(vector3.Square))));
                angle3 = Math.Acos(Vector3.Dot(vector3, vector2) / ((Math.Sqrt(vector3.Square) * Math.Sqrt(vector2.Square))));
                if (Math.Round(angle1 + angle2 + angle3 - 2 * Math.PI, 6) == 0)
                {
                    Brush brush_white = new SolidBrush(Color.White);
                    Pen pen_white = new Pen(brush_white, 4.0F);
                    pen_white.DashStyle = DashStyle.Dot;
                    graphics.DrawLine(pen_white, list_point_1[i].X, list_point_1[i].Y, adjacent_list[0].X, adjacent_list[0].Y);
                    graphics.DrawLine(pen_white, list_point_1[i].X, list_point_1[i].Y, adjacent_list[1].X, adjacent_list[1].Y);
                    graphics.DrawLine(pen_white, list_point_1[i].X, list_point_1[i].Y, adjacent_list[2].X, adjacent_list[2].Y);
                    break;
                }
            }
            
            graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(point_A, new Size(7, 7)));
            graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(point_B, new Size(7, 7)));
            graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(point_C, new Size(7, 7)));
            graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(point_D, new Size(7, 7)));
        }
        private void init(ref Vector3 vector, ref Point point1, Point point2, ref bool[] bool_set, ref TextBox[] textbox_set)
        {
            if (!bool_set[2])
            {
                bool_set[1] = false;
                bool_set[0] = false;
                bool_set[2] = true;
                this.count = this.count + 1;
                S.Push(point1);
            }
            if (distance(point1, point2) <= epsilon*epsilon && bool_set[0])
            {
                bool_set[1] = true;
                bool_set[2] = false;
            }
            if (!bool_set[1])
            {
                if (bool_set[0])
                {
                    Brush brush2 = new SolidBrush(Color.White);
                    graphics.FillRectangle(brush2, new Rectangle(point1, new Size(7, 7)));
                    point1 = point2;
                    Brush brush1 = new SolidBrush(Color.Black);
                    graphics.FillRectangle(brush1, new Rectangle(point1, new Size(7, 7)));
                    textbox_set[0].Clear();
                    textbox_set[1].Clear();
                    vector.X = (float)((point1.X-316) * Math.Cos(Math.PI/6)-(point1.Y-254)*Math.Sin(Math.PI/6));
                    vector.Y = (float)((point1.X-316) * Math.Sin(Math.PI / 6) + (point1.Y -254)* Math.Cos(Math.PI / 6));
                    textbox_set[0].Text += Convert.ToString(vector.X);
                    textbox_set[1].Text += Convert.ToString(vector.Y);
                }
                //bool_set[0] = true;
            }
        }
        private void refmove(ref Point point, ref Vector3 vector, MouseEventArgs e)
        {
            Brush brush = new SolidBrush(Color.White);
            Brush brush1 = new SolidBrush(Color.Black);
            Pen pen_red = new Pen(brush);
            graphics.FillRectangle(brush, new Rectangle(point, new Size(7, 7)));
            point.Y = e.Location.Y;
            vector.Z = 254 - e.Location.Y ;
            if(point == point_A)
            {
                textBox_Az.Clear();
                textBox_Az.Text += Convert.ToString(vector.Z);
            }
            else if (point == point_B)
            {
                textBox_Bz.Clear();
                textBox_Bz.Text += Convert.ToString(vector.Z);
            }
            else if (point == point_C)
            {
                textBox_Cz.Clear();
                textBox_Cz.Text += Convert.ToString(vector.Z);
            }
            else if (point == point_D)
            {
                textBox_Dz.Clear();
                textBox_Dz.Text += Convert.ToString(vector.Z);
            }
            graphics.FillRectangle(brush1, new Rectangle(point, new Size(7, 7)));

        }
        private void changes(ref Vector3 vector, ref Point point1, Point point, ref TextBox[] textbox)
        {
            graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(point1, new Size(7, 7)));
            point1 = point;
            textbox[0].Clear();
            textbox[1].Clear();
            textbox[2].Clear();
            vector.X = (float)((point.X - 316) * Math.Cos(Math.PI / 6) - (point.Y - 254) * Math.Sin(Math.PI / 6));
            vector.Y = (float)((point.X - 316) * Math.Sin(Math.PI / 6) + (point.Y - 254) * Math.Cos(Math.PI / 6));
            vector.Z = 254 - point.Y;
            textbox[0].Text += Convert.ToString(A.X);
            textbox[1].Text += Convert.ToString(A.Y);
            textbox[2].Text += Convert.ToString(A.Z);
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            if (!change)
            {
                if (count < 4)
                {
                    point = ((MouseEventArgs)e).Location;
                    switch (count)
                    {
                        case 0:
                            init(ref A, ref point_A, point, ref bool_A, ref tb_A);
                            break;
                        case 1:
                            init(ref B, ref point_B, point, ref bool_B, ref tb_B);
                            break;
                        case 2:
                            init(ref C, ref point_C,point, ref bool_C, ref tb_C);
                            break;
                        case 3:
                            init(ref D, ref point_D, point, ref bool_D, ref tb_D);
                            break;
                    }
                    if (count == 4)
                        draw_parallelogram_shape_box();
                }
            }
            else
            {
                point = ((MouseEventArgs)e).Location;
                int k = 0;
                double min_distance = distance(point, point_A);
                list_point = new List<Point>(S);
                int i = 0;
                for (i = 0; i < 4; i++)
                {
                    if (min_distance > distance(point, list_point[i]))
                    {
                        min_distance = distance(point, list_point[i]);
                        k = i;
                    }
                }
                switch (k)
                {
                    case 0:
                        changes(ref A, ref point_A, point, ref tb_A);
                        break;
                    case 1:
                        changes(ref B, ref point_B, point, ref tb_B);
                        break;
                    case 2:
                        changes(ref C, ref point_C, point, ref tb_C);
                        break;
                    case 3:
                        changes(ref D, ref point_D, point, ref tb_D);
                        break;
                }
                panel1.Refresh();
                draw_parallelogram_shape_box();
            }
        }

        private void button_undo_Click(object sender, EventArgs e)
        {
            int length = S.Count;
            if (length > 0)
            {
                if(length == 1)
                    bool_A[0] = true;
                else if (length == 2)
                    bool_B[0] = true;
                else if (length == 3)
                    bool_C[0] = true;
                else if (length == 4)
                    bool_D[0] = true;
                point = S.Pop();
                graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(point, new Size(7, 7)));
                Brush brush = new SolidBrush(Color.Black);
                foreach (Point point in S)
                        graphics.FillRectangle(brush, new Rectangle(point, new Size(7, 7)));
            }
            if (count > 0)
                count = count - 1;
        }

        private void change_point_Click(object sender, EventArgs e)
        {
            change = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox_location.Clear();
            Point point = ((MouseEventArgs)e).Location;
            Graphics graphics = panel1.CreateGraphics();
            textBox_location.Text += point.X;
            textBox_location.Text += ",";
            textBox_location.Text += point.Y;
            if (bool_A[1])
                refmove(ref point_A, ref A, e);
            else if (bool_B[1])
                refmove(ref point_B, ref B, e);
            else if (bool_C[1])
                refmove(ref point_C, ref C, e);
            else if (bool_D[1])
                refmove(ref point_D, ref D, e);
        }

        private void draw_all_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
            change = false;
            while (S.Count > 0)
                S.Pop();
            count = 0;
            textBox_Ax.Clear();
            textBox_Ay.Clear();
            textBox_Az.Clear();
            textBox_Bx.Clear();
            textBox_By.Clear();
            textBox_Bz.Clear();
            textBox_Cx.Clear();
            textBox_Cy.Clear();
            textBox_Cz.Clear();
            textBox_Dx.Clear();
            textBox_Dy.Clear();
            textBox_Dz.Clear();
            bool_A[0] = true;
            bool_B[0] = true;
            bool_C[0] = true;
            bool_D[0] = true;
        }

        private void button_quit_change_Click(object sender, EventArgs e)
        {
            change = false;
        }
        double calculate_area(Vector3[] p1)
        {
            Vector3 x = new Vector3(p1[0].X - p1[1].X, p1[0].Y - p1[1].Y, p1[0].Z-p1[1].Z);
            Vector3 y = new Vector3(p1[0].X - p1[3].X, p1[0].Y - p1[3].Y, p1[0].Z-p1[3].Z);
            double area = Math.Sqrt(Vector3.Cross(x, y).Square);
            return Math.Round(area, 5);
        }
        private Vector3 convert_3D(Point point)
        {
            Vector3 vector = new Vector3();
            vector.X = (float)((point.X - 316) * Math.Cos(Math.PI / 6) - (point.Y - 254) * Math.Sin(Math.PI / 6));
            vector.Y = (float)((point.X - 316) * Math.Sin(Math.PI / 6) + (point.Y - 254) * Math.Cos(Math.PI / 6));
            vector.Z = 254 - point.Y;
            return vector;
        }
        private void button_calculate_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
            Point[] curve_point = new Point[] { point_A, point_B, point_C, D_1};
            Vector3[] curve_vector = new Vector3[] { A, B, C, vector_D_1 };
            textBox_area_1.Clear();
            textBox_area_1.Text += calculate_area(curve_vector);
            FillMode newFillMode = FillMode.Winding;
            graphics.FillPolygon(new SolidBrush(Color.YellowGreen), curve_point, newFillMode);
            draw_parallelogram_shape_box();
        }

        private void button_calculate_2_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
            Point[] curve_point = new Point[] { point_A, point_B, D_4, point_D };
            Vector3[] curve_vector = new Vector3[] { A, B, vector_D_4, D };
            textBox_area_2.Clear();
            textBox_area_2.Text += calculate_area(curve_vector);
            FillMode newFillMode = FillMode.Winding;
            graphics.FillPolygon(new SolidBrush(Color.Aquamarine), curve_point, newFillMode);
            draw_parallelogram_shape_box();
        }

        private void button_calculate_3_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
            Point[] curve_point = new Point[] { point_A, point_D, D_2, D_1 };
            Vector3[] curve_vector = new Vector3[] { A, D, vector_D_2, vector_D_1 };
            textBox_area_3.Clear();
            textBox_area_3.Text += calculate_area(curve_vector);
            FillMode newFillMode = FillMode.Winding;
            graphics.FillPolygon(new SolidBrush(Color.HotPink), curve_point, newFillMode);
            draw_parallelogram_shape_box();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                    string path = @"D:\graphics.png";
                    Bitmap bitmap = new Bitmap(this.Width, this.Height);
                    Graphics g = Graphics.FromImage(bitmap);
                    Rectangle rect = this.RectangleToScreen(this.ClientRectangle);
                    Point start = new Point(rect.X, rect.Y );
                    Size range = new Size(this.Width, this.Height);
                    g.CopyFromScreen(0,0,0,0,range);
                    bitmap.Save(path);
                this.WindowState = FormWindowState.Normal;
                MessageBox.Show("Image saved successfully.");
            }
            catch
            {
                MessageBox.Show("Error.....");
            }
        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void textBox_area_3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_volume_Click(object sender, EventArgs e)
        {
            Vector3 vector_AB = B - A;
            Vector3 vector_AD1 = vector_D_1 - A;
            Vector3 vector_AD = D - A;
            double volume = Math.Round(Math.Abs(Vector3.Dot(Vector3.Cross(vector_AB, vector_AD1),vector_AD)),5);
            textBox_volume.Clear();
            textBox_volume.Text += Convert.ToString(volume);
        }
    }
}
