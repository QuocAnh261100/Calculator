using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Math;

namespace calculator
{
    public partial class Form2 : Form
    {
        
        private double a;
        private double b;
        private double c;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void a_coeff_TextChanged(object sender, EventArgs e)
        {
            
            
            if (a_coeff.Text != "")
                double.TryParse(a_coeff.Text, out a);
            else
                a = 0;
        }

        private void b_coeff_TextChanged(object sender, EventArgs e)
        {
            
            if (b_coeff.Text != "")
                double.TryParse(b_coeff.Text, out b);
            else
                b = 0;
        }

        private void c_coeff_TextChanged(object sender, EventArgs e)
        {
            
           
            if (c_coeff.Text != "")
                double.TryParse(c_coeff.Text, out c);
            else
                c = 0;
        }

        void solve()
        {
            show_result_2.Clear();
            if (a == 0)
            {
                if (b != 0)
                {
                    root_1.Clear();
                    root_2.Clear();
                    root_1.Text = root_1.Text + Convert.ToString(Math.Round(-c / b,4));
                    show_result_2.Text += "Phương trình có 1 nghiệm duy nhất";
;
                }   
                else
                {
                    root_1.Clear();
                    root_2.Clear();
                    root_1.Text = root_1.Text + "No solution";
                    root_2.Text = root_2.Text + "No solution";
                    show_result_2.Text += "Phương trình vô nghiệm";
                }
                
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if(delta >= 0)
                {
                    double x1, x2;
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    root_1.Clear();
                    root_1.Text = root_1.Text + Convert.ToString(Math.Round(x1,4));
                    root_2.Clear();
                    root_2.Text = root_2.Text + Convert.ToString(Math.Round(x2,4));
                    if (delta == 0)
                        show_result_2.Text += "Phương trình có nghiệm kép";
                    else
                        show_result_2.Text += "Phương trình có 2 nghiệm phân biệt";
                }
                else
                {
                    AForge.Math.Complex x1;
                    AForge.Math.Complex delta_1 = new AForge.Math.Complex(delta, 0);
                    x1 = (-b + AForge.Math.Complex.Sqrt(delta_1)) / (2 * a);
                    root_1.Clear();
                    
                    root_1.Text = root_1.Text + Convert.ToString(Math.Round(x1.Re,4));
                    if (x1.Im > 0)
                        root_1.Text = root_1.Text + "+";
                    root_1.Text = root_1.Text + Convert.ToString(Math.Round(x1.Im,4));
                    root_1.Text = root_1.Text + "*i";
                    root_2.Clear();
                    root_2.Text = root_2.Text + Convert.ToString(Math.Round(x1.Re,4));
                    if (x1.Im < 0)
                        root_2.Text = root_1.Text + "+";
                    root_2.Text = root_2.Text + Convert.ToString(Math.Round(-x1.Im,4));
                    root_2.Text = root_2.Text + "*i";
                    show_result_2.Text += "Phương trình có 2 nghiệm phân biệt";
                }
                
            }
        }
         

        private void key_press(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                //SendKeys.Send("{TAB}");
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void Solve_click(object sender, EventArgs e)
        {
            this.solve();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();

        }
    }
}
