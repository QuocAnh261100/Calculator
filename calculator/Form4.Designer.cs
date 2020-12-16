namespace calculator
{
    partial class Form4
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
            this.a_textbox = new System.Windows.Forms.TextBox();
            this.d_textbox = new System.Windows.Forms.TextBox();
            this.c_textbox = new System.Windows.Forms.TextBox();
            this.b_textbox = new System.Windows.Forms.TextBox();
            this.root_1 = new System.Windows.Forms.TextBox();
            this.root_3 = new System.Windows.Forms.TextBox();
            this.root_2 = new System.Windows.Forms.TextBox();
            this.button_solve = new System.Windows.Forms.Button();
            this.a_coeff = new System.Windows.Forms.Label();
            this.b_coeff = new System.Windows.Forms.Label();
            this.c_coeff = new System.Windows.Forms.Label();
            this.d_coeff = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // a_textbox
            // 
            this.a_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_textbox.Location = new System.Drawing.Point(165, 63);
            this.a_textbox.Name = "a_textbox";
            this.a_textbox.Size = new System.Drawing.Size(146, 36);
            this.a_textbox.TabIndex = 0;
            this.a_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press);
            // 
            // d_textbox
            // 
            this.d_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_textbox.Location = new System.Drawing.Point(542, 125);
            this.d_textbox.Name = "d_textbox";
            this.d_textbox.Size = new System.Drawing.Size(146, 36);
            this.d_textbox.TabIndex = 3;
            this.d_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press);
            // 
            // c_textbox
            // 
            this.c_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_textbox.Location = new System.Drawing.Point(165, 123);
            this.c_textbox.Name = "c_textbox";
            this.c_textbox.Size = new System.Drawing.Size(146, 36);
            this.c_textbox.TabIndex = 2;
            this.c_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press);
            // 
            // b_textbox
            // 
            this.b_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_textbox.Location = new System.Drawing.Point(542, 61);
            this.b_textbox.Name = "b_textbox";
            this.b_textbox.Size = new System.Drawing.Size(146, 36);
            this.b_textbox.TabIndex = 1;
            this.b_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press);
            // 
            // root_1
            // 
            this.root_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.root_1.Location = new System.Drawing.Point(174, 271);
            this.root_1.Name = "root_1";
            this.root_1.Size = new System.Drawing.Size(223, 36);
            this.root_1.TabIndex = 5;
            // 
            // root_3
            // 
            this.root_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.root_3.Location = new System.Drawing.Point(174, 383);
            this.root_3.Name = "root_3";
            this.root_3.Size = new System.Drawing.Size(223, 36);
            this.root_3.TabIndex = 6;
            // 
            // root_2
            // 
            this.root_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.root_2.Location = new System.Drawing.Point(174, 331);
            this.root_2.Name = "root_2";
            this.root_2.Size = new System.Drawing.Size(223, 36);
            this.root_2.TabIndex = 7;
            // 
            // button_solve
            // 
            this.button_solve.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_solve.Location = new System.Drawing.Point(575, 306);
            this.button_solve.Name = "button_solve";
            this.button_solve.Size = new System.Drawing.Size(137, 106);
            this.button_solve.TabIndex = 4;
            this.button_solve.Text = "SOLVE";
            this.button_solve.UseVisualStyleBackColor = true;
            this.button_solve.Click += new System.EventHandler(this.button_solve_Click);
            this.button_solve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press);
            // 
            // a_coeff
            // 
            this.a_coeff.AutoSize = true;
            this.a_coeff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_coeff.Location = new System.Drawing.Point(103, 66);
            this.a_coeff.Name = "a_coeff";
            this.a_coeff.Size = new System.Drawing.Size(56, 29);
            this.a_coeff.TabIndex = 9;
            this.a_coeff.Text = "a = ";
            // 
            // b_coeff
            // 
            this.b_coeff.AutoSize = true;
            this.b_coeff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_coeff.Location = new System.Drawing.Point(487, 66);
            this.b_coeff.Name = "b_coeff";
            this.b_coeff.Size = new System.Drawing.Size(49, 29);
            this.b_coeff.TabIndex = 10;
            this.b_coeff.Text = "b =";
            this.b_coeff.Click += new System.EventHandler(this.label2_Click);
            // 
            // c_coeff
            // 
            this.c_coeff.AutoSize = true;
            this.c_coeff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_coeff.Location = new System.Drawing.Point(103, 125);
            this.c_coeff.Name = "c_coeff";
            this.c_coeff.Size = new System.Drawing.Size(48, 29);
            this.c_coeff.TabIndex = 11;
            this.c_coeff.Text = "c =";
            // 
            // d_coeff
            // 
            this.d_coeff.AutoSize = true;
            this.d_coeff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_coeff.Location = new System.Drawing.Point(480, 132);
            this.d_coeff.Name = "d_coeff";
            this.d_coeff.Size = new System.Drawing.Size(56, 29);
            this.d_coeff.TabIndex = 12;
            this.d_coeff.Text = "d = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "x1 =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "x2 =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(107, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "x3 =";
            // 
            // textBox_result
            // 
            this.textBox_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_result.Location = new System.Drawing.Point(51, 193);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(682, 36);
            this.textBox_result.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Press Enter to continue";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.d_coeff);
            this.Controls.Add(this.c_coeff);
            this.Controls.Add(this.b_coeff);
            this.Controls.Add(this.a_coeff);
            this.Controls.Add(this.button_solve);
            this.Controls.Add(this.root_2);
            this.Controls.Add(this.root_3);
            this.Controls.Add(this.root_1);
            this.Controls.Add(this.b_textbox);
            this.Controls.Add(this.c_textbox);
            this.Controls.Add(this.d_textbox);
            this.Controls.Add(this.a_textbox);
            this.Name = "Form4";
            this.Text = "Form4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox a_textbox;
        private System.Windows.Forms.TextBox d_textbox;
        private System.Windows.Forms.TextBox c_textbox;
        private System.Windows.Forms.TextBox b_textbox;
        private System.Windows.Forms.TextBox root_1;
        private System.Windows.Forms.TextBox root_3;
        private System.Windows.Forms.TextBox root_2;
        private System.Windows.Forms.Button button_solve;
        private System.Windows.Forms.Label a_coeff;
        private System.Windows.Forms.Label b_coeff;
        private System.Windows.Forms.Label c_coeff;
        private System.Windows.Forms.Label d_coeff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label1;
    }
}