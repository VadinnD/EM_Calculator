namespace Calc.UserControls
{
    partial class UserGraphics
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
            components = new System.ComponentModel.Container();
            pictureBox_graph = new PictureBox();
            bwCoord = new System.ComponentModel.BackgroundWorker();
            siticoneAnimateWindow1 = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(components);
            buttonPlot = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            textBox_formula = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            label1 = new Label();
            label2 = new Label();
            textBox_xmin = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            textBox_xmax = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            label3 = new Label();
            textBox_xstep = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            label4 = new Label();
            pictureBox_container = new PictureBox();
            labelPos = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_graph).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_container).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_graph
            // 
            pictureBox_graph.BackColor = Color.FromArgb(25, 40, 65);
            pictureBox_graph.Location = new Point(0, 0);
            pictureBox_graph.Name = "pictureBox_graph";
            pictureBox_graph.Size = new Size(800, 475);
            pictureBox_graph.TabIndex = 0;
            pictureBox_graph.TabStop = false;
            // 
            // buttonPlot
            // 
            buttonPlot.Animated = true;
            buttonPlot.Cursor = Cursors.Hand;
            buttonPlot.DisabledState.BorderColor = Color.DarkGray;
            buttonPlot.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonPlot.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonPlot.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonPlot.FillColor = Color.Gray;
            buttonPlot.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPlot.ForeColor = Color.LightGray;
            buttonPlot.HoverState.FillColor = Color.FromArgb(64, 64, 64);
            buttonPlot.HoverState.ForeColor = Color.Cyan;
            buttonPlot.Location = new Point(694, 515);
            buttonPlot.Name = "buttonPlot";
            buttonPlot.PressedColor = Color.Cyan;
            buttonPlot.Size = new Size(100, 30);
            buttonPlot.TabIndex = 3;
            buttonPlot.Text = "Построить";
            buttonPlot.TextAlign = HorizontalAlignment.Left;
            buttonPlot.Click += buttonPlot_Click;
            // 
            // textBox_formula
            // 
            textBox_formula.BackColor = Color.FromArgb(35, 57, 93);
            textBox_formula.BorderColor = Color.FromArgb(35, 57, 93);
            textBox_formula.BorderThickness = 0;
            textBox_formula.DefaultText = "";
            textBox_formula.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBox_formula.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBox_formula.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBox_formula.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBox_formula.FillColor = Color.Silver;
            textBox_formula.FocusedState.BorderColor = Color.White;
            textBox_formula.FocusedState.FillColor = Color.White;
            textBox_formula.FocusedState.ForeColor = Color.Black;
            textBox_formula.FocusedState.PlaceholderForeColor = Color.Black;
            textBox_formula.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_formula.ForeColor = Color.Black;
            textBox_formula.HoverState.FillColor = Color.Gray;
            textBox_formula.HoverState.ForeColor = Color.Black;
            textBox_formula.HoverState.PlaceholderForeColor = Color.Black;
            textBox_formula.IconLeftOffset = new Point(10, 0);
            textBox_formula.Location = new Point(84, 516);
            textBox_formula.Name = "textBox_formula";
            textBox_formula.PasswordChar = '\0';
            textBox_formula.PlaceholderForeColor = Color.Silver;
            textBox_formula.PlaceholderText = "";
            textBox_formula.SelectedText = "";
            textBox_formula.Size = new Size(600, 30);
            textBox_formula.TabIndex = 9;
            textBox_formula.TextOffset = new Point(5, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(22, 517);
            label1.Name = "label1";
            label1.Size = new Size(59, 24);
            label1.TabIndex = 10;
            label1.Text = "f(x) = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(22, 480);
            label2.Name = "label2";
            label2.Size = new Size(53, 24);
            label2.TabIndex = 11;
            label2.Text = "xmin";
            // 
            // textBox_xmin
            // 
            textBox_xmin.BackColor = Color.FromArgb(35, 57, 93);
            textBox_xmin.BorderColor = Color.FromArgb(35, 57, 93);
            textBox_xmin.BorderThickness = 0;
            textBox_xmin.DefaultText = "";
            textBox_xmin.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBox_xmin.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBox_xmin.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBox_xmin.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBox_xmin.FillColor = Color.Silver;
            textBox_xmin.FocusedState.BorderColor = Color.White;
            textBox_xmin.FocusedState.FillColor = Color.White;
            textBox_xmin.FocusedState.ForeColor = Color.Black;
            textBox_xmin.FocusedState.PlaceholderForeColor = Color.Black;
            textBox_xmin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_xmin.ForeColor = Color.Black;
            textBox_xmin.HoverState.FillColor = Color.Gray;
            textBox_xmin.HoverState.ForeColor = Color.Black;
            textBox_xmin.HoverState.PlaceholderForeColor = Color.Black;
            textBox_xmin.IconLeftOffset = new Point(10, 0);
            textBox_xmin.Location = new Point(84, 480);
            textBox_xmin.Name = "textBox_xmin";
            textBox_xmin.PasswordChar = '\0';
            textBox_xmin.PlaceholderForeColor = Color.Silver;
            textBox_xmin.PlaceholderText = "";
            textBox_xmin.SelectedText = "";
            textBox_xmin.Size = new Size(66, 30);
            textBox_xmin.TabIndex = 12;
            textBox_xmin.TextOffset = new Point(5, 0);
            // 
            // textBox_xmax
            // 
            textBox_xmax.BackColor = Color.FromArgb(35, 57, 93);
            textBox_xmax.BorderColor = Color.FromArgb(35, 57, 93);
            textBox_xmax.BorderThickness = 0;
            textBox_xmax.DefaultText = "";
            textBox_xmax.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBox_xmax.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBox_xmax.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBox_xmax.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBox_xmax.FillColor = Color.Silver;
            textBox_xmax.FocusedState.BorderColor = Color.White;
            textBox_xmax.FocusedState.FillColor = Color.White;
            textBox_xmax.FocusedState.ForeColor = Color.Black;
            textBox_xmax.FocusedState.PlaceholderForeColor = Color.Black;
            textBox_xmax.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_xmax.ForeColor = Color.Black;
            textBox_xmax.HoverState.FillColor = Color.Gray;
            textBox_xmax.HoverState.ForeColor = Color.Black;
            textBox_xmax.HoverState.PlaceholderForeColor = Color.Black;
            textBox_xmax.IconLeftOffset = new Point(10, 0);
            textBox_xmax.Location = new Point(229, 481);
            textBox_xmax.Name = "textBox_xmax";
            textBox_xmax.PasswordChar = '\0';
            textBox_xmax.PlaceholderForeColor = Color.Silver;
            textBox_xmax.PlaceholderText = "";
            textBox_xmax.SelectedText = "";
            textBox_xmax.Size = new Size(66, 30);
            textBox_xmax.TabIndex = 14;
            textBox_xmax.TextOffset = new Point(5, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(167, 481);
            label3.Name = "label3";
            label3.Size = new Size(58, 24);
            label3.TabIndex = 13;
            label3.Text = "xmax";
            // 
            // textBox_xstep
            // 
            textBox_xstep.BackColor = Color.FromArgb(35, 57, 93);
            textBox_xstep.BorderColor = Color.FromArgb(35, 57, 93);
            textBox_xstep.BorderThickness = 0;
            textBox_xstep.DefaultText = "";
            textBox_xstep.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBox_xstep.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBox_xstep.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBox_xstep.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBox_xstep.FillColor = Color.Silver;
            textBox_xstep.FocusedState.BorderColor = Color.White;
            textBox_xstep.FocusedState.FillColor = Color.White;
            textBox_xstep.FocusedState.ForeColor = Color.Black;
            textBox_xstep.FocusedState.PlaceholderForeColor = Color.Black;
            textBox_xstep.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_xstep.ForeColor = Color.Black;
            textBox_xstep.HoverState.FillColor = Color.Gray;
            textBox_xstep.HoverState.ForeColor = Color.Black;
            textBox_xstep.HoverState.PlaceholderForeColor = Color.Black;
            textBox_xstep.IconLeftOffset = new Point(10, 0);
            textBox_xstep.Location = new Point(375, 481);
            textBox_xstep.Name = "textBox_xstep";
            textBox_xstep.PasswordChar = '\0';
            textBox_xstep.PlaceholderForeColor = Color.Silver;
            textBox_xstep.PlaceholderText = "";
            textBox_xstep.SelectedText = "";
            textBox_xstep.Size = new Size(66, 30);
            textBox_xstep.TabIndex = 16;
            textBox_xstep.TextOffset = new Point(5, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(313, 481);
            label4.Name = "label4";
            label4.Size = new Size(45, 24);
            label4.TabIndex = 15;
            label4.Text = "шаг";
            // 
            // pictureBox_container
            // 
            pictureBox_container.BackColor = Color.FromArgb(25, 40, 65);
            pictureBox_container.Location = new Point(0, 0);
            pictureBox_container.Name = "pictureBox_container";
            pictureBox_container.Size = new Size(800, 475);
            pictureBox_container.TabIndex = 18;
            pictureBox_container.TabStop = false;
            // 
            // labelPos
            // 
            labelPos.AutoSize = true;
            labelPos.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelPos.ForeColor = Color.Gray;
            labelPos.Location = new Point(715, 481);
            labelPos.Name = "labelPos";
            labelPos.Size = new Size(54, 24);
            labelPos.TabIndex = 19;
            labelPos.Text = "(x; y)";
            labelPos.Visible = false;
            // 
            // UserGraphics
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(labelPos);
            Controls.Add(pictureBox_container);
            Controls.Add(textBox_xstep);
            Controls.Add(label4);
            Controls.Add(textBox_xmax);
            Controls.Add(label3);
            Controls.Add(textBox_xmin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_formula);
            Controls.Add(buttonPlot);
            Controls.Add(pictureBox_graph);
            Font = new Font("Bahnschrift", 11.5F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserGraphics";
            Size = new Size(800, 550);
            ((System.ComponentModel.ISupportInitialize)pictureBox_graph).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_container).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_graph;
        private System.ComponentModel.BackgroundWorker bwCoord;
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow siticoneAnimateWindow1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton buttonPlot;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox textBox_formula;
        private Label label1;
        private Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox textBox_xmin;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox textBox_xmax;
        private Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox textBox_xstep;
        private Label label4;
        private PictureBox pictureBox_container;
        private Label labelPos;
    }
}
