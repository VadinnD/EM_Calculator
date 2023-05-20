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
    public partial class DM : UserControl
    {
        public DM()
        {
            InitializeComponent();
            backBtn.Hide();
        }

        private void menuBtn1_Click(object sender, EventArgs e)
        {
            logicPanel.BringToFront();
            backBtn.BringToFront();
            backBtn.Show();
        }

        private void menuBtn2_Click(object sender, EventArgs e)
        {
            setsPanel.BringToFront();
            backBtn.BringToFront();
            backBtn.Show();
        }

        private void menuBtn3_Click(object sender, EventArgs e)
        {
            combPanel.BringToFront();
            backBtn.BringToFront();
            backBtn.Show();
        }

        private void menuBtn4_Click(object sender, EventArgs e)
        {
            divPanel.BringToFront();
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
