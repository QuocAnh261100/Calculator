namespace calculator
{
    partial class Form7
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
            this.button_undo = new System.Windows.Forms.Button();
            this.textBox_location = new System.Windows.Forms.TextBox();
            this.change_point = new System.Windows.Forms.Button();
            this.draw_all = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_undo
            // 
            this.button_undo.Location = new System.Drawing.Point(23, 201);
            this.button_undo.Name = "button_undo";
            this.button_undo.Size = new System.Drawing.Size(136, 84);
            this.button_undo.TabIndex = 9;
            this.button_undo.Text = "Undo";
            this.button_undo.UseVisualStyleBackColor = true;
            this.button_undo.Click += new System.EventHandler(this.button_undo_Click);
            // 
            // textBox_location
            // 
            this.textBox_location.Location = new System.Drawing.Point(23, 43);
            this.textBox_location.Name = "textBox_location";
            this.textBox_location.Size = new System.Drawing.Size(160, 22);
            this.textBox_location.TabIndex = 8;
            // 
            // change_point
            // 
            this.change_point.Location = new System.Drawing.Point(23, 308);
            this.change_point.Name = "change_point";
            this.change_point.Size = new System.Drawing.Size(136, 84);
            this.change_point.TabIndex = 6;
            this.change_point.Text = "Change";
            this.change_point.UseVisualStyleBackColor = true;
            // 
            // draw_all
            // 
            this.draw_all.Location = new System.Drawing.Point(23, 95);
            this.draw_all.Name = "draw_all";
            this.draw_all.Size = new System.Drawing.Size(136, 84);
            this.draw_all.TabIndex = 5;
            this.draw_all.Text = "Draw with new point";
            this.draw_all.UseVisualStyleBackColor = true;
            this.draw_all.Click += new System.EventHandler(this.draw_all_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImage = global::calculator.Properties.Resources.draw_c;
            this.pictureBox1.Location = new System.Drawing.Point(199, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1014, 628);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 705);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_undo);
            this.Controls.Add(this.textBox_location);
            this.Controls.Add(this.change_point);
            this.Controls.Add(this.draw_all);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_undo;
        private System.Windows.Forms.TextBox textBox_location;
        private System.Windows.Forms.Button change_point;
        private System.Windows.Forms.Button draw_all;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}