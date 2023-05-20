namespace Calc.UserControls
{
    partial class DM
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
            menuHeader = new Label();
            menuBtn2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            menuBtn1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            menuBtn3 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            menuBtn4 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            logicPanel = new Panel();
            logicBtn1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            logicHeader = new Label();
            setsPanel = new Panel();
            setsBtn1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            setsHeader = new Label();
            combPanel = new Panel();
            combBtn1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            combHeader = new Label();
            divPanel = new Panel();
            divBtn1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            divHeader = new Label();
            startingPanel = new Panel();
            backBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            logicPanel.SuspendLayout();
            setsPanel.SuspendLayout();
            combPanel.SuspendLayout();
            divPanel.SuspendLayout();
            startingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuHeader
            // 
            menuHeader.AutoSize = true;
            menuHeader.Font = new Font("Bahnschrift", 26F, FontStyle.Regular, GraphicsUnit.Point);
            menuHeader.ForeColor = Color.Silver;
            menuHeader.Location = new Point(195, 10);
            menuHeader.Name = "menuHeader";
            menuHeader.Size = new Size(411, 42);
            menuHeader.TabIndex = 2;
            menuHeader.Text = "Дискретная математика";
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
            menuBtn2.Text = "Работа со множествами";
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
            menuBtn1.Text = "Алгебра логики";
            menuBtn1.TextAlign = HorizontalAlignment.Left;
            menuBtn1.Click += menuBtn1_Click;
            // 
            // menuBtn3
            // 
            menuBtn3.Animated = true;
            menuBtn3.Cursor = Cursors.Hand;
            menuBtn3.DisabledState.BorderColor = Color.DarkGray;
            menuBtn3.DisabledState.CustomBorderColor = Color.DarkGray;
            menuBtn3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            menuBtn3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            menuBtn3.FillColor = Color.FromArgb(25, 40, 65);
            menuBtn3.Font = new Font("Bahnschrift", 17F, FontStyle.Regular, GraphicsUnit.Point);
            menuBtn3.ForeColor = Color.LightGray;
            menuBtn3.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            menuBtn3.HoverState.ForeColor = Color.Cyan;
            menuBtn3.Location = new Point(75, 315);
            menuBtn3.Name = "menuBtn3";
            menuBtn3.PressedColor = Color.Cyan;
            menuBtn3.Size = new Size(650, 90);
            menuBtn3.TabIndex = 6;
            menuBtn3.Text = "Комбинаторика";
            menuBtn3.TextAlign = HorizontalAlignment.Left;
            menuBtn3.Click += menuBtn3_Click;
            // 
            // menuBtn4
            // 
            menuBtn4.Animated = true;
            menuBtn4.Cursor = Cursors.Hand;
            menuBtn4.DisabledState.BorderColor = Color.DarkGray;
            menuBtn4.DisabledState.CustomBorderColor = Color.DarkGray;
            menuBtn4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            menuBtn4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            menuBtn4.FillColor = Color.FromArgb(25, 40, 65);
            menuBtn4.Font = new Font("Bahnschrift", 17F, FontStyle.Regular, GraphicsUnit.Point);
            menuBtn4.ForeColor = Color.LightGray;
            menuBtn4.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            menuBtn4.HoverState.ForeColor = Color.Cyan;
            menuBtn4.Location = new Point(75, 430);
            menuBtn4.Name = "menuBtn4";
            menuBtn4.PressedColor = Color.Cyan;
            menuBtn4.Size = new Size(650, 90);
            menuBtn4.TabIndex = 7;
            menuBtn4.Text = "Делимость";
            menuBtn4.TextAlign = HorizontalAlignment.Left;
            menuBtn4.Click += menuBtn4_Click;
            // 
            // logicPanel
            // 
            logicPanel.Controls.Add(logicBtn1);
            logicPanel.Controls.Add(logicHeader);
            logicPanel.Location = new Point(0, 0);
            logicPanel.Name = "logicPanel";
            logicPanel.Size = new Size(800, 550);
            logicPanel.TabIndex = 8;
            // 
            // logicBtn1
            // 
            logicBtn1.Animated = true;
            logicBtn1.Cursor = Cursors.Hand;
            logicBtn1.DisabledState.BorderColor = Color.DarkGray;
            logicBtn1.DisabledState.CustomBorderColor = Color.DarkGray;
            logicBtn1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            logicBtn1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            logicBtn1.FillColor = Color.FromArgb(25, 40, 65);
            logicBtn1.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            logicBtn1.ForeColor = Color.LightGray;
            logicBtn1.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            logicBtn1.HoverState.ForeColor = Color.Cyan;
            logicBtn1.Location = new Point(128, 84);
            logicBtn1.Name = "logicBtn1";
            logicBtn1.PressedColor = Color.Cyan;
            logicBtn1.Size = new Size(545, 45);
            logicBtn1.TabIndex = 9;
            logicBtn1.Text = "Конъюнкция";
            logicBtn1.TextAlign = HorizontalAlignment.Left;
            // 
            // logicHeader
            // 
            logicHeader.AutoSize = true;
            logicHeader.Font = new Font("Bahnschrift", 26F, FontStyle.Regular, GraphicsUnit.Point);
            logicHeader.ForeColor = Color.Silver;
            logicHeader.Location = new Point(262, 10);
            logicHeader.Name = "logicHeader";
            logicHeader.Size = new Size(273, 42);
            logicHeader.TabIndex = 2;
            logicHeader.Text = "Алгебра логики";
            // 
            // setsPanel
            // 
            setsPanel.Controls.Add(setsBtn1);
            setsPanel.Controls.Add(setsHeader);
            setsPanel.Location = new Point(0, 0);
            setsPanel.Name = "setsPanel";
            setsPanel.Size = new Size(800, 550);
            setsPanel.TabIndex = 10;
            // 
            // setsBtn1
            // 
            setsBtn1.Animated = true;
            setsBtn1.Cursor = Cursors.Hand;
            setsBtn1.DisabledState.BorderColor = Color.DarkGray;
            setsBtn1.DisabledState.CustomBorderColor = Color.DarkGray;
            setsBtn1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            setsBtn1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            setsBtn1.FillColor = Color.FromArgb(25, 40, 65);
            setsBtn1.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            setsBtn1.ForeColor = Color.LightGray;
            setsBtn1.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            setsBtn1.HoverState.ForeColor = Color.Cyan;
            setsBtn1.Location = new Point(128, 84);
            setsBtn1.Name = "setsBtn1";
            setsBtn1.PressedColor = Color.Cyan;
            setsBtn1.Size = new Size(545, 45);
            setsBtn1.TabIndex = 10;
            setsBtn1.Text = "Объединение";
            setsBtn1.TextAlign = HorizontalAlignment.Left;
            // 
            // setsHeader
            // 
            setsHeader.AutoSize = true;
            setsHeader.Font = new Font("Bahnschrift", 26F, FontStyle.Regular, GraphicsUnit.Point);
            setsHeader.ForeColor = Color.Silver;
            setsHeader.Location = new Point(198, 10);
            setsHeader.Name = "setsHeader";
            setsHeader.Size = new Size(404, 42);
            setsHeader.TabIndex = 3;
            setsHeader.Text = "Работа со множествами";
            // 
            // combPanel
            // 
            combPanel.Controls.Add(combBtn1);
            combPanel.Controls.Add(combHeader);
            combPanel.Location = new Point(0, 0);
            combPanel.Name = "combPanel";
            combPanel.Size = new Size(800, 550);
            combPanel.TabIndex = 11;
            // 
            // combBtn1
            // 
            combBtn1.Animated = true;
            combBtn1.Cursor = Cursors.Hand;
            combBtn1.DisabledState.BorderColor = Color.DarkGray;
            combBtn1.DisabledState.CustomBorderColor = Color.DarkGray;
            combBtn1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            combBtn1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            combBtn1.FillColor = Color.FromArgb(25, 40, 65);
            combBtn1.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            combBtn1.ForeColor = Color.LightGray;
            combBtn1.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            combBtn1.HoverState.ForeColor = Color.Cyan;
            combBtn1.Location = new Point(128, 84);
            combBtn1.Name = "combBtn1";
            combBtn1.PressedColor = Color.Cyan;
            combBtn1.Size = new Size(545, 45);
            combBtn1.TabIndex = 11;
            combBtn1.Text = "Количество перестановок";
            combBtn1.TextAlign = HorizontalAlignment.Left;
            // 
            // combHeader
            // 
            combHeader.AutoSize = true;
            combHeader.Font = new Font("Bahnschrift", 26F, FontStyle.Regular, GraphicsUnit.Point);
            combHeader.ForeColor = Color.Silver;
            combHeader.Location = new Point(265, 10);
            combHeader.Name = "combHeader";
            combHeader.Size = new Size(271, 42);
            combHeader.TabIndex = 4;
            combHeader.Text = "Комбинаторика";
            // 
            // divPanel
            // 
            divPanel.Controls.Add(divBtn1);
            divPanel.Controls.Add(divHeader);
            divPanel.Location = new Point(0, 0);
            divPanel.Name = "divPanel";
            divPanel.Size = new Size(800, 550);
            divPanel.TabIndex = 12;
            // 
            // divBtn1
            // 
            divBtn1.Animated = true;
            divBtn1.Cursor = Cursors.Hand;
            divBtn1.DisabledState.BorderColor = Color.DarkGray;
            divBtn1.DisabledState.CustomBorderColor = Color.DarkGray;
            divBtn1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            divBtn1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            divBtn1.FillColor = Color.FromArgb(25, 40, 65);
            divBtn1.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            divBtn1.ForeColor = Color.LightGray;
            divBtn1.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            divBtn1.HoverState.ForeColor = Color.Cyan;
            divBtn1.Location = new Point(128, 84);
            divBtn1.Name = "divBtn1";
            divBtn1.PressedColor = Color.Cyan;
            divBtn1.Size = new Size(545, 45);
            divBtn1.TabIndex = 12;
            divBtn1.Text = "Разложение числа на делители";
            divBtn1.TextAlign = HorizontalAlignment.Left;
            // 
            // divHeader
            // 
            divHeader.AutoSize = true;
            divHeader.Font = new Font("Bahnschrift", 26F, FontStyle.Regular, GraphicsUnit.Point);
            divHeader.ForeColor = Color.Silver;
            divHeader.Location = new Point(303, 10);
            divHeader.Name = "divHeader";
            divHeader.Size = new Size(194, 42);
            divHeader.TabIndex = 5;
            divHeader.Text = "Делимость";
            // 
            // startingPanel
            // 
            startingPanel.Controls.Add(menuBtn4);
            startingPanel.Controls.Add(menuBtn3);
            startingPanel.Controls.Add(menuBtn2);
            startingPanel.Controls.Add(menuBtn1);
            startingPanel.Controls.Add(menuHeader);
            startingPanel.Location = new Point(0, 0);
            startingPanel.Name = "startingPanel";
            startingPanel.Size = new Size(800, 550);
            startingPanel.TabIndex = 13;
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
            backBtn.TabIndex = 12;
            backBtn.Click += backBtn_Click;
            // 
            // DM
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 40, 65);
            Controls.Add(backBtn);
            Controls.Add(startingPanel);
            Controls.Add(divPanel);
            Controls.Add(combPanel);
            Controls.Add(setsPanel);
            Controls.Add(logicPanel);
            Font = new Font("Bahnschrift", 11.5F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DM";
            Size = new Size(800, 550);
            logicPanel.ResumeLayout(false);
            logicPanel.PerformLayout();
            setsPanel.ResumeLayout(false);
            setsPanel.PerformLayout();
            combPanel.ResumeLayout(false);
            combPanel.PerformLayout();
            divPanel.ResumeLayout(false);
            divPanel.PerformLayout();
            startingPanel.ResumeLayout(false);
            startingPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label menuHeader;
        private Siticone.Desktop.UI.WinForms.SiticoneButton menuBtn2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton menuBtn1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton menuBtn3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton menuBtn4;
        private Panel logicPanel;
        private Label logicHeader;
        private Siticone.Desktop.UI.WinForms.SiticoneButton logicBtn1;
        private Panel setsPanel;
        private Label setsHeader;
        private Siticone.Desktop.UI.WinForms.SiticoneButton setsBtn1;
        private Panel combPanel;
        private Panel divPanel;
        private Panel startingPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton divBtn1;
        private Label divHeader;
        private Siticone.Desktop.UI.WinForms.SiticoneButton combBtn1;
        private Label combHeader;
        private Siticone.Desktop.UI.WinForms.SiticoneButton backBtn;
    }
}
