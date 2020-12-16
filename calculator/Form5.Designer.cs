namespace calculator
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.screen = new System.Windows.Forms.TextBox();
            this.button_divide = new System.Windows.Forms.Button();
            this.button_equal = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_mul = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.button_del_all = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.button_off = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.SystemColors.Control;
            this.screen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screen.Location = new System.Drawing.Point(28, 44);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(387, 19);
            this.screen.TabIndex = 1;
            this.screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.screen.TextChanged += new System.EventHandler(this.screen_TextChanged);
            this.screen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.screen_KeyPress);
            // 
            // button_divide
            // 
            this.button_divide.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_divide.Location = new System.Drawing.Point(322, 161);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(93, 63);
            this.button_divide.TabIndex = 45;
            this.button_divide.Text = "/";
            this.button_divide.UseVisualStyleBackColor = false;
            this.button_divide.Click += new System.EventHandler(this.button_click);
            // 
            // button_equal
            // 
            this.button_equal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_equal.Location = new System.Drawing.Point(322, 434);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(91, 132);
            this.button_equal.TabIndex = 2;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = false;
            this.button_equal.Click += new System.EventHandler(this.button_equal_Click);
            // 
            // button_plus
            // 
            this.button_plus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plus.Location = new System.Drawing.Point(322, 365);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(93, 63);
            this.button_plus.TabIndex = 40;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = false;
            this.button_plus.Click += new System.EventHandler(this.button_click);
            // 
            // button_minus
            // 
            this.button_minus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minus.Location = new System.Drawing.Point(322, 299);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(93, 63);
            this.button_minus.TabIndex = 39;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = false;
            this.button_minus.Click += new System.EventHandler(this.button_click);
            // 
            // button_mul
            // 
            this.button_mul.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mul.Location = new System.Drawing.Point(322, 230);
            this.button_mul.Name = "button_mul";
            this.button_mul.Size = new System.Drawing.Size(93, 63);
            this.button_mul.TabIndex = 38;
            this.button_mul.Text = "*";
            this.button_mul.UseVisualStyleBackColor = false;
            this.button_mul.Click += new System.EventHandler(this.button_click);
            // 
            // button_dot
            // 
            this.button_dot.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dot.Location = new System.Drawing.Point(221, 502);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(93, 63);
            this.button_dot.TabIndex = 37;
            this.button_dot.Text = ".";
            this.button_dot.UseVisualStyleBackColor = false;
            this.button_dot.Click += new System.EventHandler(this.button_click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(26, 502);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(189, 63);
            this.button0.TabIndex = 36;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button_click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(223, 434);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(93, 63);
            this.button9.TabIndex = 34;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(124, 434);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(93, 63);
            this.button8.TabIndex = 33;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(26, 434);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 63);
            this.button7.TabIndex = 32;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(221, 365);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 63);
            this.button6.TabIndex = 31;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(124, 366);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 63);
            this.button5.TabIndex = 30;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(26, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 63);
            this.button4.TabIndex = 29;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(221, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 63);
            this.button3.TabIndex = 28;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(125, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 63);
            this.button2.TabIndex = 27;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 63);
            this.button1.TabIndex = 26;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_click);
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(28, 76);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(387, 57);
            this.result.TabIndex = 25;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // button_del_all
            // 
            this.button_del_all.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_del_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_del_all.Location = new System.Drawing.Point(28, 230);
            this.button_del_all.Name = "button_del_all";
            this.button_del_all.Size = new System.Drawing.Size(93, 63);
            this.button_del_all.TabIndex = 50;
            this.button_del_all.Text = "C";
            this.button_del_all.UseVisualStyleBackColor = false;
            this.button_del_all.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_del
            // 
            this.button_del.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_del.Location = new System.Drawing.Point(124, 229);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(93, 63);
            this.button_del.TabIndex = 51;
            this.button_del.Text = "AC";
            this.button_del.UseVisualStyleBackColor = false;
            this.button_del.Click += new System.EventHandler(this.button_del_Click_1);
            // 
            // button_off
            // 
            this.button_off.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_off.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_off.Location = new System.Drawing.Point(26, 161);
            this.button_off.Name = "button_off";
            this.button_off.Size = new System.Drawing.Size(93, 63);
            this.button_off.TabIndex = 52;
            this.button_off.Text = "OFF";
            this.button_off.UseVisualStyleBackColor = false;
            this.button_off.Click += new System.EventHandler(this.button_off_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(223, 160);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(93, 63);
            this.button10.TabIndex = 53;
            this.button10.Text = ")";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button_click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(221, 230);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(93, 63);
            this.button12.TabIndex = 55;
            this.button12.Text = "^";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button_click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(125, 161);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(93, 63);
            this.button11.TabIndex = 56;
            this.button11.Text = "(";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button_click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 586);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button_off);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_del_all);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.button_equal);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_mul);
            this.Controls.Add(this.button_dot);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Name = "Form5";
            this.Text = "Form5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox screen;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_mul;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button button_del_all;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_off;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
    }
}