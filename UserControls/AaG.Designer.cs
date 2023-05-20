namespace Calc.UserControls
{
    partial class AaG
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
            matrixPanel = new Panel();
            matrixBtn1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            matrixHeader = new Label();
            startingPanel = new Panel();
            menuBtn2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            menuBtn1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            header = new Label();
            vectorPanel = new Panel();
            vectorBtn1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            vectorHeader = new Label();
            backBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            matrixPanel.SuspendLayout();
            startingPanel.SuspendLayout();
            vectorPanel.SuspendLayout();
            SuspendLayout();
            // 
            // matrixPanel
            // 
            matrixPanel.Controls.Add(matrixBtn1);
            matrixPanel.Controls.Add(matrixHeader);
            matrixPanel.Location = new Point(0, 0);
            matrixPanel.Name = "matrixPanel";
            matrixPanel.Size = new Size(800, 550);
            matrixPanel.TabIndex = 4;
            // 
            // matrixBtn1
            // 
            matrixBtn1.Animated = true;
            matrixBtn1.Cursor = Cursors.Hand;
            matrixBtn1.DisabledState.BorderColor = Color.DarkGray;
            matrixBtn1.DisabledState.CustomBorderColor = Color.DarkGray;
            matrixBtn1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            matrixBtn1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            matrixBtn1.FillColor = Color.FromArgb(25, 40, 65);
            matrixBtn1.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            matrixBtn1.ForeColor = Color.LightGray;
            matrixBtn1.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            matrixBtn1.HoverState.ForeColor = Color.Cyan;
            matrixBtn1.Location = new Point(128, 84);
            matrixBtn1.Name = "matrixBtn1";
            matrixBtn1.PressedColor = Color.Cyan;
            matrixBtn1.Size = new Size(545, 45);
            matrixBtn1.TabIndex = 4;
            matrixBtn1.Text = "Составление матрицы из векторов в вертикальном виде";
            matrixBtn1.TextAlign = HorizontalAlignment.Left;
            matrixBtn1.Click += matrixBtn1_Click;
            // 
            // matrixHeader
            // 
            matrixHeader.AutoSize = true;
            matrixHeader.Font = new Font("Bahnschrift", 26F, FontStyle.Regular, GraphicsUnit.Point);
            matrixHeader.ForeColor = Color.Silver;
            matrixHeader.Location = new Point(41, 10);
            matrixHeader.Name = "matrixHeader";
            matrixHeader.Size = new Size(719, 42);
            matrixHeader.TabIndex = 4;
            matrixHeader.Text = "Линейная алгебра / Действия с матрицами";
            // 
            // startingPanel
            // 
            startingPanel.Controls.Add(menuBtn2);
            startingPanel.Controls.Add(menuBtn1);
            startingPanel.Controls.Add(header);
            startingPanel.Location = new Point(0, 0);
            startingPanel.Name = "startingPanel";
            startingPanel.Size = new Size(800, 550);
            startingPanel.TabIndex = 5;
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
            menuBtn2.TabIndex = 3;
            menuBtn2.Text = "Векторная алгебра";
            menuBtn2.TextAlign = HorizontalAlignment.Left;
            menuBtn2.Click += siticoneButton2_Click;
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
            menuBtn1.TabIndex = 2;
            menuBtn1.Text = "Линейная алгебра / Действия с матрицами";
            menuBtn1.TextAlign = HorizontalAlignment.Left;
            menuBtn1.Click += siticoneButton1_Click;
            // 
            // header
            // 
            header.AutoSize = true;
            header.Font = new Font("Bahnschrift", 26F, FontStyle.Regular, GraphicsUnit.Point);
            header.ForeColor = Color.Silver;
            header.Location = new Point(221, 10);
            header.Name = "header";
            header.Size = new Size(358, 42);
            header.TabIndex = 1;
            header.Text = "Алгебра и геометрия";
            // 
            // vectorPanel
            // 
            vectorPanel.Controls.Add(vectorBtn1);
            vectorPanel.Controls.Add(vectorHeader);
            vectorPanel.Location = new Point(0, 0);
            vectorPanel.Name = "vectorPanel";
            vectorPanel.Size = new Size(800, 550);
            vectorPanel.TabIndex = 4;
            // 
            // vectorBtn1
            // 
            vectorBtn1.Animated = true;
            vectorBtn1.Cursor = Cursors.Hand;
            vectorBtn1.DisabledState.BorderColor = Color.DarkGray;
            vectorBtn1.DisabledState.CustomBorderColor = Color.DarkGray;
            vectorBtn1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            vectorBtn1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            vectorBtn1.FillColor = Color.FromArgb(25, 40, 65);
            vectorBtn1.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            vectorBtn1.ForeColor = Color.LightGray;
            vectorBtn1.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            vectorBtn1.HoverState.ForeColor = Color.Cyan;
            vectorBtn1.Location = new Point(128, 84);
            vectorBtn1.Name = "vectorBtn1";
            vectorBtn1.PressedColor = Color.Cyan;
            vectorBtn1.Size = new Size(545, 45);
            vectorBtn1.TabIndex = 6;
            vectorBtn1.Text = "Арифметические действия с векторами";
            vectorBtn1.TextAlign = HorizontalAlignment.Left;
            // 
            // vectorHeader
            // 
            vectorHeader.AutoSize = true;
            vectorHeader.Font = new Font("Bahnschrift", 26F, FontStyle.Regular, GraphicsUnit.Point);
            vectorHeader.ForeColor = Color.Silver;
            vectorHeader.Location = new Point(235, 10);
            vectorHeader.Name = "vectorHeader";
            vectorHeader.Size = new Size(330, 42);
            vectorHeader.TabIndex = 5;
            vectorHeader.Text = "Векторная алгебра";
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
            backBtn.TabIndex = 5;
            backBtn.Click += back_Click;
            // 
            // AaG
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 40, 65);
            Controls.Add(backBtn);
            Controls.Add(startingPanel);
            Controls.Add(vectorPanel);
            Controls.Add(matrixPanel);
            Font = new Font("Bahnschrift", 11.5F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AaG";
            Size = new Size(800, 550);
            matrixPanel.ResumeLayout(false);
            matrixPanel.PerformLayout();
            startingPanel.ResumeLayout(false);
            startingPanel.PerformLayout();
            vectorPanel.ResumeLayout(false);
            vectorPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel startingPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton matrixBtn1;
        private Panel matrixPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton backBtn;
        private Label matrixHeader;
        private Panel vectorPanel;
        private Label vectorHeader;
        private Siticone.Desktop.UI.WinForms.SiticoneButton menuBtn2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton menuBtn1;
        private Label header;
        private Siticone.Desktop.UI.WinForms.SiticoneButton vectorBtn1;
    }
}
