namespace gorodnitsev_Redaktor
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hscrollBar_red = new System.Windows.Forms.HScrollBar();
            this.hscrollBar_green = new System.Windows.Forms.HScrollBar();
            this.hscrollBar_blue = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_red = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_green = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_blue = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonOther = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_blue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(387, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // hscrollBar_red
            // 
            this.hscrollBar_red.LargeChange = 1;
            this.hscrollBar_red.Location = new System.Drawing.Point(64, 47);
            this.hscrollBar_red.Maximum = 255;
            this.hscrollBar_red.Name = "hscrollBar_red";
            this.hscrollBar_red.Size = new System.Drawing.Size(169, 19);
            this.hscrollBar_red.TabIndex = 1;
            this.hscrollBar_red.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HscrollBar_red_Scroll);
            // 
            // hscrollBar_green
            // 
            this.hscrollBar_green.LargeChange = 1;
            this.hscrollBar_green.Location = new System.Drawing.Point(64, 105);
            this.hscrollBar_green.Maximum = 255;
            this.hscrollBar_green.Name = "hscrollBar_green";
            this.hscrollBar_green.Size = new System.Drawing.Size(169, 19);
            this.hscrollBar_green.TabIndex = 2;
            this.hscrollBar_green.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HscrollBar_green_Scroll_1);
            // 
            // hscrollBar_blue
            // 
            this.hscrollBar_blue.LargeChange = 1;
            this.hscrollBar_blue.Location = new System.Drawing.Point(64, 161);
            this.hscrollBar_blue.Maximum = 255;
            this.hscrollBar_blue.Name = "hscrollBar_blue";
            this.hscrollBar_blue.Size = new System.Drawing.Size(169, 19);
            this.hscrollBar_blue.TabIndex = 3;
            this.hscrollBar_blue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HscrollBar_blue_Scroll_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Red";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Blue";
            // 
            // numericUpDown_red
            // 
            this.numericUpDown_red.Location = new System.Drawing.Point(255, 45);
            this.numericUpDown_red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_red.Name = "numericUpDown_red";
            this.numericUpDown_red.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown_red.TabIndex = 7;
            this.numericUpDown_red.ValueChanged += new System.EventHandler(this.NumericUpDown_red_ValueChanged);
            // 
            // numericUpDown_green
            // 
            this.numericUpDown_green.Location = new System.Drawing.Point(255, 105);
            this.numericUpDown_green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_green.Name = "numericUpDown_green";
            this.numericUpDown_green.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown_green.TabIndex = 8;
            this.numericUpDown_green.ValueChanged += new System.EventHandler(this.NumericUpDown_green_ValueChanged_1);
            // 
            // numericUpDown_blue
            // 
            this.numericUpDown_blue.Location = new System.Drawing.Point(255, 161);
            this.numericUpDown_blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_blue.Name = "numericUpDown_blue";
            this.numericUpDown_blue.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown_blue.TabIndex = 9;
            this.numericUpDown_blue.ValueChanged += new System.EventHandler(this.NumericUpDown_blue_ValueChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // buttonOther
            // 
            this.buttonOther.Location = new System.Drawing.Point(417, 223);
            this.buttonOther.Name = "buttonOther";
            this.buttonOther.Size = new System.Drawing.Size(75, 23);
            this.buttonOther.TabIndex = 12;
            this.buttonOther.Text = "Other Color";
            this.buttonOther.UseVisualStyleBackColor = true;
            this.buttonOther.Click += new System.EventHandler(this.ButtonOther_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 258);
            this.Controls.Add(this.buttonOther);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown_blue);
            this.Controls.Add(this.numericUpDown_green);
            this.Controls.Add(this.numericUpDown_red);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hscrollBar_blue);
            this.Controls.Add(this.hscrollBar_green);
            this.Controls.Add(this.hscrollBar_red);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.HScrollBar hscrollBar_red;
        private System.Windows.Forms.HScrollBar hscrollBar_green;
        private System.Windows.Forms.HScrollBar hscrollBar_blue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_red;
        private System.Windows.Forms.NumericUpDown numericUpDown_green;
        private System.Windows.Forms.NumericUpDown numericUpDown_blue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonOther;
    }
}