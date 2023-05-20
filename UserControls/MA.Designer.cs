namespace Calc.UserControls
{
    partial class MA
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
            startingHeader = new Label();
            menuBtn2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            menuBtn1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            complexPanel = new Panel();
            complexBtn1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            complexHeader = new Label();
            limPanel = new Panel();
            limBtn1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            limHeader = new Label();
            startingPanel = new Panel();
            backBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            complexPanel.SuspendLayout();
            limPanel.SuspendLayout();
            startingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // startingHeader
            // 
            startingHeader.AutoSize = true;
            startingHeader.Font = new Font("Bahnschrift", 26F, FontStyle.Regular, GraphicsUnit.Point);
            startingHeader.ForeColor = Color.Silver;
            startingHeader.Location = new Point(193, 10);
            startingHeader.Name = "startingHeader";
            startingHeader.Size = new Size(415, 42);
            startingHeader.TabIndex = 3;
            startingHeader.Text = "Математический анализ";
            // 
            // menuBtn2
            // 
            menuBtn2.Animated = true;
            menuBtn2.Cursor = Cursors.Hand;
            menuBtn2.DisabledState.BorderColor = Color.DarkGray;
            menuBtn2.DisabledState.CustomBorderColor = Color.DarkGray;
            menuBtn2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            menuBtn2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            menuBtn2.FillColor = Color.FromArgb(25, 40, 65);
            menuBtn2.Font = new Font("Bahnschrift", 17F, FontStyle.Regular, GraphicsUnit.Point);
            menuBtn2.ForeColor = Color.LightGray;
            menuBtn2.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            menuBtn2.HoverState.ForeColor = Color.Cyan;
            menuBtn2.Location = new Point(75, 200);
            menuBtn2.Name = "menuBtn2";
            menuBtn2.PressedColor = Color.Cyan;
            menuBtn2.Size = new Size(650, 90);
            menuBtn2.TabIndex = 5;
            menuBtn2.Text = "Поиск пределов";
            menuBtn2.TextAlign = HorizontalAlignment.Left;
            menuBtn2.Click += menuBtn2_Click;
            // 
            // menuBtn1
            // 
            menuBtn1.Animated = true;
            menuBtn1.Cursor = Cursors.Hand;
            menuBtn1.DisabledState.BorderColor = Color.DarkGray;
            menuBtn1.DisabledState.CustomBorderColor = Color.DarkGray;
            menuBtn1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            menuBtn1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            menuBtn1.FillColor = Color.FromArgb(25, 40, 65);
            menuBtn1.Font = new Font("Bahnschrift", 17F, FontStyle.Regular, GraphicsUnit.Point);
            menuBtn1.ForeColor = Color.LightGray;
            menuBtn1.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            menuBtn1.HoverState.ForeColor = Color.Cyan;
            menuBtn1.Location = new Point(75, 85);
            menuBtn1.Name = "menuBtn1";
            menuBtn1.PressedColor = Color.Cyan;
            menuBtn1.Size = new Size(650, 90);
            menuBtn1.TabIndex = 4;
            menuBtn1.Text = "Комплексные числа";
            menuBtn1.TextAlign = HorizontalAlignment.Left;
            menuBtn1.Click += menuBtn1_Click;
            // 
            // complexPanel
            // 
            complexPanel.Controls.Add(complexBtn1);
            complexPanel.Controls.Add(complexHeader);
            complexPanel.Location = new Point(0, 0);
            complexPanel.Name = "complexPanel";
            complexPanel.Size = new Size(800, 550);
            complexPanel.TabIndex = 6;
            // 
            // complexBtn1
            // 
            complexBtn1.Animated = true;
            complexBtn1.Cursor = Cursors.Hand;
            complexBtn1.DisabledState.BorderColor = Color.DarkGray;
            complexBtn1.DisabledState.CustomBorderColor = Color.DarkGray;
            complexBtn1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            complexBtn1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            complexBtn1.FillColor = Color.FromArgb(25, 40, 65);
            complexBtn1.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            complexBtn1.ForeColor = Color.LightGray;
            complexBtn1.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            complexBtn1.HoverState.ForeColor = Color.Cyan;
            complexBtn1.Location = new Point(128, 84);
            complexBtn1.Name = "complexBtn1";
            complexBtn1.PressedColor = Color.Cyan;
            complexBtn1.Size = new Size(545, 45);
            complexBtn1.TabIndex = 7;
            complexBtn1.Text = "Арифметические действия";
            complexBtn1.TextAlign = HorizontalAlignment.Left;
            // 
            // complexHeader
            // 
            complexHeader.AutoSize = true;
            complexHeader.Font = new Font("Bahnschrift", 26F, FontStyle.Regular, GraphicsUnit.Point);
            complexHeader.ForeColor = Color.Silver;
            complexHeader.Location = new Point(229, 10);
            complexHeader.Name = "complexHeader";
            complexHeader.Size = new Size(342, 42);
            complexHeader.TabIndex = 2;
            complexHeader.Text = "Комплексные числа";
            // 
            // limPanel
            // 
            limPanel.Controls.Add(limBtn1);
            limPanel.Controls.Add(limHeader);
            limPanel.Location = new Point(0, 0);
            limPanel.Name = "limPanel";
            limPanel.Size = new Size(800, 550);
            limPanel.TabIndex = 8;
            // 
            // limBtn1
            // 
            limBtn1.Animated = true;
            limBtn1.Cursor = Cursors.Hand;
            limBtn1.DisabledState.BorderColor = Color.DarkGray;
            limBtn1.DisabledState.CustomBorderColor = Color.DarkGray;
            limBtn1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            limBtn1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            limBtn1.FillColor = Color.FromArgb(25, 40, 65);
            limBtn1.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            limBtn1.ForeColor = Color.LightGray;
            limBtn1.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            limBtn1.HoverState.ForeColor = Color.Cyan;
            limBtn1.Location = new Point(128, 84);
            limBtn1.Name = "limBtn1";
            limBtn1.PressedColor = Color.Cyan;
            limBtn1.Size = new Size(545, 45);
            limBtn1.TabIndex = 8;
            limBtn1.Text = "???";
            limBtn1.TextAlign = HorizontalAlignment.Left;
            // 
            // limHeader
            // 
            limHeader.AutoSize = true;
            limHeader.Font = new Font("Bahnschrift", 26F, FontStyle.Regular, GraphicsUnit.Point);
            limHeader.ForeColor = Color.Silver;
            limHeader.Location = new Point(261, 10);
            limHeader.Name = "limHeader";
            limHeader.Size = new Size(279, 42);
            limHeader.TabIndex = 3;
            limHeader.Text = "Поиск пределов";
            // 
            // startingPanel
            // 
            startingPanel.Controls.Add(menuBtn2);
            startingPanel.Controls.Add(menuBtn1);
            startingPanel.Controls.Add(startingHeader);
            startingPanel.Location = new Point(0, 0);
            startingPanel.Name = "startingPanel";
            startingPanel.Size = new Size(800, 550);
            startingPanel.TabIndex = 9;
            // 
            // backBtn
            // 
            backBtn.DisabledState.BorderColor = Color.DarkGray;
            backBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            backBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            backBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            backBtn.FillColor = Color.Transparent;
            backBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            backBtn.ForeColor = Color.White;
            backBtn.HoverState.Image = Properties.Resources.arrow_white;
            backBtn.Image = Properties.Resources.arrow_gray;
            backBtn.Location = new Point(0, 10);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(37, 45);
            backBtn.TabIndex = 7;
            backBtn.Click += backBtn_Click;
            // 
            // MA
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 40, 65);
            Controls.Add(backBtn);
            Controls.Add(startingPanel);
            Controls.Add(limPanel);
            Controls.Add(complexPanel);
            Font = new Font("Bahnschrift", 11.5F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MA";
            Size = new Size(800, 550);
            complexPanel.ResumeLayout(false);
            complexPanel.PerformLayout();
            limPanel.ResumeLayout(false);
            limPanel.PerformLayout();
            startingPanel.ResumeLayout(false);
            startingPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label startingHeader;
        private Siticone.Desktop.UI.WinForms.SiticoneButton menuBtn2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton menuBtn1;
        private Panel complexPanel;
        private Label complexHeader;
        private Panel limPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton limBtn1;
        private Label limHeader;
        private Siticone.Desktop.UI.WinForms.SiticoneButton complexBtn1;
        private Panel startingPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton backBtn;
    }
}
