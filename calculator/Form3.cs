using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form3 : Form
    {
        private double a;
        private double b;
        private double c;
        private double d;
        private double m;
        private double n;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void text_click(object sender, EventArgs e)
        {
            
        }

        private void text_click_a(object sender, EventArgs e)
        {

        }

        void solve()
        {
            try
            {
                a = Double.Parse(a_coeff.Text);
                b = Double.Parse(b_coeff.Text);
                c = Double.Parse(c_coeff.Text);
                d = Double.Parse(d_coeff.Text);
                m = Double.Parse(m_coeff.Text);
                n = Double.Parse(n_coeff.Text);
                if ((a*d == b*c) && (a*n == m*c))
                {
                    x1_text.Clear();
                    x2_text.Clear();
                    textBox_result.Clear();
                    textBox_result.Text += "Phương trình vô số nghiệm";
                }
                else if ((a*d == b * c) && (a * n != c * m)){
                    x1_text.Clear();
                    x2_text.Clear();
                    textBox_result.Clear();
                    textBox_result.Text += "Phương trình vô nghiệm";
                }
                else
                {
                    double x1, x2;
                    x1 = (c * m - a * n) / (c * b - a * d);
                    x2 = (m - a * x1) / b;
                    x1_text.Clear();
                    x2_text.Clear();
                    x1_text.Text += Convert.ToString(Math.Round(x1, 4));
                    x2_text.Text += Convert.ToString(Math.Round(x2, 4));
                    textBox_result.Clear();
                    textBox_result.Text += "Phương trình có nghiệm";
                }
            }
            catch (Exception)
            {
                //  DialogResult result = MessageBox.Show("Math error");
                textBox_result.Clear();
                textBox_result.Text += "Math error";

            }
        }
        private void key_press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //SendKeys.Send("{TAB}");
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.solve();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
    }
}
