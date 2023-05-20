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
    public partial class AaG : UserControl
    {
        public AaG()
        {
            InitializeComponent();
            backBtn.Hide();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            matrixPanel.BringToFront();
            backBtn.BringToFront();
            backBtn.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            backBtn.Hide();
            startingPanel.BringToFront();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            vectorPanel.BringToFront();
            backBtn.BringToFront();
            backBtn.Show();
        }

        private void matrixBtn1_Click(object sender, EventArgs e)
        {
            UniversalCalcForm calcForm = new UniversalCalcForm();
            calcForm.Show();
        }
    }
}
