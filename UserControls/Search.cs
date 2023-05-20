using Siticone.Desktop.UI.WinForms;
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
    public partial class Search : UserControl
    {

        private readonly IEnumerable<SiticoneButton> SearchButtons;

        public Search()
        {
            InitializeComponent();

            SearchButtons = SearchPanel.Controls.OfType<SiticoneButton>();

            SearchBox.TextChanged += SearchBox_TextChanged;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            foreach (SiticoneButton button in SearchButtons)
            {
                if (button.Text.ToLower().Contains(SearchBox.Text.ToLower()))
                {
                    button.Show();
                }
                else
                {
                    button.Hide();
                    continue;
                }
            }
        }
    }
}
