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
    public partial class Form5 : Form
    {
        private Stack<string> S;
        private String P;
        private bool flag_equal = false;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (flag_equal == false)
                screen.Text += button.Text;
            else
            {
                screen.Clear();
                flag_equal = false;
            }
            screen.Focus();
            screen.SelectionStart = screen.Text.Length;
        }
        void solve()
        {
            double a;
            P = screen.Text;
            balan_calculator cal = new balan_calculator();
            Queue<string> context_string = cal.tokenizer(P);
            try
            {
                a = cal.calculate_sulfix(context_string);
            }
            catch(Exception){
                DialogResult x = MessageBox.Show("MATH ERROR");
                return;
            }
            
            P = Convert.ToString(a);
            result.Clear();
            result.Text += P;
        }
        void tokenizer(String screen_string)
        {
            String[] a = screen_string.Split();
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            this.solve();
            flag_equal = true;
            screen.Focus();
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            string temp = screen.Text;
            screen.Clear();
            for (int i = 0; i < temp.Length - 1; i++)
                screen.Text += temp[i];
        }

        private void button_off_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_del_Click_1(object sender, EventArgs e)
        {
            screen.Clear();
            result.Clear();
        }

        private void screen_TextChanged(object sender, EventArgs e)
        {
            if (screen.Text != "")
                P = screen.Text;
        }

        private void screen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter || e.KeyChar == '=')
                this.SelectNextControl((Control)sender, true, true, true, true);
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void result_TextChanged(object sender, EventArgs e)
        {
            
        }
        
    }
}
