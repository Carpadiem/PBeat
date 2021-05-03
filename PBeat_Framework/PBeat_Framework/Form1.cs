using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PBeat_Framework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isWantHide;
        Point newpoint;

        private void mouse_down(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x; int y;
                x = -e.X - SystemInformation.BorderSize.Width - ((Control)sender).Location.X + 1;
                y = -e.Y - SystemInformation.BorderSize.Height - ((Control)sender).Location.Y + 1;
                newpoint = new Point(x, y);
                isWantHide = true;
            }
        }

        private void mouse_up(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                isWantHide = false;
        }

        private void mouse_move(object sender, MouseEventArgs e)
        {
            if (isWantHide)
            {
                Point mousepoint = Control.MousePosition;
                mousepoint.Offset(newpoint.X, newpoint.Y);
                Location = mousepoint;
            }
        }

        private void btns_menu_mouseEnter(object sender, EventArgs e)
        {
            //255, 255, 255
            Bitmap gettedIcon = (Bitmap)((Control)sender).BackgroundImage; //gray image

            for (int x = 0; x < gettedIcon.Width; x++)
                for (int y = 0; y < gettedIcon.Height; y++)
                    gettedIcon.SetPixel(x, y, Color.FromArgb(gettedIcon.GetPixel(x, y).A, 255, 255, 255));

            ((Control)sender).BackgroundImage = gettedIcon;
        }

        private void btns_menu_mouseLeave(object sender, EventArgs e)
        {
            //47, 51, 55
            Bitmap gettedIcon = (Bitmap)((Control)sender).BackgroundImage; //gray image

            for (int x = 0; x < gettedIcon.Width; x++)
                for (int y = 0; y < gettedIcon.Height; y++)
                    gettedIcon.SetPixel(x, y, Color.FromArgb(gettedIcon.GetPixel(x, y).A, 47, 51, 55));

            ((Control)sender).BackgroundImage = gettedIcon;
        }
    }
}