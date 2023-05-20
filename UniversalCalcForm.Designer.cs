namespace Calc
{
    partial class UniversalCalcForm
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
            siticoneControlBox3 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            topBar = new Panel();
            header = new Label();
            dataBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            resBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            resBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            topBar.SuspendLayout();
            SuspendLayout();
            // 
            // siticoneControlBox3
            // 
            siticoneControlBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            siticoneControlBox3.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            siticoneControlBox3.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MaximizeBox;
            siticoneControlBox3.FillColor = Color.FromArgb(25, 40, 65);
            siticoneControlBox3.HoverState.FillColor = Color.FromArgb(28, 46, 74);
            siticoneControlBox3.IconColor = Color.Silver;
            siticoneControlBox3.Location = new Point(395, 0);
            siticoneControlBox3.Name = "siticoneControlBox3";
            siticoneControlBox3.Size = new Size(45, 27);
            siticoneControlBox3.TabIndex = 4;
            // 
            // siticoneControlBox2
            // 
            siticoneControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            siticoneControlBox2.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            siticoneControlBox2.FillColor = Color.FromArgb(25, 40, 65);
            siticoneControlBox2.HoverState.FillColor = Color.FromArgb(28, 46, 74);
            siticoneControlBox2.IconColor = Color.Silver;
            siticoneControlBox2.Location = new Point(350, 0);
            siticoneControlBox2.Name = "siticoneControlBox2";
            siticoneControlBox2.Size = new Size(45, 27);
            siticoneControlBox2.TabIndex = 5;
            // 
            // siticoneControlBox1
            // 
            siticoneControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            siticoneControlBox1.BackColor = Color.Transparent;
            siticoneControlBox1.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            siticoneControlBox1.FillColor = Color.FromArgb(25, 40, 65);
            siticoneControlBox1.HoverState.FillColor = Color.FromArgb(128, 60, 60);
            siticoneControlBox1.IconColor = Color.Silver;
            siticoneControlBox1.Location = new Point(440, 0);
            siticoneControlBox1.Name = "siticoneControlBox1";
            siticoneControlBox1.Size = new Size(45, 27);
            siticoneControlBox1.TabIndex = 3;
            // 
            // topBar
            // 
            topBar.BackColor = Color.Transparent;
            topBar.Controls.Add(siticoneControlBox3);
            topBar.Controls.Add(siticoneControlBox2);
            topBar.Controls.Add(siticoneControlBox1);
            topBar.Dock = DockStyle.Top;
            topBar.Location = new Point(0, 0);
            topBar.Name = "topBar";
            topBar.Size = new Size(484, 25);
            topBar.TabIndex = 6;
            topBar.MouseDown += topBar_MouseDown;
            topBar.MouseMove += topBar_MouseMove;
            // 
            // header
            // 
            header.AutoSize = true;
            header.Font = new Font("Bahnschrift", 20F, FontStyle.Regular, GraphicsUnit.Point);
            header.ForeColor = Color.Silver;
            header.Location = new Point(125, 46);
            header.Name = "header";
            header.Size = new Size(235, 33);
            header.TabIndex = 7;
            header.Text = "что нужно ввести";
            // 
            // dataBox
            // 
            dataBox.BorderColor = Color.FromArgb(35, 57, 93);
            dataBox.BorderRadius = 4;
            dataBox.BorderThickness = 2;
            dataBox.DefaultText = "";
            dataBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            dataBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            dataBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            dataBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            dataBox.FillColor = Color.FromArgb(25, 40, 65);
            dataBox.FocusedState.BorderColor = Color.White;
            dataBox.FocusedState.FillColor = Color.White;
            dataBox.FocusedState.ForeColor = Color.Black;
            dataBox.FocusedState.PlaceholderForeColor = Color.Black;
            dataBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataBox.ForeColor = Color.Black;
            dataBox.HoverState.BorderColor = Color.FromArgb(35, 57, 93);
            dataBox.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            dataBox.HoverState.ForeColor = Color.White;
            dataBox.HoverState.PlaceholderForeColor = Color.White;
            dataBox.IconLeftOffset = new Point(10, 0);
            dataBox.Location = new Point(105, 115);
            dataBox.Name = "dataBox";
            dataBox.PasswordChar = '\0';
            dataBox.PlaceholderForeColor = Color.Silver;
            dataBox.PlaceholderText = "введите данные";
            dataBox.SelectedText = "";
            dataBox.Size = new Size(274, 35);
            dataBox.TabIndex = 8;
            dataBox.TextOffset = new Point(5, 0);
            // 
            // resBtn
            // 
            resBtn.Animated = true;
            resBtn.Cursor = Cursors.Hand;
            resBtn.DisabledState.BorderColor = Color.DarkGray;
            resBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            resBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            resBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            resBtn.FillColor = Color.FromArgb(25, 40, 65);
            resBtn.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point);
            resBtn.ForeColor = Color.LightGray;
            resBtn.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            resBtn.HoverState.ForeColor = Color.Cyan;
            resBtn.Location = new Point(92, 175);
            resBtn.Name = "resBtn";
            resBtn.PressedColor = Color.Cyan;
            resBtn.Size = new Size(300, 55);
            resBtn.TabIndex = 9;
            resBtn.Text = "Получить результат";
            resBtn.TextAlign = HorizontalAlignment.Left;
            // 
            // resBox
            // 
            resBox.BorderColor = Color.FromArgb(35, 57, 93);
            resBox.BorderRadius = 4;
            resBox.BorderThickness = 2;
            resBox.DefaultText = "";
            resBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            resBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            resBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            resBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            resBox.FillColor = Color.FromArgb(25, 40, 65);
            resBox.FocusedState.BorderColor = Color.White;
            resBox.FocusedState.FillColor = Color.White;
            resBox.FocusedState.ForeColor = Color.Black;
            resBox.FocusedState.PlaceholderForeColor = Color.Black;
            resBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            resBox.ForeColor = Color.Black;
            resBox.HoverState.BorderColor = Color.FromArgb(35, 57, 93);
            resBox.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            resBox.HoverState.ForeColor = Color.White;
            resBox.HoverState.PlaceholderForeColor = Color.White;
            resBox.IconLeftOffset = new Point(10, 0);
            resBox.Location = new Point(105, 255);
            resBox.Name = "resBox";
            resBox.PasswordChar = '\0';
            resBox.PlaceholderForeColor = Color.Silver;
            resBox.PlaceholderText = "полученный результат";
            resBox.SelectedText = "";
            resBox.Size = new Size(274, 35);
            resBox.TabIndex = 10;
            resBox.TextOffset = new Point(5, 0);
            // 
            // UniversalCalcForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 40, 65);
            ClientSize = new Size(484, 461);
            Controls.Add(resBox);
            Controls.Add(resBtn);
            Controls.Add(dataBox);
            Controls.Add(header);
            Controls.Add(topBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UniversalCalcForm";
            Opacity = 0.98D;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UniversalCalcForm";
            topBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox3;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Panel topBar;
        private Label header;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox dataBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton resBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox resBox;
    }
}