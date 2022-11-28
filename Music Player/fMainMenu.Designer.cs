namespace Music_Player
{
    partial class fMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMainMenu));
            this.pMenu = new System.Windows.Forms.Panel();
            this.btnPlaylists = new FontAwesome.Sharp.IconButton();
            this.btnSongs = new FontAwesome.Sharp.IconButton();
            this.pLogo = new System.Windows.Forms.FlowLayoutPanel();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.pTitleChileForm = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.pSongPlayer = new System.Windows.Forms.Panel();
            this.pChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pMenu.SuspendLayout();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.pTitleChileForm.SuspendLayout();
            this.pSongPlayer.SuspendLayout();
            this.pChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pMenu.Controls.Add(this.btnPlaylists);
            this.pMenu.Controls.Add(this.btnSongs);
            this.pMenu.Controls.Add(this.pLogo);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(215, 553);
            this.pMenu.TabIndex = 0;
            // 
            // btnPlaylists
            // 
            this.btnPlaylists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylists.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaylists.FlatAppearance.BorderSize = 0;
            this.btnPlaylists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylists.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylists.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPlaylists.IconChar = FontAwesome.Sharp.IconChar.Bathtub;
            this.btnPlaylists.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPlaylists.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlaylists.IconSize = 32;
            this.btnPlaylists.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylists.Location = new System.Drawing.Point(0, 159);
            this.btnPlaylists.Name = "btnPlaylists";
            this.btnPlaylists.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPlaylists.Size = new System.Drawing.Size(215, 55);
            this.btnPlaylists.TabIndex = 2;
            this.btnPlaylists.Text = "Playlists";
            this.btnPlaylists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylists.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlaylists.UseVisualStyleBackColor = true;
            this.btnPlaylists.Click += new System.EventHandler(this.btnPlaylists_Click);
            // 
            // btnSongs
            // 
            this.btnSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSongs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSongs.FlatAppearance.BorderSize = 0;
            this.btnSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSongs.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSongs.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSongs.IconChar = FontAwesome.Sharp.IconChar.Bathtub;
            this.btnSongs.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSongs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSongs.IconSize = 32;
            this.btnSongs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSongs.Location = new System.Drawing.Point(0, 104);
            this.btnSongs.Name = "btnSongs";
            this.btnSongs.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSongs.Size = new System.Drawing.Size(215, 55);
            this.btnSongs.TabIndex = 1;
            this.btnSongs.Text = "Songs";
            this.btnSongs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSongs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSongs.UseVisualStyleBackColor = true;
            this.btnSongs.Click += new System.EventHandler(this.btnSongs_Click);
            // 
            // pLogo
            // 
            this.pLogo.Controls.Add(this.ptbLogo);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(215, 104);
            this.pLogo.TabIndex = 0;
            // 
            // ptbLogo
            // 
            this.ptbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbLogo.Image = global::Music_Player.Properties.Resources.nobg_logo;
            this.ptbLogo.Location = new System.Drawing.Point(3, 3);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(209, 89);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo.TabIndex = 1;
            this.ptbLogo.TabStop = false;
            this.ptbLogo.Click += new System.EventHandler(this.ptbLogo_Click);
            // 
            // pTitleChileForm
            // 
            this.pTitleChileForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pTitleChileForm.Controls.Add(this.btnMinimize);
            this.pTitleChileForm.Controls.Add(this.btnExit);
            this.pTitleChileForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitleChileForm.Location = new System.Drawing.Point(215, 0);
            this.pTitleChileForm.Name = "pTitleChileForm";
            this.pTitleChileForm.Size = new System.Drawing.Size(1149, 33);
            this.pTitleChileForm.TabIndex = 1;
            this.pTitleChileForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pTitleChileForm_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 30;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.Location = new System.Drawing.Point(1065, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(37, 27);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 40;
            this.btnExit.Location = new System.Drawing.Point(1109, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 27);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // pSongPlayer
            // 
            this.pSongPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pSongPlayer.Controls.Add(this.pictureBox2);
            this.pSongPlayer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pSongPlayer.Location = new System.Drawing.Point(998, 33);
            this.pSongPlayer.Name = "pSongPlayer";
            this.pSongPlayer.Size = new System.Drawing.Size(366, 520);
            this.pSongPlayer.TabIndex = 3;
            // 
            // pChildForm
            // 
            this.pChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pChildForm.Controls.Add(this.pictureBox1);
            this.pChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pChildForm.Location = new System.Drawing.Point(215, 33);
            this.pChildForm.Name = "pChildForm";
            this.pChildForm.Size = new System.Drawing.Size(783, 520);
            this.pChildForm.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Music_Player.Properties.Resources.nobg_logo;
            this.pictureBox1.Location = new System.Drawing.Point(136, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Music_Player.Properties.Resources.nobg_nomusic;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(360, 408);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // fMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1364, 553);
            this.Controls.Add(this.pChildForm);
            this.Controls.Add(this.pSongPlayer);
            this.Controls.Add(this.pTitleChileForm);
            this.Controls.Add(this.pMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            this.pMenu.ResumeLayout(false);
            this.pLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.pTitleChileForm.ResumeLayout(false);
            this.pSongPlayer.ResumeLayout(false);
            this.pChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.FlowLayoutPanel pLogo;
        private FontAwesome.Sharp.IconButton btnSongs;
        private FontAwesome.Sharp.IconButton btnPlaylists;
        private System.Windows.Forms.Panel pTitleChileForm;
        private System.Windows.Forms.Panel pSongPlayer;
        private System.Windows.Forms.Panel pChildForm;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

