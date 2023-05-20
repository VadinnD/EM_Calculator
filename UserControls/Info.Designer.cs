namespace Calc.UserControls
{
    partial class Info
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.SkyBlue;
            label2.Location = new Point(54, 349);
            label2.Name = "label2";
            label2.Size = new Size(195, 33);
            label2.TabIndex = 5;
            label2.Text = "EveryMathCalc";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(48, 349);
            label1.Name = "label1";
            label1.Size = new Size(705, 66);
            label1.TabIndex = 4;
            label1.Text = "EveryMathCalc — многофункциональный калькулятор \r\nв виде Desktop-приложения с современным дизайном.\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(191, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(419, 227);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Info
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 40, 65);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Bahnschrift", 11.5F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Info";
            Size = new Size(800, 550);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
