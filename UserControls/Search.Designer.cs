namespace Calc.UserControls
{
    partial class Search
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
            header = new Label();
            SearchBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            SearchPanel = new Panel();
            siticoneButton13 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneButton12 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneButton11 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneButton10 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneButton9 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneButton8 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneButton7 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneButton6 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneButton5 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneButton4 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneButton3 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            SearchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.AutoSize = true;
            header.Font = new Font("Bahnschrift", 26F, FontStyle.Regular, GraphicsUnit.Point);
            header.ForeColor = Color.Silver;
            header.Location = new Point(148, 10);
            header.Name = "header";
            header.Size = new Size(504, 42);
            header.TabIndex = 0;
            header.Text = "Поиск по всем калькуляторам";
            // 
            // SearchBox
            // 
            SearchBox.BorderColor = Color.FromArgb(35, 57, 93);
            SearchBox.BorderRadius = 4;
            SearchBox.BorderThickness = 2;
            SearchBox.DefaultText = "";
            SearchBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            SearchBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            SearchBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            SearchBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            SearchBox.FillColor = Color.FromArgb(25, 40, 65);
            SearchBox.FocusedState.BorderColor = Color.White;
            SearchBox.FocusedState.FillColor = Color.White;
            SearchBox.FocusedState.ForeColor = Color.Black;
            SearchBox.FocusedState.PlaceholderForeColor = Color.Black;
            SearchBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBox.ForeColor = Color.Black;
            SearchBox.HoverState.BorderColor = Color.FromArgb(35, 57, 93);
            SearchBox.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            SearchBox.HoverState.ForeColor = Color.White;
            SearchBox.HoverState.PlaceholderForeColor = Color.White;
            SearchBox.IconLeft = Properties.Resources.search_gray;
            SearchBox.IconLeftOffset = new Point(10, 0);
            SearchBox.Location = new Point(148, 69);
            SearchBox.Name = "SearchBox";
            SearchBox.PasswordChar = '\0';
            SearchBox.PlaceholderForeColor = Color.Silver;
            SearchBox.PlaceholderText = "введите нужный калькулятор...";
            SearchBox.SelectedText = "";
            SearchBox.Size = new Size(504, 36);
            SearchBox.TabIndex = 1;
            SearchBox.TextOffset = new Point(5, 0);
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // SearchPanel
            // 
            SearchPanel.AutoScroll = true;
            SearchPanel.Controls.Add(siticoneButton13);
            SearchPanel.Controls.Add(siticoneButton12);
            SearchPanel.Controls.Add(siticoneButton11);
            SearchPanel.Controls.Add(siticoneButton10);
            SearchPanel.Controls.Add(siticoneButton9);
            SearchPanel.Controls.Add(siticoneButton8);
            SearchPanel.Controls.Add(siticoneButton7);
            SearchPanel.Controls.Add(siticoneButton6);
            SearchPanel.Controls.Add(siticoneButton5);
            SearchPanel.Controls.Add(siticoneButton4);
            SearchPanel.Controls.Add(siticoneButton3);
            SearchPanel.Controls.Add(siticoneButton2);
            SearchPanel.Controls.Add(siticoneButton1);
            SearchPanel.Location = new Point(119, 120);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(562, 430);
            SearchPanel.TabIndex = 2;
            // 
            // siticoneButton13
            // 
            siticoneButton13.Animated = true;
            siticoneButton13.Cursor = Cursors.Hand;
            siticoneButton13.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton13.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton13.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton13.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton13.Dock = DockStyle.Top;
            siticoneButton13.FillColor = Color.FromArgb(25, 40, 65);
            siticoneButton13.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton13.ForeColor = Color.LightGray;
            siticoneButton13.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            siticoneButton13.HoverState.ForeColor = Color.Cyan;
            siticoneButton13.Location = new Point(0, 540);
            siticoneButton13.Name = "siticoneButton13";
            siticoneButton13.PressedColor = Color.Cyan;
            siticoneButton13.Size = new Size(545, 45);
            siticoneButton13.TabIndex = 12;
            siticoneButton13.Text = "Решение СЛУ и ОСЛУ";
            siticoneButton13.TextAlign = HorizontalAlignment.Left;
            // 
            // siticoneButton12
            // 
            siticoneButton12.Animated = true;
            siticoneButton12.Cursor = Cursors.Hand;
            siticoneButton12.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton12.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton12.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton12.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton12.Dock = DockStyle.Top;
            siticoneButton12.FillColor = Color.FromArgb(25, 40, 65);
            siticoneButton12.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton12.ForeColor = Color.LightGray;
            siticoneButton12.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            siticoneButton12.HoverState.ForeColor = Color.Cyan;
            siticoneButton12.Location = new Point(0, 495);
            siticoneButton12.Name = "siticoneButton12";
            siticoneButton12.PressedColor = Color.Cyan;
            siticoneButton12.Size = new Size(545, 45);
            siticoneButton12.TabIndex = 11;
            siticoneButton12.Text = "Привести матрицу элементарными преобразованиями столбцов к улучшенному ступенчатому виду";
            siticoneButton12.TextAlign = HorizontalAlignment.Left;
            // 
            // siticoneButton11
            // 
            siticoneButton11.Animated = true;
            siticoneButton11.Cursor = Cursors.Hand;
            siticoneButton11.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton11.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton11.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton11.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton11.Dock = DockStyle.Top;
            siticoneButton11.FillColor = Color.FromArgb(25, 40, 65);
            siticoneButton11.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton11.ForeColor = Color.LightGray;
            siticoneButton11.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            siticoneButton11.HoverState.ForeColor = Color.Cyan;
            siticoneButton11.Location = new Point(0, 450);
            siticoneButton11.Name = "siticoneButton11";
            siticoneButton11.PressedColor = Color.Cyan;
            siticoneButton11.Size = new Size(545, 45);
            siticoneButton11.TabIndex = 10;
            siticoneButton11.Text = "Привести матрицу элементарными преобразованиями строк к ступенчатому виду";
            siticoneButton11.TextAlign = HorizontalAlignment.Left;
            // 
            // siticoneButton10
            // 
            siticoneButton10.Animated = true;
            siticoneButton10.Cursor = Cursors.Hand;
            siticoneButton10.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton10.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton10.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton10.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton10.Dock = DockStyle.Top;
            siticoneButton10.FillColor = Color.FromArgb(25, 40, 65);
            siticoneButton10.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton10.ForeColor = Color.LightGray;
            siticoneButton10.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            siticoneButton10.HoverState.ForeColor = Color.Cyan;
            siticoneButton10.Location = new Point(0, 405);
            siticoneButton10.Name = "siticoneButton10";
            siticoneButton10.PressedColor = Color.Cyan;
            siticoneButton10.Size = new Size(545, 45);
            siticoneButton10.TabIndex = 9;
            siticoneButton10.Text = "Привести матрицу элементарными преобразованиями строк к улучшенному ступенчатому виду чение из матрицы списка столбцов";
            siticoneButton10.TextAlign = HorizontalAlignment.Left;
            // 
            // siticoneButton9
            // 
            siticoneButton9.Animated = true;
            siticoneButton9.Cursor = Cursors.Hand;
            siticoneButton9.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton9.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton9.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton9.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton9.Dock = DockStyle.Top;
            siticoneButton9.FillColor = Color.FromArgb(25, 40, 65);
            siticoneButton9.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton9.ForeColor = Color.LightGray;
            siticoneButton9.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            siticoneButton9.HoverState.ForeColor = Color.Cyan;
            siticoneButton9.Location = new Point(0, 360);
            siticoneButton9.Name = "siticoneButton9";
            siticoneButton9.PressedColor = Color.Cyan;
            siticoneButton9.Size = new Size(545, 45);
            siticoneButton9.TabIndex = 8;
            siticoneButton9.Text = "Изменение элемента матрицы";
            siticoneButton9.TextAlign = HorizontalAlignment.Left;
            // 
            // siticoneButton8
            // 
            siticoneButton8.Animated = true;
            siticoneButton8.Cursor = Cursors.Hand;
            siticoneButton8.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton8.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton8.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton8.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton8.Dock = DockStyle.Top;
            siticoneButton8.FillColor = Color.FromArgb(25, 40, 65);
            siticoneButton8.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton8.ForeColor = Color.LightGray;
            siticoneButton8.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            siticoneButton8.HoverState.ForeColor = Color.Cyan;
            siticoneButton8.Location = new Point(0, 315);
            siticoneButton8.Name = "siticoneButton8";
            siticoneButton8.PressedColor = Color.Cyan;
            siticoneButton8.Size = new Size(545, 45);
            siticoneButton8.TabIndex = 7;
            siticoneButton8.Text = "Извлечение из матрицы списка строк     ";
            siticoneButton8.TextAlign = HorizontalAlignment.Left;
            // 
            // siticoneButton7
            // 
            siticoneButton7.Animated = true;
            siticoneButton7.Cursor = Cursors.Hand;
            siticoneButton7.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton7.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton7.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton7.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton7.Dock = DockStyle.Top;
            siticoneButton7.FillColor = Color.FromArgb(25, 40, 65);
            siticoneButton7.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton7.ForeColor = Color.LightGray;
            siticoneButton7.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            siticoneButton7.HoverState.ForeColor = Color.Cyan;
            siticoneButton7.Location = new Point(0, 270);
            siticoneButton7.Name = "siticoneButton7";
            siticoneButton7.PressedColor = Color.Cyan;
            siticoneButton7.Size = new Size(545, 45);
            siticoneButton7.TabIndex = 6;
            siticoneButton7.Text = "Извлечение из матрицы списка столбцов";
            siticoneButton7.TextAlign = HorizontalAlignment.Left;
            // 
            // siticoneButton6
            // 
            siticoneButton6.Animated = true;
            siticoneButton6.Cursor = Cursors.Hand;
            siticoneButton6.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton6.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton6.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton6.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton6.Dock = DockStyle.Top;
            siticoneButton6.FillColor = Color.FromArgb(25, 40, 65);
            siticoneButton6.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton6.ForeColor = Color.LightGray;
            siticoneButton6.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            siticoneButton6.HoverState.ForeColor = Color.Cyan;
            siticoneButton6.Location = new Point(0, 225);
            siticoneButton6.Name = "siticoneButton6";
            siticoneButton6.PressedColor = Color.Cyan;
            siticoneButton6.Size = new Size(545, 45);
            siticoneButton6.TabIndex = 5;
            siticoneButton6.Text = "Извлечение из матрицы строки";
            siticoneButton6.TextAlign = HorizontalAlignment.Left;
            // 
            // siticoneButton5
            // 
            siticoneButton5.Animated = true;
            siticoneButton5.Cursor = Cursors.Hand;
            siticoneButton5.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton5.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton5.Dock = DockStyle.Top;
            siticoneButton5.FillColor = Color.FromArgb(25, 40, 65);
            siticoneButton5.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton5.ForeColor = Color.LightGray;
            siticoneButton5.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            siticoneButton5.HoverState.ForeColor = Color.Cyan;
            siticoneButton5.Location = new Point(0, 180);
            siticoneButton5.Name = "siticoneButton5";
            siticoneButton5.PressedColor = Color.Cyan;
            siticoneButton5.Size = new Size(545, 45);
            siticoneButton5.TabIndex = 4;
            siticoneButton5.Text = "Извлечение из матрицы столбца";
            siticoneButton5.TextAlign = HorizontalAlignment.Left;
            // 
            // siticoneButton4
            // 
            siticoneButton4.Animated = true;
            siticoneButton4.Cursor = Cursors.Hand;
            siticoneButton4.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton4.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton4.Dock = DockStyle.Top;
            siticoneButton4.FillColor = Color.FromArgb(25, 40, 65);
            siticoneButton4.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton4.ForeColor = Color.LightGray;
            siticoneButton4.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            siticoneButton4.HoverState.ForeColor = Color.Cyan;
            siticoneButton4.Location = new Point(0, 135);
            siticoneButton4.Name = "siticoneButton4";
            siticoneButton4.PressedColor = Color.Cyan;
            siticoneButton4.Size = new Size(545, 45);
            siticoneButton4.TabIndex = 3;
            siticoneButton4.Text = "Извлечение из матрицы элемента";
            siticoneButton4.TextAlign = HorizontalAlignment.Left;
            // 
            // siticoneButton3
            // 
            siticoneButton3.Animated = true;
            siticoneButton3.Cursor = Cursors.Hand;
            siticoneButton3.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton3.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton3.Dock = DockStyle.Top;
            siticoneButton3.FillColor = Color.FromArgb(25, 40, 65);
            siticoneButton3.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton3.ForeColor = Color.LightGray;
            siticoneButton3.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            siticoneButton3.HoverState.ForeColor = Color.Cyan;
            siticoneButton3.Location = new Point(0, 90);
            siticoneButton3.Name = "siticoneButton3";
            siticoneButton3.PressedColor = Color.Cyan;
            siticoneButton3.Size = new Size(545, 45);
            siticoneButton3.TabIndex = 2;
            siticoneButton3.Text = "Составление матрицы из элементов";
            siticoneButton3.TextAlign = HorizontalAlignment.Left;
            // 
            // siticoneButton2
            // 
            siticoneButton2.Animated = true;
            siticoneButton2.Cursor = Cursors.Hand;
            siticoneButton2.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton2.Dock = DockStyle.Top;
            siticoneButton2.FillColor = Color.FromArgb(25, 40, 65);
            siticoneButton2.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton2.ForeColor = Color.LightGray;
            siticoneButton2.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            siticoneButton2.HoverState.ForeColor = Color.Cyan;
            siticoneButton2.Location = new Point(0, 45);
            siticoneButton2.Name = "siticoneButton2";
            siticoneButton2.PressedColor = Color.Cyan;
            siticoneButton2.Size = new Size(545, 45);
            siticoneButton2.TabIndex = 1;
            siticoneButton2.Text = "Составление матрицы из векторов в горизонтальном виде";
            siticoneButton2.TextAlign = HorizontalAlignment.Left;
            // 
            // siticoneButton1
            // 
            siticoneButton1.Animated = true;
            siticoneButton1.Cursor = Cursors.Hand;
            siticoneButton1.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton1.Dock = DockStyle.Top;
            siticoneButton1.FillColor = Color.FromArgb(25, 40, 65);
            siticoneButton1.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton1.ForeColor = Color.LightGray;
            siticoneButton1.HoverState.FillColor = Color.FromArgb(35, 57, 93);
            siticoneButton1.HoverState.ForeColor = Color.Cyan;
            siticoneButton1.Location = new Point(0, 0);
            siticoneButton1.Name = "siticoneButton1";
            siticoneButton1.PressedColor = Color.Cyan;
            siticoneButton1.Size = new Size(545, 45);
            siticoneButton1.TabIndex = 0;
            siticoneButton1.Text = "Составление матрицы из векторов в вертикальном виде";
            siticoneButton1.TextAlign = HorizontalAlignment.Left;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 40, 65);
            Controls.Add(SearchPanel);
            Controls.Add(SearchBox);
            Controls.Add(header);
            Font = new Font("Bahnschrift", 11.5F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Search";
            Size = new Size(800, 550);
            SearchPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label header;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox SearchBox;
        private Panel SearchPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton4;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton5;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton6;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton13;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton12;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton11;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton10;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton9;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton8;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton7;
    }
}
