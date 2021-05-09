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
<<<<<<< HEAD

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

        //при входе курсора в границы 1ой из 3ех кнопок управления окна...
        private void controlBox_mouse_enter(object sender, EventArgs e) => /*цвет текста кнопки = белый*/((Button)sender).ForeColor = Color.White;

        //при выходе курсора из границ 1ой из 3ех кнопок управления окна...
        private void controlBox_mouse_leave(object sender, EventArgs e) => /*цвет текста кнопки = что ранее*/((Button)sender).ForeColor = Color.FromArgb(90, 94, 109);

        //закрыть приложение
        private void btn_close_Click(object sender, EventArgs e) => Application.Exit();

        //функция разворачивания окна на весь экран
        private void btn_expand_Click(object sender, EventArgs e)
        {
            //если окно развернуто...
            if (WindowState == FormWindowState.Maximized)
            {
                //вернуть его в прежнее состояние; выйти из метода (чтобы команда после условия не выполнялась)
                WindowState = FormWindowState.Normal; return;
            }

            //развернуть окно
            WindowState = FormWindowState.Maximized;
        }

        //свернуть окно
        private void btn_hide_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        /*
         * если в методе всего одна команда, можно вспользоваться "=>" и на той же строке прописать эту команду
         */
=======
>>>>>>> parent of dc79e23 (Редакт. интерфейса)
    }
}
