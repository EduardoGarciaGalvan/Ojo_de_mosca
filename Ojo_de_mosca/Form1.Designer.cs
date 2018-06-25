namespace Ojo_de_mosca
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
            this.Start = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Parallel = new System.Windows.Forms.CheckBox();
            this.Points = new System.Windows.Forms.NumericUpDown();
            this.Radio = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Points)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Radio)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(499, 374);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(300, 75);
            this.Start.TabIndex = 0;
            this.Start.Text = "Draw";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Parallel);
            this.panel1.Controls.Add(this.Points);
            this.panel1.Controls.Add(this.Radio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(499, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 376);
            this.panel1.TabIndex = 11;
            // 
            // Parallel
            // 
            this.Parallel.AutoSize = true;
            this.Parallel.Location = new System.Drawing.Point(6, 280);
            this.Parallel.Name = "Parallel";
            this.Parallel.Size = new System.Drawing.Size(82, 21);
            this.Parallel.TabIndex = 16;
            this.Parallel.Text = "Paralelo";
            this.Parallel.UseVisualStyleBackColor = true;
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.Location = new System.Drawing.Point(6, 29);
            this.Points.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.Points.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(120, 22);
            this.Points.TabIndex = 13;
            this.Points.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Radio
            // 
            this.Radio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Radio.DecimalPlaces = 3;
            this.Radio.Location = new System.Drawing.Point(6, 216);
            this.Radio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Radio.Name = "Radio";
            this.Radio.Size = new System.Drawing.Size(120, 22);
            this.Radio.TabIndex = 15;
            this.Radio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Points";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Radio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Points)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Radio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private int points;
        private double radio;
        private bool parallel;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Points;
        private System.Windows.Forms.NumericUpDown Radio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Parallel;
    }
}

