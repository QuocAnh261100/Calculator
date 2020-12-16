namespace calculator
{
    partial class Form1
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
            this.result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.switch_ = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.button_mul = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_equal = new System.Windows.Forms.Button();
            this.button_M = new System.Windows.Forms.Button();
            this.button_AC = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.screen = new System.Windows.Forms.TextBox();
            this.nroot = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quadraticFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cubeFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balan = new System.Windows.Forms.Button();
            this.button_x = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(12, 75);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(387, 58);
            this.result.TabIndex = 0;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.result.TextChanged += new System.EventHandler(this.screen_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.CausesValidation = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.CausesValidation = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(110, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 63);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.CausesValidation = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(208, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 63);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.CausesValidation = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 63);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button5.CausesValidation = false;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(110, 363);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 63);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button6.CausesValidation = false;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(208, 363);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 63);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button7.CausesValidation = false;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 431);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 63);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button8.CausesValidation = false;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(110, 431);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(93, 63);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button9.CausesValidation = false;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(208, 431);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(93, 63);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // switch_
            // 
            this.switch_.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.switch_.CausesValidation = false;
            this.switch_.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_.Location = new System.Drawing.Point(12, 499);
            this.switch_.Name = "switch_";
            this.switch_.Size = new System.Drawing.Size(93, 63);
            this.switch_.TabIndex = 10;
            this.switch_.Text = "√";
            this.switch_.UseVisualStyleBackColor = false;
            this.switch_.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button0.CausesValidation = false;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(110, 499);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(93, 63);
            this.button0.TabIndex = 11;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button_Click);
            // 
            // button_dot
            // 
            this.button_dot.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_dot.CausesValidation = false;
            this.button_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dot.Location = new System.Drawing.Point(208, 499);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(93, 63);
            this.button_dot.TabIndex = 12;
            this.button_dot.Text = ".";
            this.button_dot.UseVisualStyleBackColor = false;
            this.button_dot.Click += new System.EventHandler(this.button_comma_Click);
            // 
            // button_mul
            // 
            this.button_mul.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_mul.CausesValidation = false;
            this.button_mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mul.Location = new System.Drawing.Point(306, 295);
            this.button_mul.Name = "button_mul";
            this.button_mul.Size = new System.Drawing.Size(93, 63);
            this.button_mul.TabIndex = 13;
            this.button_mul.Text = "*";
            this.button_mul.UseVisualStyleBackColor = false;
            this.button_mul.Click += new System.EventHandler(this.operator_Click);
            // 
            // button_minus
            // 
            this.button_minus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_minus.CausesValidation = false;
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minus.Location = new System.Drawing.Point(306, 363);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(93, 63);
            this.button_minus.TabIndex = 14;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = false;
            this.button_minus.Click += new System.EventHandler(this.operator_Click);
            // 
            // button_plus
            // 
            this.button_plus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_plus.CausesValidation = false;
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plus.Location = new System.Drawing.Point(306, 431);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(93, 63);
            this.button_plus.TabIndex = 15;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = false;
            this.button_plus.Click += new System.EventHandler(this.operator_Click);
            // 
            // button_equal
            // 
            this.button_equal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_equal.CausesValidation = false;
            this.button_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_equal.Location = new System.Drawing.Point(308, 499);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(93, 63);
            this.button_equal.TabIndex = 16;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = false;
            this.button_equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // button_M
            // 
            this.button_M.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_M.CausesValidation = false;
            this.button_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_M.Location = new System.Drawing.Point(12, 227);
            this.button_M.Name = "button_M";
            this.button_M.Size = new System.Drawing.Size(93, 63);
            this.button_M.TabIndex = 17;
            this.button_M.Text = "M";
            this.button_M.UseVisualStyleBackColor = false;
            this.button_M.Click += new System.EventHandler(this.Save_Click);
            // 
            // button_AC
            // 
            this.button_AC.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_AC.CausesValidation = false;
            this.button_AC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AC.Location = new System.Drawing.Point(110, 227);
            this.button_AC.Name = "button_AC";
            this.button_AC.Size = new System.Drawing.Size(93, 63);
            this.button_AC.TabIndex = 18;
            this.button_AC.Text = "AC";
            this.button_AC.UseVisualStyleBackColor = false;
            this.button_AC.Click += new System.EventHandler(this.delete_all_Click);
            // 
            // button_C
            // 
            this.button_C.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_C.CausesValidation = false;
            this.button_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_C.Location = new System.Drawing.Point(208, 227);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(93, 63);
            this.button_C.TabIndex = 19;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = false;
            this.button_C.Click += new System.EventHandler(this.delete1_Click);
            // 
            // button_divide
            // 
            this.button_divide.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_divide.CausesValidation = false;
            this.button_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_divide.Location = new System.Drawing.Point(306, 227);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(93, 63);
            this.button_divide.TabIndex = 20;
            this.button_divide.Text = "/";
            this.button_divide.UseVisualStyleBackColor = false;
            this.button_divide.Click += new System.EventHandler(this.operator_Click);
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.SystemColors.Control;
            this.screen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.screen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screen.Location = new System.Drawing.Point(14, 43);
            this.screen.Name = "screen";
            this.screen.ReadOnly = true;
            this.screen.Size = new System.Drawing.Size(387, 20);
            this.screen.TabIndex = 21;
            this.screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.screen.TextChanged += new System.EventHandler(this.screen_TextChanged_1);
            // 
            // nroot
            // 
            this.nroot.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nroot.CausesValidation = false;
            this.nroot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nroot.Location = new System.Drawing.Point(109, 158);
            this.nroot.Name = "nroot";
            this.nroot.Size = new System.Drawing.Size(93, 63);
            this.nroot.TabIndex = 22;
            this.nroot.Text = "ⁿ√";
            this.nroot.UseVisualStyleBackColor = false;
            this.nroot.Click += new System.EventHandler(this.nroot_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(413, 30);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quadraticFunctionToolStripMenuItem,
            this.cubeFunctionToolStripMenuItem,
            this.linearToolStripMenuItem,
            this.drawToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quadraticFunctionToolStripMenuItem
            // 
            this.quadraticFunctionToolStripMenuItem.Name = "quadraticFunctionToolStripMenuItem";
            this.quadraticFunctionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quadraticFunctionToolStripMenuItem.Text = "Quadratic function";
            this.quadraticFunctionToolStripMenuItem.Click += new System.EventHandler(this.solve_pt2_Click);
            // 
            // cubeFunctionToolStripMenuItem
            // 
            this.cubeFunctionToolStripMenuItem.Name = "cubeFunctionToolStripMenuItem";
            this.cubeFunctionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cubeFunctionToolStripMenuItem.Text = "Cube function";
            this.cubeFunctionToolStripMenuItem.Click += new System.EventHandler(this.cubeFunctionToolStripMenuItem_Click);
            // 
            // linearToolStripMenuItem
            // 
            this.linearToolStripMenuItem.Name = "linearToolStripMenuItem";
            this.linearToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.linearToolStripMenuItem.Text = "2- Linear";
            this.linearToolStripMenuItem.Click += new System.EventHandler(this.linearToolStripMenuItem_Click);
            // 
            // drawToolStripMenuItem
            // 
            this.drawToolStripMenuItem.Name = "drawToolStripMenuItem";
            this.drawToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.drawToolStripMenuItem.Text = "Draw box ";
            this.drawToolStripMenuItem.Click += new System.EventHandler(this.drawToolStripMenuItem_Click);
            // 
            // balan
            // 
            this.balan.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.balan.CausesValidation = false;
            this.balan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balan.Location = new System.Drawing.Point(208, 158);
            this.balan.Name = "balan";
            this.balan.Size = new System.Drawing.Size(191, 63);
            this.balan.TabIndex = 24;
            this.balan.Text = "Balan style";
            this.balan.UseVisualStyleBackColor = false;
            this.balan.Click += new System.EventHandler(this.balan_Click);
            // 
            // button_x
            // 
            this.button_x.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_x.CausesValidation = false;
            this.button_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_x.Location = new System.Drawing.Point(14, 158);
            this.button_x.Name = "button_x";
            this.button_x.Size = new System.Drawing.Size(93, 63);
            this.button_x.TabIndex = 25;
            this.button_x.Text = "x";
            this.button_x.UseVisualStyleBackColor = false;
            this.button_x.Click += new System.EventHandler(this.button_x_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 581);
            this.Controls.Add(this.button_x);
            this.Controls.Add(this.balan);
            this.Controls.Add(this.nroot);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.button_C);
            this.Controls.Add(this.button_AC);
            this.Controls.Add(this.button_M);
            this.Controls.Add(this.button_equal);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_mul);
            this.Controls.Add(this.button_dot);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.switch_);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button switch_;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Button button_mul;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.Button button_M;
        private System.Windows.Forms.Button button_AC;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.TextBox screen;
        private System.Windows.Forms.Button nroot;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quadraticFunctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cubeFunctionToolStripMenuItem;
        private System.Windows.Forms.Button balan;
        private System.Windows.Forms.ToolStripMenuItem drawToolStripMenuItem;
        private System.Windows.Forms.Button button_x;
    }
}

