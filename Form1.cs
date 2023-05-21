using Calc.UserControls;
using Siticone.Desktop.UI.WinForms;
using System.Runtime.InteropServices;

namespace Calc

{
    public partial class Calc : Form
    {
        public Point mouseLocation;

        public Calc()
        {
            InitializeComponent();

            new SiticoneShadowForm(this);

            // adding user controls to PanelSlider
            PanelSlider.Controls.Add(new AaG());
            PanelSlider.Controls.Add(new DM());
            PanelSlider.Controls.Add(new UserGraphics());
            PanelSlider.Controls.Add(new Info());
            PanelSlider.Controls.Add(new MA());
            PanelSlider.Controls.Add(new Search());
            PanelSlider.Controls.Add(new Settings());

            PanelSlider.Controls.Find("Info", false)[0].BringToFront();
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            PanelSlider.Controls.Find("Search", false)[0].BringToFront();
        }

        private void AaGBtn_Click(object sender, EventArgs e)
        {
            PanelSlider.Controls.Find("AaG", false)[0].BringToFront();
        }
        private void MABtn_Click(object sender, EventArgs e)
        {
            PanelSlider.Controls.Find("MA", false)[0].BringToFront();
        }

        private void DMBtn_Click(object sender, EventArgs e)
        {
            PanelSlider.Controls.Find("DM", false)[0].BringToFront();
        }
        private void GraphicsBtn_Click(object sender, EventArgs e)
        {
            PanelSlider.Controls.Find("UserGraphics", false)[0].BringToFront();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            PanelSlider.Controls.Find("Settings", false)[0].BringToFront();
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            PanelSlider.Controls.Find("Info", false)[0].BringToFront();
        }
    }
}