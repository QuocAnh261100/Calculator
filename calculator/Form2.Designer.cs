namespace calculator
{
    partial class Form2
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
            this.a_coeff = new System.Windows.Forms.TextBox();
            this.c_coeff = new System.Windows.Forms.TextBox();
            this.b_coeff = new System.Windows.Forms.TextBox();
            this.root_2 = new System.Windows.Forms.TextBox();
            this.root_1 = new System.Windows.Forms.TextBox();
            this.show_result_2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // a_coeff
            // 
            this.a_coeff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_coeff.Location = new System.Drawing.Point(161, 65);
            this.a_coeff.Name = "a_coeff";
            this.a_coeff.Size = new System.Drawing.Size(100, 36);
            this.a_coeff.TabIndex = 0;
            this.a_coeff.TextChanged += new System.EventHandler(this.a_coeff_TextChanged);
            this.a_coeff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press);
            // 
            // c_coeff
            // 
            this.c_coeff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_coeff.Location = new System.Drawing.Point(622, 65);
            this.c_coeff.Name = "c_coeff";
            this.c_coeff.Size = new System.Drawing.Size(100, 36);
            this.c_coeff.TabIndex = 2;
            this.c_coeff.TextChanged += new System.EventHandler(this.c_coeff_TextChanged);
            this.c_coeff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press);
            // 
            // b_coeff
            // 
            this.b_coeff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_coeff.Location = new System.Drawing.Point(398, 65);
            this.b_coeff.Name = "b_coeff";
            this.b_coeff.Size = new System.Drawing.Size(100, 36);
            this.b_coeff.TabIndex = 1;
            this.b_coeff.TextChanged += new System.EventHandler(this.b_coeff_TextChanged);
            this.b_coeff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press);
            // 
            // root_2
            // 
            this.root_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.root_2.Location = new System.Drawing.Point(319, 275);
            this.root_2.Name = "root_2";
            this.root_2.Size = new System.Drawing.Size(242, 36);
            this.root_2.TabIndex = 4;
            // 
            // root_1
            // 
            this.root_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.root_1.Location = new System.Drawing.Point(319, 217);
            this.root_1.Name = "root_1";
            this.root_1.Size = new System.Drawing.Size(242, 36);
            this.root_1.TabIndex = 5;
            // 
            // show_result_2
            // 
            this.show_result_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_result_2.Location = new System.Drawing.Point(82, 167);
            this.show_result_2.Name = "show_result_2";
            this.show_result_2.Size = new System.Drawing.Size(613, 36);
            this.show_result_2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(660, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 81);
            this.button1.TabIndex = 3;
            this.button1.Text = "SOLVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Solve_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "a = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "b =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(575, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "c=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(245, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "x2 =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "x1 = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(316, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Press Enter to continue";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 376);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.show_result_2);
            this.Controls.Add(this.root_1);
            this.Controls.Add(this.root_2);
            this.Controls.Add(this.b_coeff);
            this.Controls.Add(this.c_coeff);
            this.Controls.Add(this.a_coeff);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox a_coeff;
        private System.Windows.Forms.TextBox c_coeff;
        private System.Windows.Forms.TextBox b_coeff;
        private System.Windows.Forms.TextBox root_2;
        private System.Windows.Forms.TextBox root_1;
        private System.Windows.Forms.TextBox show_result_2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}