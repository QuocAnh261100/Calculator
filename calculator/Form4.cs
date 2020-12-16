using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using MathNet.Numerics;

namespace calculator
{
    public partial class Form4 : Form
    {
        private double a;
        private double b;
        private double c;
        private double d;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void key_press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                //this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        void solve()
        {
            try
            {
                a = double.Parse(a_textbox.Text);
                b = double.Parse(b_textbox.Text);
                c = double.Parse(c_textbox.Text);
                d = double.Parse(d_textbox.Text);
                var roots = FindRoots.Cubic(d, c, b, a);
                Complex root1 = roots.Item1;
                Complex root2 = roots.Item2;
                Complex root3 = roots.Item3;
                if (root1 == root2 && root2 == root3)
                {
                    textBox_result.Text = "Phương trình có duy nhất nghiệm:";
                    root_1.Text += (Math.Round(root1.Real,4).ToString() + "+(" + Math.Round(root1.Imaginary,4).ToString() + "i)");
                }
                else
                {
                    textBox_result.Text = "Phương trình có 3 nghiệm phân biệt:";
                    root_1.Text += (Math.Round(root1.Real,4).ToString() + "+(" + Math.Round(root1.Imaginary,4).ToString() + "i)");
                    root_2.Text += (Math.Round(root2.Real,4).ToString() + "+(" + Math.Round(root2.Imaginary,4).ToString() + "i)");
                    root_3.Text += (Math.Round(root3.Real,4).ToString() + "+(" + Math.Round(root3.Imaginary,4).ToString() + "i)");
                }
            }
            catch (Exception)
            {
                textBox_result.Clear();
                textBox_result.Text += "Math error";
            }
        }

        private void button_solve_Click(object sender, EventArgs e)
        {
            this.solve();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
    }
}
