using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc.UserControls
{
    public partial class MA : UserControl
    {
        public MA()
        {
            InitializeComponent();
            backBtn.Hide();
        }

        private void menuBtn1_Click(object sender, EventArgs e)
        {
            complexPanel.BringToFront();
            backBtn.BringToFront();
            backBtn.Show();
        }

        private void menuBtn2_Click(object sender, EventArgs e)
        {
            limPanel.BringToFront();
            backBtn.BringToFront();
            backBtn.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            backBtn.Hide();
            startingPanel.BringToFront();
        }
    }
}
