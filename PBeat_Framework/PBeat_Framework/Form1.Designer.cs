
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pn_title = new System.Windows.Forms.Panel();
            this.lab_title = new System.Windows.Forms.Label();
            this.pn_menu = new System.Windows.Forms.Panel();
            this.Bt_Settings = new System.Windows.Forms.Button();
            this.btn_playlists = new System.Windows.Forms.Button();
            this.btn_music = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.pb_cover = new System.Windows.Forms.PictureBox();
            this.pn_player = new System.Windows.Forms.Panel();
            this.lab_trackauthor = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_playstop = new System.Windows.Forms.Button();
            this.lab_trackname = new System.Windows.Forms.Label();
            this.lab_mymusic = new System.Windows.Forms.Label();
            this.btn_filter3 = new System.Windows.Forms.Button();
            this.btn_filter2 = new System.Windows.Forms.Button();
            this.btn_filter1 = new System.Windows.Forms.Button();
            this.pn_title.SuspendLayout();
            this.pn_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cover)).BeginInit();
            this.pn_player.SuspendLayout();
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
            // 
            // pn_menu
            // 
            this.pn_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.pn_menu.Controls.Add(this.Bt_Settings);
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
            // Bt_Settings
            // 
            this.Bt_Settings.BackColor = System.Drawing.Color.Transparent;
            this.Bt_Settings.FlatAppearance.BorderSize = 0;
            this.Bt_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Settings.Location = new System.Drawing.Point(0, 321);
            this.Bt_Settings.Margin = new System.Windows.Forms.Padding(0);
            this.Bt_Settings.Name = "Bt_Settings";
            this.Bt_Settings.Size = new System.Drawing.Size(60, 40);
            this.Bt_Settings.TabIndex = 8;
            this.Bt_Settings.UseVisualStyleBackColor = false;
            // 
            // btn_playlists
            // 
            this.btn_playlists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.btn_playlists.FlatAppearance.BorderSize = 0;
            this.btn_playlists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_playlists.Location = new System.Drawing.Point(0, 120);
            this.btn_playlists.Margin = new System.Windows.Forms.Padding(0);
            this.btn_playlists.Name = "btn_playlists";
            this.btn_playlists.Size = new System.Drawing.Size(60, 40);
            this.btn_playlists.TabIndex = 7;
            this.btn_playlists.UseVisualStyleBackColor = false;
            // 
            // btn_music
            // 
            this.btn_music.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.btn_music.FlatAppearance.BorderSize = 0;
            this.btn_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_music.Location = new System.Drawing.Point(0, 40);
            this.btn_music.Margin = new System.Windows.Forms.Padding(0);
            this.btn_music.Name = "btn_music";
            this.btn_music.Size = new System.Drawing.Size(60, 40);
            this.btn_music.TabIndex = 6;
            this.btn_music.UseVisualStyleBackColor = false;
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Location = new System.Drawing.Point(0, 0);
            this.btn_menu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(60, 40);
            this.btn_menu.TabIndex = 5;
            this.btn_menu.UseVisualStyleBackColor = false;
            // 
            // btn_history
            // 
            this.btn_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.btn_history.FlatAppearance.BorderSize = 0;
            this.btn_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_history.Location = new System.Drawing.Point(0, 79);
            this.btn_history.Margin = new System.Windows.Forms.Padding(0);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(60, 40);
            this.btn_history.TabIndex = 0;
            this.btn_history.UseVisualStyleBackColor = false;
            // 
            // pb_cover
            // 
            this.pb_cover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_cover.BackgroundImage")));
            this.pb_cover.Location = new System.Drawing.Point(0, 400);
            this.pb_cover.Margin = new System.Windows.Forms.Padding(0);
            this.pb_cover.Name = "pb_cover";
            this.pb_cover.Size = new System.Drawing.Size(100, 100);
            this.pb_cover.TabIndex = 2;
            this.pb_cover.TabStop = false;
            // 
            // pn_player
            // 
            this.pn_player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
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
            this.lab_trackauthor.Location = new System.Drawing.Point(434, 20);
            this.lab_trackauthor.Margin = new System.Windows.Forms.Padding(0);
            this.lab_trackauthor.Name = "lab_trackauthor";
            this.lab_trackauthor.Size = new System.Drawing.Size(240, 35);
            this.lab_trackauthor.TabIndex = 11;
            this.lab_trackauthor.Text = "Mxlly";
            this.lab_trackauthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Location = new System.Drawing.Point(374, 20);
            this.btn_next.Margin = new System.Windows.Forms.Padding(0);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(35, 35);
            this.btn_next.TabIndex = 10;
            this.btn_next.UseVisualStyleBackColor = false;
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.btn_previous.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_previous.FlatAppearance.BorderSize = 0;
            this.btn_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_previous.Location = new System.Drawing.Point(293, 20);
            this.btn_previous.Margin = new System.Windows.Forms.Padding(0);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(35, 35);
            this.btn_previous.TabIndex = 9;
            this.btn_previous.UseVisualStyleBackColor = false;
            // 
            // btn_playstop
            // 
            this.btn_playstop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.btn_playstop.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_playstop.FlatAppearance.BorderSize = 0;
            this.btn_playstop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_playstop.Location = new System.Drawing.Point(334, 20);
            this.btn_playstop.Margin = new System.Windows.Forms.Padding(0);
            this.btn_playstop.Name = "btn_playstop";
            this.btn_playstop.Size = new System.Drawing.Size(35, 35);
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
            // lab_mymusic
            // 
            this.lab_mymusic.AutoSize = true;
            this.lab_mymusic.BackColor = System.Drawing.Color.Transparent;
            this.lab_mymusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_mymusic.Font = new System.Drawing.Font("Roboto Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.lab_mymusic.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lab_mymusic.Location = new System.Drawing.Point(100, 79);
            this.lab_mymusic.Margin = new System.Windows.Forms.Padding(0);
            this.lab_mymusic.Name = "lab_mymusic";
            this.lab_mymusic.Size = new System.Drawing.Size(189, 37);
            this.lab_mymusic.TabIndex = 4;
            this.lab_mymusic.Text = "Моя музыка";
            this.lab_mymusic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_filter3
            // 
            this.btn_filter3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.btn_filter3.FlatAppearance.BorderSize = 0;
            this.btn_filter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter3.Location = new System.Drawing.Point(720, 77);
            this.btn_filter3.Margin = new System.Windows.Forms.Padding(0);
            this.btn_filter3.Name = "btn_filter3";
            this.btn_filter3.Size = new System.Drawing.Size(40, 40);
            this.btn_filter3.TabIndex = 5;
            this.btn_filter3.UseVisualStyleBackColor = false;
            // 
            // btn_filter2
            // 
            this.btn_filter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.btn_filter2.FlatAppearance.BorderSize = 0;
            this.btn_filter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter2.Location = new System.Drawing.Point(676, 77);
            this.btn_filter2.Margin = new System.Windows.Forms.Padding(0);
            this.btn_filter2.Name = "btn_filter2";
            this.btn_filter2.Size = new System.Drawing.Size(40, 40);
            this.btn_filter2.TabIndex = 6;
            this.btn_filter2.UseVisualStyleBackColor = false;
            // 
            // btn_filter1
            // 
            this.btn_filter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.btn_filter1.FlatAppearance.BorderSize = 0;
            this.btn_filter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter1.Location = new System.Drawing.Point(632, 77);
            this.btn_filter1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_filter1.Name = "btn_filter1";
            this.btn_filter1.Size = new System.Drawing.Size(40, 40);
            this.btn_filter1.TabIndex = 7;
            this.btn_filter1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btn_filter1);
            this.Controls.Add(this.btn_filter2);
            this.Controls.Add(this.btn_filter3);
            this.Controls.Add(this.lab_mymusic);
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_cover)).EndInit();
            this.pn_player.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_title;
        private System.Windows.Forms.Panel pn_menu;
        private System.Windows.Forms.PictureBox pb_cover;
        private System.Windows.Forms.Panel pn_player;
        private System.Windows.Forms.Label lab_mymusic;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Button btn_music;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button Bt_Settings;
        private System.Windows.Forms.Button btn_playlists;
        private System.Windows.Forms.Button btn_filter3;
        private System.Windows.Forms.Button btn_filter2;
        private System.Windows.Forms.Button btn_filter1;
        private System.Windows.Forms.Label lab_trackname;
        private System.Windows.Forms.Button btn_playstop;
        private System.Windows.Forms.Label lab_trackauthor;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_previous;
    }
}

