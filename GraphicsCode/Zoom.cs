using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calc.UserControls
{
    public partial class UserGraphics : UserControl
    {
        const double ZOOM_MAX = 5;
        const double ZOOM_STEP = 0.2;

        private void ZoomGraph(int sgn)
        {
            // calculates new width, height, and location of picturebox_graph (for zooming)
            // sgn = 1 is zoom in
            // sgn = -1 is zoom out

            double width = pictureBox_graph.Width + sgn * ZOOM_STEP * pictureBox_container.Width;
            double height;
            if (width > pictureBox_container.Width * ZOOM_MAX) // if out of upper bounds, set to max
            {
                width = pictureBox_container.Width * ZOOM_MAX;
                height = pictureBox_container.Height * ZOOM_MAX;
            }
            else if (width < pictureBox_container.Width) // if less then lower bounds, set to min
            {
                width = pictureBox_container.Width;
                height = pictureBox_container.Height;
            }
            else
            {
                height = pictureBox_graph.Height + sgn * ZOOM_STEP * pictureBox_container.Height;
            }
            if (width == pictureBox_graph.Width) return;
            Point location = pictureBox_graph.Location;
            location = new Point(
                location.X + (int)Math.Round((pictureBox_graph.Width - width) / 2),
                location.Y + (int)Math.Round((pictureBox_graph.Height - height) / 2)
                );
            pictureBox_graph.Width = (int)Math.Round(width);
            pictureBox_graph.Height = (int)Math.Round(height);
            //stop crossing container border inward
            LocationCorrection(ref location);
            pictureBox_graph.Location = location;
            // Redraw grid on every round zoom factor
            double corr_factor = (double)pictureBox_graph.Width / (double)pictureBox_container.Width;
            corr_factor = Math.Floor(corr_factor);
            if (corr_factor % 2 == 0 && sgn > 0 || corr_factor % 2 == 1 && sgn < 0)
            {
                DrawGrid(corr_factor);
            }
        }
    }
}