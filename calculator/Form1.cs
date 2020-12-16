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
    public partial class Form1 : Form
    {
        private double result_cal;
        private double operand_1;
        private double save_value;
        private bool cont = true;
        private bool after_equal;
        private bool after_comma;
        private bool after_extract_the_root;
        private bool flag;
        String operationperform = "";
        private void opcode(String operators)
        {
            if (operators == "/")
                result_cal = (result_cal / operand_1);
            else if (operators == "*")
                result_cal = (result_cal * operand_1);
            else if (operators == "-")
                result_cal = (result_cal - operand_1);
            else if (operators == "+")
                result_cal = (result_cal + operand_1);
            else if (operators == "SQRT")
                result_cal = Math.Sqrt(result_cal);
            else if (operationperform == "nroot")
                result_cal = Math.Pow(result_cal, 1/operand_1);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void screen_TextChanged(object sender, EventArgs e)
        {
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (cont)
                result.Text = result.Text + button.Text;
            else
            {
                result.Clear();
                cont = true;
                result.Text = result.Text + button.Text;
            }
        }

        private void operator_Click(object sender, EventArgs e)
        {
            after_comma = false;
            cont = false;
            Button button = (Button)sender;
            if (after_equal)
                screen.Clear();
            if (after_extract_the_root)
                screen.Clear();
            if (result.Text != "" && screen.Text != "")
            {
                screen.Text = screen.Text + result.Text;
                operand_1 = Convert.ToDouble(result.Text);
                opcode(operationperform);
                operationperform = button.Text;
                result.Clear();
                result.Text = result.Text + Convert.ToString(result_cal);
                screen.Text = screen.Text + button.Text;
            }
            else if (result.Text != "" && screen.Text == "")
            {
                result_cal = Convert.ToDouble(result.Text);
                screen.Text = screen.Text + result.Text;
                screen.Text = screen.Text + button.Text;
                operationperform = button.Text;
                after_equal = false;
                after_extract_the_root = false;
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (!after_extract_the_root)
            {
                screen.Text = screen.Text + result.Text;
                screen.Text = screen.Text + "=";
                operand_1 = Convert.ToDouble(result.Text);
                opcode(operationperform);
                result.Clear();
                result.Text = result.Text + Convert.ToString(result_cal);
               
            }
            else
            {
                if (flag)
                {
                    operand_1 = Convert.ToDouble(result.Text);
                    flag = false;
                    result.Clear();
                    screen.Clear();
                    screen.Text = screen.Text + "Enter the element (press = to finish): ";
                }
                else
                {
                    result_cal = Convert.ToDouble(result.Text);
                    screen.Clear();
                    screen.Text = screen.Text + Convert.ToString(operand_1);
                    screen.Text = screen.Text + "-root ";
                    screen.Text = screen.Text + Convert.ToString(result_cal);
                    opcode(operationperform);
                    result.Clear();
                    result.Text = result.Text + Convert.ToString(result_cal);
                    after_extract_the_root = false;
         
                }  
            }
            after_equal = true;
            cont = false;
        }

        private void button_comma_Click(object sender, EventArgs e)
        {
            if (!after_comma)
            if (!after_comma)
            if (!after_comma)
                        result.Text = result.Text + ".";
            after_comma = true;
        }

        private void delete1_Click(object sender, EventArgs e)
        {
            String temp = result.Text;
            result.Clear();
            for (int i = 0; i < temp.Length - 1; i++)
            {
                result.Text = result.Text + temp[i];
            }
        }

        private void delete_all_Click(object sender, EventArgs e)
        {
            result.Clear();
            screen.Clear();
            operationperform = "";
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            if (screen.Text == "")
            {
                result_cal = Math.Sqrt(Convert.ToDouble(result.Text));
                screen.Text = screen.Text + "sqrt(";
                screen.Text = screen.Text + result.Text;
                screen.Text = screen.Text + ")";
                operationperform = "SQRT";
                result.Clear();
                result.Text = result.Text + Convert.ToString(result_cal);
            }
            else
            {
                operand_1 = Math.Sqrt(Convert.ToDouble(result.Text));
                screen.Clear();
                screen.Text = screen.Text + "sqrt(";
                screen.Text = screen.Text + result.Text;
                screen.Text = screen.Text + ")";
                opcode(operationperform);
                operationperform = "SQRT";
                result.Clear();
                result.Text = result.Text + Convert.ToString(result_cal);
            }
            after_extract_the_root = true;
        }

        private void screen_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void nroot_Click(object sender, EventArgs e)
        {
            flag = true;
            screen.Clear();
            result.Clear();
            after_extract_the_root = true;
            operationperform = "nroot";
            screen.Text = screen.Text + "Enter the n-root (press = to finish): ";
            
        }

        private void solve_pt2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void linearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void cubeFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void balan_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void drawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            save_value = Convert.ToDouble(result.Text);
        }

        private void button_x_Click(object sender, EventArgs e)
        {
            if (cont)
                result.Text = result.Text + Convert.ToString(save_value);
            else
            {
                result.Clear();
                cont = true;
                result.Text = result.Text + Convert.ToString(save_value);
            }
        }
    }
}
