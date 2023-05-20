namespace Calc
{
    partial class Calc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calc));
            siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            siticoneControlBox3 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            InfoBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            SettingsBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            GraphicsBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            DMBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            MABtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            AaGBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            SearchBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            pictureBox1 = new PictureBox();
            PanelSlider = new Panel();
            version = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // siticoneControlBox1
            // 
            siticoneControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            siticoneControlBox1.BackColor = Color.Transparent;
            siticoneControlBox1.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            siticoneControlBox1.FillColor = Color.FromArgb(25, 40, 65);
            siticoneControlBox1.HoverState.FillColor = Color.FromArgb(128, 60, 60);
            siticoneControlBox1.IconColor = Color.Silver;
            siticoneControlBox1.Location = new Point(1060, 4);
            siticoneControlBox1.Name = "siticoneControlBox1";
            siticoneControlBox1.Size = new Size(45, 27);
            siticoneControlBox1.TabIndex = 0;
            // 
            // siticoneControlBox2
            // 
            siticoneControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            siticoneControlBox2.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            siticoneControlBox2.FillColor = Color.FromArgb(25, 40, 65);
            siticoneControlBox2.HoverState.FillColor = Color.FromArgb(28, 46, 74);
            siticoneControlBox2.IconColor = Color.Silver;
            siticoneControlBox2.Location = new Point(970, 4);
            siticoneControlBox2.Name = "siticoneControlBox2";
            siticoneControlBox2.Size = new Size(45, 27);
            siticoneControlBox2.TabIndex = 1;
            // 
            // siticoneControlBox3
            // 
            siticoneControlBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            siticoneControlBox3.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            siticoneControlBox3.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MaximizeBox;
            siticoneControlBox3.FillColor = Color.FromArgb(25, 40, 65);
            siticoneControlBox3.HoverState.FillColor = Color.FromArgb(28, 46, 74);
            siticoneControlBox3.IconColor = Color.Silver;
            siticoneControlBox3.Location = new Point(1015, 4);
            siticoneControlBox3.Name = "siticoneControlBox3";
            siticoneControlBox3.Size = new Size(45, 27);
            siticoneControlBox3.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 25);
            panel1.TabIndex = 2;
            panel1.MouseDown += mouse_Down;
            panel1.MouseMove += mouse_Move;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(21, 34, 56);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 683);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(InfoBtn);
            panel3.Controls.Add(SettingsBtn);
            panel3.Controls.Add(GraphicsBtn);
            panel3.Controls.Add(DMBtn);
            panel3.Controls.Add(MABtn);
            panel3.Controls.Add(AaGBtn);
            panel3.Controls.Add(SearchBtn);
            panel3.Location = new Point(0, 183);
            panel3.Name = "panel3";
            panel3.Size = new Size(228, 461);
            panel3.TabIndex = 5;
            // 
            // InfoBtn
            // 
            InfoBtn.Animated = true;
            InfoBtn.BorderColor = Color.Transparent;
            InfoBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            InfoBtn.CheckedState.CustomBorderColor = Color.Cyan;
            InfoBtn.CheckedState.FillColor = Color.FromArgb(25, 40, 65);
            InfoBtn.CheckedState.ForeColor = Color.Cyan;
            InfoBtn.CheckedState.Image = Properties.Resources.info_cyan;
            InfoBtn.Cursor = Cursors.Hand;
            InfoBtn.CustomBorderThickness = new Padding(2, 0, 0, 0);
            InfoBtn.DisabledState.BorderColor = Color.DarkGray;
            InfoBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            InfoBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            InfoBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            InfoBtn.Dock = DockStyle.Top;
            InfoBtn.FillColor = Color.FromArgb(21, 34, 56);
            InfoBtn.Font = new Font("Bahnschrift", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            InfoBtn.ForeColor = Color.Silver;
            InfoBtn.HoverState.CustomBorderColor = Color.White;
            InfoBtn.HoverState.FillColor = Color.FromArgb(25, 40, 65);
            InfoBtn.HoverState.ForeColor = Color.White;
            InfoBtn.HoverState.Image = Properties.Resources.info_white;
            InfoBtn.Image = Properties.Resources.info_gray;
            InfoBtn.ImageAlign = HorizontalAlignment.Left;
            InfoBtn.ImageOffset = new Point(8, 0);
            InfoBtn.Location = new Point(0, 330);
            InfoBtn.Name = "InfoBtn";
            InfoBtn.Size = new Size(228, 55);
            InfoBtn.TabIndex = 10;
            InfoBtn.Text = "О программе";
            InfoBtn.TextAlign = HorizontalAlignment.Left;
            InfoBtn.TextOffset = new Point(15, 0);
            InfoBtn.Click += InfoBtn_Click;
            // 
            // SettingsBtn
            // 
            SettingsBtn.Animated = true;
            SettingsBtn.BorderColor = Color.Transparent;
            SettingsBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            SettingsBtn.CheckedState.CustomBorderColor = Color.Cyan;
            SettingsBtn.CheckedState.FillColor = Color.FromArgb(25, 40, 65);
            SettingsBtn.CheckedState.ForeColor = Color.Cyan;
            SettingsBtn.CheckedState.Image = Properties.Resources.settings_cyan;
            SettingsBtn.Cursor = Cursors.Hand;
            SettingsBtn.CustomBorderThickness = new Padding(2, 0, 0, 0);
            SettingsBtn.DisabledState.BorderColor = Color.DarkGray;
            SettingsBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            SettingsBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SettingsBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SettingsBtn.Dock = DockStyle.Top;
            SettingsBtn.FillColor = Color.FromArgb(21, 34, 56);
            SettingsBtn.Font = new Font("Bahnschrift", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            SettingsBtn.ForeColor = Color.Silver;
            SettingsBtn.HoverState.CustomBorderColor = Color.White;
            SettingsBtn.HoverState.FillColor = Color.FromArgb(25, 40, 65);
            SettingsBtn.HoverState.ForeColor = Color.White;
            SettingsBtn.HoverState.Image = Properties.Resources.settings_white;
            SettingsBtn.Image = Properties.Resources.settings_gray;
            SettingsBtn.ImageAlign = HorizontalAlignment.Left;
            SettingsBtn.ImageOffset = new Point(8, 0);
            SettingsBtn.Location = new Point(0, 275);
            SettingsBtn.Name = "SettingsBtn";
            SettingsBtn.Size = new Size(228, 55);
            SettingsBtn.TabIndex = 9;
            SettingsBtn.Text = "Настройки";
            SettingsBtn.TextAlign = HorizontalAlignment.Left;
            SettingsBtn.TextOffset = new Point(15, 0);
            SettingsBtn.Click += SettingsBtn_Click;
            // 
            // GraphicsBtn
            // 
            GraphicsBtn.Animated = true;
            GraphicsBtn.BorderColor = Color.Transparent;
            GraphicsBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            GraphicsBtn.CheckedState.CustomBorderColor = Color.Cyan;
            GraphicsBtn.CheckedState.FillColor = Color.FromArgb(25, 40, 65);
            GraphicsBtn.CheckedState.ForeColor = Color.Cyan;
            GraphicsBtn.CheckedState.Image = Properties.Resources.graph_cyan;
            GraphicsBtn.Cursor = Cursors.Hand;
            GraphicsBtn.CustomBorderThickness = new Padding(2, 0, 0, 0);
            GraphicsBtn.DisabledState.BorderColor = Color.DarkGray;
            GraphicsBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            GraphicsBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            GraphicsBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            GraphicsBtn.Dock = DockStyle.Top;
            GraphicsBtn.FillColor = Color.FromArgb(21, 34, 56);
            GraphicsBtn.Font = new Font("Bahnschrift", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            GraphicsBtn.ForeColor = Color.Silver;
            GraphicsBtn.HoverState.CustomBorderColor = Color.White;
            GraphicsBtn.HoverState.FillColor = Color.FromArgb(25, 40, 65);
            GraphicsBtn.HoverState.ForeColor = Color.White;
            GraphicsBtn.HoverState.Image = Properties.Resources.graph_white;
            GraphicsBtn.Image = Properties.Resources.graph_gray;
            GraphicsBtn.ImageAlign = HorizontalAlignment.Left;
            GraphicsBtn.ImageOffset = new Point(8, 0);
            GraphicsBtn.Location = new Point(0, 220);
            GraphicsBtn.Name = "GraphicsBtn";
            GraphicsBtn.Size = new Size(228, 55);
            GraphicsBtn.TabIndex = 8;
            GraphicsBtn.Text = "Графики";
            GraphicsBtn.TextAlign = HorizontalAlignment.Left;
            GraphicsBtn.TextOffset = new Point(15, 0);
            GraphicsBtn.Click += GraphicsBtn_Click;
            // 
            // DMBtn
            // 
            DMBtn.Animated = true;
            DMBtn.BorderColor = Color.Transparent;
            DMBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            DMBtn.CheckedState.CustomBorderColor = Color.Cyan;
            DMBtn.CheckedState.FillColor = Color.FromArgb(25, 40, 65);
            DMBtn.CheckedState.ForeColor = Color.Cyan;
            DMBtn.CheckedState.Image = Properties.Resources.dashboard_cyan;
            DMBtn.Cursor = Cursors.Hand;
            DMBtn.CustomBorderThickness = new Padding(2, 0, 0, 0);
            DMBtn.DisabledState.BorderColor = Color.DarkGray;
            DMBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            DMBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            DMBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            DMBtn.Dock = DockStyle.Top;
            DMBtn.FillColor = Color.FromArgb(21, 34, 56);
            DMBtn.Font = new Font("Bahnschrift", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            DMBtn.ForeColor = Color.Silver;
            DMBtn.HoverState.CustomBorderColor = Color.White;
            DMBtn.HoverState.FillColor = Color.FromArgb(25, 40, 65);
            DMBtn.HoverState.ForeColor = Color.White;
            DMBtn.HoverState.Image = Properties.Resources.dashboard_white;
            DMBtn.Image = Properties.Resources.dashboard_gray;
            DMBtn.ImageAlign = HorizontalAlignment.Left;
            DMBtn.ImageOffset = new Point(8, 0);
            DMBtn.Location = new Point(0, 165);
            DMBtn.Name = "DMBtn";
            DMBtn.Size = new Size(228, 55);
            DMBtn.TabIndex = 7;
            DMBtn.Text = "Дискретная математика";
            DMBtn.TextAlign = HorizontalAlignment.Left;
            DMBtn.TextOffset = new Point(15, 0);
            DMBtn.Click += DMBtn_Click;
            // 
            // MABtn
            // 
            MABtn.Animated = true;
            MABtn.BorderColor = Color.Transparent;
            MABtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            MABtn.CheckedState.CustomBorderColor = Color.Cyan;
            MABtn.CheckedState.FillColor = Color.FromArgb(25, 40, 65);
            MABtn.CheckedState.ForeColor = Color.Cyan;
            MABtn.CheckedState.Image = Properties.Resources.dashboard_cyan;
            MABtn.Cursor = Cursors.Hand;
            MABtn.CustomBorderThickness = new Padding(2, 0, 0, 0);
            MABtn.DisabledState.BorderColor = Color.DarkGray;
            MABtn.DisabledState.CustomBorderColor = Color.DarkGray;
            MABtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            MABtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            MABtn.Dock = DockStyle.Top;
            MABtn.FillColor = Color.FromArgb(21, 34, 56);
            MABtn.Font = new Font("Bahnschrift", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            MABtn.ForeColor = Color.Silver;
            MABtn.HoverState.CustomBorderColor = Color.White;
            MABtn.HoverState.FillColor = Color.FromArgb(25, 40, 65);
            MABtn.HoverState.ForeColor = Color.White;
            MABtn.HoverState.Image = Properties.Resources.dashboard_white;
            MABtn.Image = Properties.Resources.dashboard_gray;
            MABtn.ImageAlign = HorizontalAlignment.Left;
            MABtn.ImageOffset = new Point(8, 0);
            MABtn.Location = new Point(0, 110);
            MABtn.Name = "MABtn";
            MABtn.Size = new Size(228, 55);
            MABtn.TabIndex = 6;
            MABtn.Text = "Математический анализ";
            MABtn.TextAlign = HorizontalAlignment.Left;
            MABtn.TextOffset = new Point(15, 0);
            MABtn.Click += MABtn_Click;
            // 
            // AaGBtn
            // 
            AaGBtn.Animated = true;
            AaGBtn.BorderColor = Color.Transparent;
            AaGBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            AaGBtn.CheckedState.CustomBorderColor = Color.Cyan;
            AaGBtn.CheckedState.FillColor = Color.FromArgb(25, 40, 65);
            AaGBtn.CheckedState.ForeColor = Color.Cyan;
            AaGBtn.CheckedState.Image = Properties.Resources.dashboard_cyan;
            AaGBtn.Cursor = Cursors.Hand;
            AaGBtn.CustomBorderThickness = new Padding(2, 0, 0, 0);
            AaGBtn.DisabledState.BorderColor = Color.DarkGray;
            AaGBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            AaGBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AaGBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AaGBtn.Dock = DockStyle.Top;
            AaGBtn.FillColor = Color.FromArgb(21, 34, 56);
            AaGBtn.Font = new Font("Bahnschrift", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            AaGBtn.ForeColor = Color.Silver;
            AaGBtn.HoverState.CustomBorderColor = Color.White;
            AaGBtn.HoverState.FillColor = Color.FromArgb(25, 40, 65);
            AaGBtn.HoverState.ForeColor = Color.White;
            AaGBtn.HoverState.Image = Properties.Resources.dashboard_white;
            AaGBtn.Image = Properties.Resources.dashboard_gray;
            AaGBtn.ImageAlign = HorizontalAlignment.Left;
            AaGBtn.ImageOffset = new Point(8, 0);
            AaGBtn.Location = new Point(0, 55);
            AaGBtn.Name = "AaGBtn";
            AaGBtn.Size = new Size(228, 55);
            AaGBtn.TabIndex = 5;
            AaGBtn.Text = "Алгебра и геометрия";
            AaGBtn.TextAlign = HorizontalAlignment.Left;
            AaGBtn.TextOffset = new Point(15, 0);
            AaGBtn.Click += AaGBtn_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.Animated = true;
            SearchBtn.BorderColor = Color.Transparent;
            SearchBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            SearchBtn.CheckedState.CustomBorderColor = Color.Cyan;
            SearchBtn.CheckedState.FillColor = Color.FromArgb(25, 40, 65);
            SearchBtn.CheckedState.ForeColor = Color.Cyan;
            SearchBtn.CheckedState.Image = Properties.Resources.search_cyan;
            SearchBtn.Cursor = Cursors.Hand;
            SearchBtn.CustomBorderThickness = new Padding(2, 0, 0, 0);
            SearchBtn.DisabledState.BorderColor = Color.DarkGray;
            SearchBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            SearchBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SearchBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SearchBtn.Dock = DockStyle.Top;
            SearchBtn.FillColor = Color.FromArgb(21, 34, 56);
            SearchBtn.Font = new Font("Bahnschrift", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBtn.ForeColor = Color.Silver;
            SearchBtn.HoverState.CustomBorderColor = Color.White;
            SearchBtn.HoverState.FillColor = Color.FromArgb(25, 40, 65);
            SearchBtn.HoverState.ForeColor = Color.White;
            SearchBtn.HoverState.Image = Properties.Resources.search_white;
            SearchBtn.Image = Properties.Resources.search_gray;
            SearchBtn.ImageAlign = HorizontalAlignment.Left;
            SearchBtn.ImageOffset = new Point(8, 0);
            SearchBtn.Location = new Point(0, 0);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(228, 55);
            SearchBtn.TabIndex = 4;
            SearchBtn.Text = "Поиск";
            SearchBtn.TextAlign = HorizontalAlignment.Left;
            SearchBtn.TextOffset = new Point(15, 0);
            SearchBtn.Click += SearchBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(4, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // PanelSlider
            // 
            PanelSlider.Location = new Point(270, 78);
            PanelSlider.Name = "PanelSlider";
            PanelSlider.Size = new Size(800, 550);
            PanelSlider.TabIndex = 4;
            // 
            // version
            // 
            version.AutoSize = true;
            version.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            version.ForeColor = Color.FromArgb(48, 74, 117);
            version.Location = new Point(981, 681);
            version.Name = "version";
            version.Size = new Size(116, 18);
            version.TabIndex = 5;
            version.Text = "pre-alfa version";
            // 
            // Calc
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 40, 65);
            ClientSize = new Size(1109, 708);
            Controls.Add(version);
            Controls.Add(PanelSlider);
            Controls.Add(panel2);
            Controls.Add(siticoneControlBox3);
            Controls.Add(siticoneControlBox2);
            Controls.Add(siticoneControlBox1);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calc";
            Opacity = 0.97D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calc";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox3;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton InfoBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SettingsBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton GraphicsBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton DMBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton MABtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton AaGBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SearchBtn;
        private Panel PanelSlider;
        private Label version;
    }
}