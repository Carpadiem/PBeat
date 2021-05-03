
namespace PBeat_Framework
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pn_title = new System.Windows.Forms.Panel();
            this.lab_title = new System.Windows.Forms.Label();
            this.pn_menu = new System.Windows.Forms.Panel();
            this.pn_player = new System.Windows.Forms.Panel();
            this.lab_trackauthor = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_playstop = new System.Windows.Forms.Button();
            this.lab_trackname = new System.Windows.Forms.Label();
            this.lab_mytracks = new System.Windows.Forms.Label();
            this.pn_trackList = new System.Windows.Forms.Panel();
            this.pn_track1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_filter1 = new System.Windows.Forms.Button();
            this.btn_filter2 = new System.Windows.Forms.Button();
            this.btn_filter3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pb_cover = new System.Windows.Forms.PictureBox();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_playlists = new System.Windows.Forms.Button();
            this.btn_music = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.pn_title.SuspendLayout();
            this.pn_menu.SuspendLayout();
            this.pn_player.SuspendLayout();
            this.pn_trackList.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cover)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_title
            // 
            this.pn_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.pn_title.Controls.Add(this.lab_title);
            this.pn_title.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.pn_title.Location = new System.Drawing.Point(0, 0);
            this.pn_title.Margin = new System.Windows.Forms.Padding(0);
            this.pn_title.Name = "pn_title";
            this.pn_title.Size = new System.Drawing.Size(800, 40);
            this.pn_title.TabIndex = 0;
            this.pn_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_down);
            this.pn_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_move);
            this.pn_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_up);
            // 
            // lab_title
            // 
            this.lab_title.BackColor = System.Drawing.Color.Transparent;
            this.lab_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_title.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.lab_title.ForeColor = System.Drawing.Color.White;
            this.lab_title.Location = new System.Drawing.Point(200, 0);
            this.lab_title.Margin = new System.Windows.Forms.Padding(0);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(400, 40);
            this.lab_title.TabIndex = 0;
            this.lab_title.Text = "PBeat";
            this.lab_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_down);
            this.lab_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_move);
            this.lab_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_up);
            // 
            // pn_menu
            // 
            this.pn_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.pn_menu.Controls.Add(this.btn_settings);
            this.pn_menu.Controls.Add(this.btn_playlists);
            this.pn_menu.Controls.Add(this.btn_music);
            this.pn_menu.Controls.Add(this.btn_menu);
            this.pn_menu.Controls.Add(this.btn_history);
            this.pn_menu.Location = new System.Drawing.Point(0, 40);
            this.pn_menu.Margin = new System.Windows.Forms.Padding(0);
            this.pn_menu.Name = "pn_menu";
            this.pn_menu.Size = new System.Drawing.Size(60, 360);
            this.pn_menu.TabIndex = 1;
            // 
            // pn_player
            // 
            this.pn_player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.pn_player.Controls.Add(this.button1);
            this.pn_player.Controls.Add(this.panel1);
            this.pn_player.Controls.Add(this.label2);
            this.pn_player.Controls.Add(this.label1);
            this.pn_player.Controls.Add(this.lab_trackauthor);
            this.pn_player.Controls.Add(this.btn_next);
            this.pn_player.Controls.Add(this.btn_previous);
            this.pn_player.Controls.Add(this.btn_playstop);
            this.pn_player.Controls.Add(this.lab_trackname);
            this.pn_player.Location = new System.Drawing.Point(100, 400);
            this.pn_player.Margin = new System.Windows.Forms.Padding(0);
            this.pn_player.Name = "pn_player";
            this.pn_player.Size = new System.Drawing.Size(700, 100);
            this.pn_player.TabIndex = 3;
            // 
            // lab_trackauthor
            // 
            this.lab_trackauthor.BackColor = System.Drawing.Color.Transparent;
            this.lab_trackauthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_trackauthor.Font = new System.Drawing.Font("Roboto Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.lab_trackauthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(94)))), ((int)(((byte)(109)))));
            this.lab_trackauthor.Location = new System.Drawing.Point(604, 20);
            this.lab_trackauthor.Margin = new System.Windows.Forms.Padding(0);
            this.lab_trackauthor.Name = "lab_trackauthor";
            this.lab_trackauthor.Size = new System.Drawing.Size(70, 35);
            this.lab_trackauthor.TabIndex = 11;
            this.lab_trackauthor.Text = "Mxlly";
            this.lab_trackauthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Location = new System.Drawing.Point(374, 20);
            this.btn_next.Margin = new System.Windows.Forms.Padding(0);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(28, 28);
            this.btn_next.TabIndex = 10;
            this.btn_next.UseVisualStyleBackColor = false;
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.btn_previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_previous.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_previous.FlatAppearance.BorderSize = 0;
            this.btn_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_previous.Location = new System.Drawing.Point(293, 20);
            this.btn_previous.Margin = new System.Windows.Forms.Padding(0);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(28, 28);
            this.btn_previous.TabIndex = 9;
            this.btn_previous.UseVisualStyleBackColor = false;
            // 
            // btn_playstop
            // 
            this.btn_playstop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.btn_playstop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_playstop.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_playstop.FlatAppearance.BorderSize = 0;
            this.btn_playstop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_playstop.Location = new System.Drawing.Point(334, 20);
            this.btn_playstop.Margin = new System.Windows.Forms.Padding(0);
            this.btn_playstop.Name = "btn_playstop";
            this.btn_playstop.Size = new System.Drawing.Size(28, 28);
            this.btn_playstop.TabIndex = 8;
            this.btn_playstop.UseVisualStyleBackColor = false;
            // 
            // lab_trackname
            // 
            this.lab_trackname.BackColor = System.Drawing.Color.Transparent;
            this.lab_trackname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_trackname.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.lab_trackname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lab_trackname.Location = new System.Drawing.Point(26, 20);
            this.lab_trackname.Margin = new System.Windows.Forms.Padding(0);
            this.lab_trackname.Name = "lab_trackname";
            this.lab_trackname.Size = new System.Drawing.Size(244, 35);
            this.lab_trackname.TabIndex = 8;
            this.lab_trackname.Text = "Sunset";
            this.lab_trackname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_mytracks
            // 
            this.lab_mytracks.AutoSize = true;
            this.lab_mytracks.BackColor = System.Drawing.Color.Transparent;
            this.lab_mytracks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_mytracks.Font = new System.Drawing.Font("Roboto Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.lab_mytracks.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lab_mytracks.Location = new System.Drawing.Point(100, 80);
            this.lab_mytracks.Margin = new System.Windows.Forms.Padding(0);
            this.lab_mytracks.Name = "lab_mytracks";
            this.lab_mytracks.Size = new System.Drawing.Size(189, 37);
            this.lab_mytracks.TabIndex = 4;
            this.lab_mytracks.Text = "Моя музыка";
            this.lab_mytracks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_trackList
            // 
            this.pn_trackList.BackColor = System.Drawing.Color.Transparent;
            this.pn_trackList.Controls.Add(this.pn_track1);
            this.pn_trackList.ForeColor = System.Drawing.Color.White;
            this.pn_trackList.Location = new System.Drawing.Point(100, 160);
            this.pn_trackList.Margin = new System.Windows.Forms.Padding(0);
            this.pn_trackList.Name = "pn_trackList";
            this.pn_trackList.Size = new System.Drawing.Size(660, 240);
            this.pn_trackList.TabIndex = 8;
            // 
            // pn_track1
            // 
            this.pn_track1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(70)))), ((int)(((byte)(240)))));
            this.pn_track1.ForeColor = System.Drawing.Color.White;
            this.pn_track1.Location = new System.Drawing.Point(0, 0);
            this.pn_track1.Margin = new System.Windows.Forms.Padding(0);
            this.pn_track1.Name = "pn_track1";
            this.pn_track1.Size = new System.Drawing.Size(660, 40);
            this.pn_track1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(26, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "01:44";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(604, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "03:25";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(120, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 2);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(70)))), ((int)(((byte)(240)))));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 15;
            // 
            // btn_filter1
            // 
            this.btn_filter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.btn_filter1.BackgroundImage = global::PBeat_Framework.Properties.Resources.filter3;
            this.btn_filter1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_filter1.FlatAppearance.BorderSize = 0;
            this.btn_filter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter1.Location = new System.Drawing.Point(632, 80);
            this.btn_filter1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_filter1.Name = "btn_filter1";
            this.btn_filter1.Size = new System.Drawing.Size(40, 40);
            this.btn_filter1.TabIndex = 7;
            this.btn_filter1.UseVisualStyleBackColor = false;
            // 
            // btn_filter2
            // 
            this.btn_filter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.btn_filter2.BackgroundImage = global::PBeat_Framework.Properties.Resources.filter2;
            this.btn_filter2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_filter2.FlatAppearance.BorderSize = 0;
            this.btn_filter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter2.Location = new System.Drawing.Point(676, 80);
            this.btn_filter2.Margin = new System.Windows.Forms.Padding(0);
            this.btn_filter2.Name = "btn_filter2";
            this.btn_filter2.Size = new System.Drawing.Size(40, 40);
            this.btn_filter2.TabIndex = 6;
            this.btn_filter2.UseVisualStyleBackColor = false;
            // 
            // btn_filter3
            // 
            this.btn_filter3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.btn_filter3.BackgroundImage = global::PBeat_Framework.Properties.Resources.filter1;
            this.btn_filter3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_filter3.FlatAppearance.BorderSize = 0;
            this.btn_filter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter3.Location = new System.Drawing.Point(720, 80);
            this.btn_filter3.Margin = new System.Windows.Forms.Padding(0);
            this.btn_filter3.Name = "btn_filter3";
            this.btn_filter3.Size = new System.Drawing.Size(40, 40);
            this.btn_filter3.TabIndex = 5;
            this.btn_filter3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::PBeat_Framework.Properties.Resources.playerHandle;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(314, 66);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pb_cover
            // 
            this.pb_cover.Location = new System.Drawing.Point(0, 400);
            this.pb_cover.Margin = new System.Windows.Forms.Padding(0);
            this.pb_cover.Name = "pb_cover";
            this.pb_cover.Size = new System.Drawing.Size(100, 100);
            this.pb_cover.TabIndex = 2;
            this.pb_cover.TabStop = false;
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_settings.BackgroundImage = global::PBeat_Framework.Properties.Resources.settings;
            this.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Location = new System.Drawing.Point(0, 310);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(0);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(60, 50);
            this.btn_settings.TabIndex = 8;
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.MouseEnter += new System.EventHandler(this.btns_menu_mouseEnter);
            this.btn_settings.MouseLeave += new System.EventHandler(this.btns_menu_mouseLeave);
            // 
            // btn_playlists
            // 
            this.btn_playlists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.btn_playlists.BackgroundImage = global::PBeat_Framework.Properties.Resources.playlists;
            this.btn_playlists.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_playlists.FlatAppearance.BorderSize = 0;
            this.btn_playlists.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.btn_playlists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_playlists.Location = new System.Drawing.Point(0, 150);
            this.btn_playlists.Margin = new System.Windows.Forms.Padding(0);
            this.btn_playlists.Name = "btn_playlists";
            this.btn_playlists.Size = new System.Drawing.Size(60, 50);
            this.btn_playlists.TabIndex = 7;
            this.btn_playlists.UseVisualStyleBackColor = false;
            this.btn_playlists.MouseEnter += new System.EventHandler(this.btns_menu_mouseEnter);
            this.btn_playlists.MouseLeave += new System.EventHandler(this.btns_menu_mouseLeave);
            // 
            // btn_music
            // 
            this.btn_music.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.btn_music.BackgroundImage = global::PBeat_Framework.Properties.Resources.music;
            this.btn_music.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_music.FlatAppearance.BorderSize = 0;
            this.btn_music.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.btn_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_music.Location = new System.Drawing.Point(0, 50);
            this.btn_music.Margin = new System.Windows.Forms.Padding(0);
            this.btn_music.Name = "btn_music";
            this.btn_music.Size = new System.Drawing.Size(60, 50);
            this.btn_music.TabIndex = 6;
            this.btn_music.UseVisualStyleBackColor = false;
            this.btn_music.MouseEnter += new System.EventHandler(this.btns_menu_mouseEnter);
            this.btn_music.MouseLeave += new System.EventHandler(this.btns_menu_mouseLeave);
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.btn_menu.BackgroundImage = global::PBeat_Framework.Properties.Resources.menu;
            this.btn_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Location = new System.Drawing.Point(0, 0);
            this.btn_menu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(60, 50);
            this.btn_menu.TabIndex = 5;
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.MouseEnter += new System.EventHandler(this.btns_menu_mouseEnter);
            this.btn_menu.MouseLeave += new System.EventHandler(this.btns_menu_mouseLeave);
            // 
            // btn_history
            // 
            this.btn_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.btn_history.BackgroundImage = global::PBeat_Framework.Properties.Resources.history;
            this.btn_history.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_history.FlatAppearance.BorderSize = 0;
            this.btn_history.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.btn_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_history.Location = new System.Drawing.Point(0, 100);
            this.btn_history.Margin = new System.Windows.Forms.Padding(0);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(60, 50);
            this.btn_history.TabIndex = 0;
            this.btn_history.UseVisualStyleBackColor = false;
            this.btn_history.MouseEnter += new System.EventHandler(this.btns_menu_mouseEnter);
            this.btn_history.MouseLeave += new System.EventHandler(this.btns_menu_mouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pn_trackList);
            this.Controls.Add(this.btn_filter1);
            this.Controls.Add(this.btn_filter2);
            this.Controls.Add(this.btn_filter3);
            this.Controls.Add(this.lab_mytracks);
            this.Controls.Add(this.pn_player);
            this.Controls.Add(this.pb_cover);
            this.Controls.Add(this.pn_menu);
            this.Controls.Add(this.pn_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "  ";
            this.pn_title.ResumeLayout(false);
            this.pn_menu.ResumeLayout(false);
            this.pn_player.ResumeLayout(false);
            this.pn_trackList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_cover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_title;
        private System.Windows.Forms.Panel pn_menu;
        private System.Windows.Forms.PictureBox pb_cover;
        private System.Windows.Forms.Panel pn_player;
        private System.Windows.Forms.Label lab_mytracks;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Button btn_music;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_playlists;
        private System.Windows.Forms.Button btn_filter3;
        private System.Windows.Forms.Button btn_filter2;
        private System.Windows.Forms.Label lab_trackname;
        private System.Windows.Forms.Button btn_playstop;
        private System.Windows.Forms.Label lab_trackauthor;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Panel pn_trackList;
        private System.Windows.Forms.Panel pn_track1;
        private System.Windows.Forms.Button btn_filter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}

