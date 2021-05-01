
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
            this.Pn_HeadPanel = new System.Windows.Forms.Panel();
            this.Pn_SidePanel = new System.Windows.Forms.Panel();
            this.Pb_PictureTrack = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lb_My_music = new System.Windows.Forms.Label();
            this.Lb_ProgramName = new System.Windows.Forms.Label();
            this.Bt_History = new System.Windows.Forms.Button();
            this.Bt_ButtonsName = new System.Windows.Forms.Button();
            this.Bt_MusicList = new System.Windows.Forms.Button();
            this.Bt_Playlists = new System.Windows.Forms.Button();
            this.Bt_Settings = new System.Windows.Forms.Button();
            this.Bt_Filter3 = new System.Windows.Forms.Button();
            this.Bt_Filter2 = new System.Windows.Forms.Button();
            this.Bt_Filter1 = new System.Windows.Forms.Button();
            this.Lb_NameTrack = new System.Windows.Forms.Label();
            this.Bt_PlayMusic = new System.Windows.Forms.Button();
            this.Bt_PreviousMusic = new System.Windows.Forms.Button();
            this.Bt_NextMusic = new System.Windows.Forms.Button();
            this.Lb_AuthorTrack = new System.Windows.Forms.Label();
            this.Pn_HeadPanel.SuspendLayout();
            this.Pn_SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_PictureTrack)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pn_HeadPanel
            // 
            this.Pn_HeadPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pn_HeadPanel.BackgroundImage")));
            this.Pn_HeadPanel.Controls.Add(this.Lb_ProgramName);
            this.Pn_HeadPanel.Location = new System.Drawing.Point(0, 0);
            this.Pn_HeadPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Pn_HeadPanel.Name = "Pn_HeadPanel";
            this.Pn_HeadPanel.Size = new System.Drawing.Size(800, 40);
            this.Pn_HeadPanel.TabIndex = 0;
            // 
            // Pn_SidePanel
            // 
            this.Pn_SidePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pn_SidePanel.BackgroundImage")));
            this.Pn_SidePanel.Controls.Add(this.Bt_Settings);
            this.Pn_SidePanel.Controls.Add(this.Bt_Playlists);
            this.Pn_SidePanel.Controls.Add(this.Bt_MusicList);
            this.Pn_SidePanel.Controls.Add(this.Bt_ButtonsName);
            this.Pn_SidePanel.Controls.Add(this.Bt_History);
            this.Pn_SidePanel.Location = new System.Drawing.Point(0, 40);
            this.Pn_SidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.Pn_SidePanel.Name = "Pn_SidePanel";
            this.Pn_SidePanel.Size = new System.Drawing.Size(60, 360);
            this.Pn_SidePanel.TabIndex = 1;
            // 
            // Pb_PictureTrack
            // 
            this.Pb_PictureTrack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pb_PictureTrack.BackgroundImage")));
            this.Pb_PictureTrack.Location = new System.Drawing.Point(0, 400);
            this.Pb_PictureTrack.Margin = new System.Windows.Forms.Padding(0);
            this.Pb_PictureTrack.Name = "Pb_PictureTrack";
            this.Pb_PictureTrack.Size = new System.Drawing.Size(100, 100);
            this.Pb_PictureTrack.TabIndex = 2;
            this.Pb_PictureTrack.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.Lb_AuthorTrack);
            this.panel3.Controls.Add(this.Bt_NextMusic);
            this.panel3.Controls.Add(this.Bt_PreviousMusic);
            this.panel3.Controls.Add(this.Bt_PlayMusic);
            this.panel3.Controls.Add(this.Lb_NameTrack);
            this.panel3.Location = new System.Drawing.Point(100, 400);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 100);
            this.panel3.TabIndex = 3;
            // 
            // Lb_My_music
            // 
            this.Lb_My_music.BackColor = System.Drawing.Color.Transparent;
            this.Lb_My_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_My_music.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lb_My_music.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_My_music.Location = new System.Drawing.Point(100, 80);
            this.Lb_My_music.Margin = new System.Windows.Forms.Padding(0);
            this.Lb_My_music.Name = "Lb_My_music";
            this.Lb_My_music.Size = new System.Drawing.Size(172, 35);
            this.Lb_My_music.TabIndex = 4;
            this.Lb_My_music.Text = "Моя музыка";
            this.Lb_My_music.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lb_My_music.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lb_ProgramName
            // 
            this.Lb_ProgramName.BackColor = System.Drawing.Color.Transparent;
            this.Lb_ProgramName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_ProgramName.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lb_ProgramName.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Lb_ProgramName.Location = new System.Drawing.Point(348, 9);
            this.Lb_ProgramName.Margin = new System.Windows.Forms.Padding(0);
            this.Lb_ProgramName.Name = "Lb_ProgramName";
            this.Lb_ProgramName.Size = new System.Drawing.Size(104, 18);
            this.Lb_ProgramName.TabIndex = 0;
            this.Lb_ProgramName.Text = "PBeat";
            this.Lb_ProgramName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bt_History
            // 
            this.Bt_History.BackColor = System.Drawing.Color.Transparent;
            this.Bt_History.FlatAppearance.BorderSize = 0;
            this.Bt_History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_History.Location = new System.Drawing.Point(0, 80);
            this.Bt_History.Margin = new System.Windows.Forms.Padding(0);
            this.Bt_History.Name = "Bt_History";
            this.Bt_History.Size = new System.Drawing.Size(60, 40);
            this.Bt_History.TabIndex = 0;
            this.Bt_History.UseVisualStyleBackColor = false;
            this.Bt_History.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bt_ButtonsName
            // 
            this.Bt_ButtonsName.BackColor = System.Drawing.Color.Transparent;
            this.Bt_ButtonsName.FlatAppearance.BorderSize = 0;
            this.Bt_ButtonsName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_ButtonsName.Location = new System.Drawing.Point(0, 0);
            this.Bt_ButtonsName.Margin = new System.Windows.Forms.Padding(0);
            this.Bt_ButtonsName.Name = "Bt_ButtonsName";
            this.Bt_ButtonsName.Size = new System.Drawing.Size(60, 40);
            this.Bt_ButtonsName.TabIndex = 5;
            this.Bt_ButtonsName.UseVisualStyleBackColor = false;
            // 
            // Bt_MusicList
            // 
            this.Bt_MusicList.BackColor = System.Drawing.Color.Transparent;
            this.Bt_MusicList.FlatAppearance.BorderSize = 0;
            this.Bt_MusicList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_MusicList.Location = new System.Drawing.Point(0, 40);
            this.Bt_MusicList.Margin = new System.Windows.Forms.Padding(0);
            this.Bt_MusicList.Name = "Bt_MusicList";
            this.Bt_MusicList.Size = new System.Drawing.Size(60, 40);
            this.Bt_MusicList.TabIndex = 6;
            this.Bt_MusicList.UseVisualStyleBackColor = false;
            // 
            // Bt_Playlists
            // 
            this.Bt_Playlists.BackColor = System.Drawing.Color.Transparent;
            this.Bt_Playlists.FlatAppearance.BorderSize = 0;
            this.Bt_Playlists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Playlists.Location = new System.Drawing.Point(0, 120);
            this.Bt_Playlists.Margin = new System.Windows.Forms.Padding(0);
            this.Bt_Playlists.Name = "Bt_Playlists";
            this.Bt_Playlists.Size = new System.Drawing.Size(60, 40);
            this.Bt_Playlists.TabIndex = 7;
            this.Bt_Playlists.UseVisualStyleBackColor = false;
            // 
            // Bt_Settings
            // 
            this.Bt_Settings.BackColor = System.Drawing.Color.Transparent;
            this.Bt_Settings.FlatAppearance.BorderSize = 0;
            this.Bt_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Settings.Location = new System.Drawing.Point(0, 320);
            this.Bt_Settings.Margin = new System.Windows.Forms.Padding(0);
            this.Bt_Settings.Name = "Bt_Settings";
            this.Bt_Settings.Size = new System.Drawing.Size(60, 40);
            this.Bt_Settings.TabIndex = 8;
            this.Bt_Settings.UseVisualStyleBackColor = false;
            // 
            // Bt_Filter3
            // 
            this.Bt_Filter3.BackColor = System.Drawing.Color.Transparent;
            this.Bt_Filter3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_Filter3.BackgroundImage")));
            this.Bt_Filter3.FlatAppearance.BorderSize = 0;
            this.Bt_Filter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Filter3.Location = new System.Drawing.Point(720, 77);
            this.Bt_Filter3.Margin = new System.Windows.Forms.Padding(0);
            this.Bt_Filter3.Name = "Bt_Filter3";
            this.Bt_Filter3.Size = new System.Drawing.Size(40, 40);
            this.Bt_Filter3.TabIndex = 5;
            this.Bt_Filter3.UseVisualStyleBackColor = false;
            // 
            // Bt_Filter2
            // 
            this.Bt_Filter2.BackColor = System.Drawing.Color.Transparent;
            this.Bt_Filter2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_Filter2.BackgroundImage")));
            this.Bt_Filter2.FlatAppearance.BorderSize = 0;
            this.Bt_Filter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Filter2.Location = new System.Drawing.Point(676, 77);
            this.Bt_Filter2.Margin = new System.Windows.Forms.Padding(0);
            this.Bt_Filter2.Name = "Bt_Filter2";
            this.Bt_Filter2.Size = new System.Drawing.Size(40, 40);
            this.Bt_Filter2.TabIndex = 6;
            this.Bt_Filter2.UseVisualStyleBackColor = false;
            // 
            // Bt_Filter1
            // 
            this.Bt_Filter1.BackColor = System.Drawing.Color.Transparent;
            this.Bt_Filter1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_Filter1.BackgroundImage")));
            this.Bt_Filter1.FlatAppearance.BorderSize = 0;
            this.Bt_Filter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Filter1.Location = new System.Drawing.Point(632, 77);
            this.Bt_Filter1.Margin = new System.Windows.Forms.Padding(0);
            this.Bt_Filter1.Name = "Bt_Filter1";
            this.Bt_Filter1.Size = new System.Drawing.Size(40, 40);
            this.Bt_Filter1.TabIndex = 7;
            this.Bt_Filter1.UseVisualStyleBackColor = false;
            // 
            // Lb_NameTrack
            // 
            this.Lb_NameTrack.BackColor = System.Drawing.Color.Transparent;
            this.Lb_NameTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_NameTrack.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lb_NameTrack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_NameTrack.Location = new System.Drawing.Point(27, 24);
            this.Lb_NameTrack.Margin = new System.Windows.Forms.Padding(0);
            this.Lb_NameTrack.Name = "Lb_NameTrack";
            this.Lb_NameTrack.Size = new System.Drawing.Size(215, 22);
            this.Lb_NameTrack.TabIndex = 8;
            this.Lb_NameTrack.Text = "Sunset";
            this.Lb_NameTrack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Bt_PlayMusic
            // 
            this.Bt_PlayMusic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_PlayMusic.BackgroundImage")));
            this.Bt_PlayMusic.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bt_PlayMusic.FlatAppearance.BorderSize = 0;
            this.Bt_PlayMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_PlayMusic.Location = new System.Drawing.Point(334, 20);
            this.Bt_PlayMusic.Name = "Bt_PlayMusic";
            this.Bt_PlayMusic.Size = new System.Drawing.Size(35, 35);
            this.Bt_PlayMusic.TabIndex = 8;
            this.Bt_PlayMusic.UseVisualStyleBackColor = true;
            this.Bt_PlayMusic.Click += new System.EventHandler(this.button9_Click);
            // 
            // Bt_PreviousMusic
            // 
            this.Bt_PreviousMusic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_PreviousMusic.BackgroundImage")));
            this.Bt_PreviousMusic.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bt_PreviousMusic.FlatAppearance.BorderSize = 0;
            this.Bt_PreviousMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_PreviousMusic.Location = new System.Drawing.Point(293, 20);
            this.Bt_PreviousMusic.Name = "Bt_PreviousMusic";
            this.Bt_PreviousMusic.Size = new System.Drawing.Size(35, 35);
            this.Bt_PreviousMusic.TabIndex = 9;
            this.Bt_PreviousMusic.UseVisualStyleBackColor = true;
            // 
            // Bt_NextMusic
            // 
            this.Bt_NextMusic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_NextMusic.BackgroundImage")));
            this.Bt_NextMusic.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bt_NextMusic.FlatAppearance.BorderSize = 0;
            this.Bt_NextMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_NextMusic.Location = new System.Drawing.Point(375, 20);
            this.Bt_NextMusic.Name = "Bt_NextMusic";
            this.Bt_NextMusic.Size = new System.Drawing.Size(35, 35);
            this.Bt_NextMusic.TabIndex = 10;
            this.Bt_NextMusic.UseVisualStyleBackColor = true;
            // 
            // Lb_AuthorTrack
            // 
            this.Lb_AuthorTrack.BackColor = System.Drawing.Color.Transparent;
            this.Lb_AuthorTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_AuthorTrack.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lb_AuthorTrack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_AuthorTrack.Location = new System.Drawing.Point(572, 24);
            this.Lb_AuthorTrack.Name = "Lb_AuthorTrack";
            this.Lb_AuthorTrack.Size = new System.Drawing.Size(102, 26);
            this.Lb_AuthorTrack.TabIndex = 11;
            this.Lb_AuthorTrack.Text = "Mxlly";
            this.Lb_AuthorTrack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lb_AuthorTrack.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.Bt_Filter1);
            this.Controls.Add(this.Bt_Filter2);
            this.Controls.Add(this.Bt_Filter3);
            this.Controls.Add(this.Lb_My_music);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Pb_PictureTrack);
            this.Controls.Add(this.Pn_SidePanel);
            this.Controls.Add(this.Pn_HeadPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Pn_HeadPanel.ResumeLayout(false);
            this.Pn_SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_PictureTrack)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pn_HeadPanel;
        private System.Windows.Forms.Panel Pn_SidePanel;
        private System.Windows.Forms.PictureBox Pb_PictureTrack;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Lb_My_music;
        private System.Windows.Forms.Label Lb_ProgramName;
        private System.Windows.Forms.Button Bt_History;
        private System.Windows.Forms.Button Bt_MusicList;
        private System.Windows.Forms.Button Bt_ButtonsName;
        private System.Windows.Forms.Button Bt_Settings;
        private System.Windows.Forms.Button Bt_Playlists;
        private System.Windows.Forms.Button Bt_Filter3;
        private System.Windows.Forms.Button Bt_Filter2;
        private System.Windows.Forms.Button Bt_Filter1;
        private System.Windows.Forms.Label Lb_NameTrack;
        private System.Windows.Forms.Button Bt_PlayMusic;
        private System.Windows.Forms.Label Lb_AuthorTrack;
        private System.Windows.Forms.Button Bt_NextMusic;
        private System.Windows.Forms.Button Bt_PreviousMusic;
    }
}

