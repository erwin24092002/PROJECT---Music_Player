namespace Music_Player.User_Controls
{
    partial class LoveSongItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.btnDisHeart = new FontAwesome.Sharp.IconButton();
            this.btnCollect = new FontAwesome.Sharp.IconButton();
            this.btnDownload = new FontAwesome.Sharp.IconButton();
            this.lbSongDate = new System.Windows.Forms.Label();
            this.lbSongSinger = new System.Windows.Forms.Label();
            this.lbSongName = new System.Windows.Forms.Label();
            this.ptbSongImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSongImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnPlay.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlay.IconSize = 40;
            this.btnPlay.Location = new System.Drawing.Point(610, 39);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(40, 40);
            this.btnPlay.TabIndex = 11;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.MouseLeave += new System.EventHandler(this.Button_Leave);
            this.btnPlay.MouseHover += new System.EventHandler(this.Button_Hover);
            // 
            // btnDisHeart
            // 
            this.btnDisHeart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisHeart.FlatAppearance.BorderSize = 0;
            this.btnDisHeart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisHeart.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDisHeart.IconChar = FontAwesome.Sharp.IconChar.HeartCrack;
            this.btnDisHeart.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDisHeart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDisHeart.IconSize = 45;
            this.btnDisHeart.Location = new System.Drawing.Point(660, 39);
            this.btnDisHeart.Name = "btnDisHeart";
            this.btnDisHeart.Size = new System.Drawing.Size(40, 40);
            this.btnDisHeart.TabIndex = 10;
            this.btnDisHeart.UseVisualStyleBackColor = true;
            this.btnDisHeart.MouseLeave += new System.EventHandler(this.Button_Leave);
            this.btnDisHeart.MouseHover += new System.EventHandler(this.Button_Hover);
            // 
            // btnCollect
            // 
            this.btnCollect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCollect.FlatAppearance.BorderSize = 0;
            this.btnCollect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollect.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCollect.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            this.btnCollect.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCollect.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCollect.IconSize = 45;
            this.btnCollect.Location = new System.Drawing.Point(708, 39);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.Size = new System.Drawing.Size(40, 40);
            this.btnCollect.TabIndex = 9;
            this.btnCollect.UseVisualStyleBackColor = true;
            this.btnCollect.MouseLeave += new System.EventHandler(this.Button_Leave);
            this.btnCollect.MouseHover += new System.EventHandler(this.Button_Hover);
            // 
            // btnDownload
            // 
            this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDownload.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.btnDownload.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDownload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDownload.IconSize = 35;
            this.btnDownload.Location = new System.Drawing.Point(758, 39);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(40, 40);
            this.btnDownload.TabIndex = 8;
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.MouseLeave += new System.EventHandler(this.Button_Leave);
            this.btnDownload.MouseHover += new System.EventHandler(this.Button_Hover);
            // 
            // lbSongDate
            // 
            this.lbSongDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongDate.ForeColor = System.Drawing.Color.Gray;
            this.lbSongDate.Location = new System.Drawing.Point(157, 73);
            this.lbSongDate.Name = "lbSongDate";
            this.lbSongDate.Size = new System.Drawing.Size(346, 26);
            this.lbSongDate.TabIndex = 15;
            this.lbSongDate.Text = "Date";
            // 
            // lbSongSinger
            // 
            this.lbSongSinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongSinger.ForeColor = System.Drawing.Color.Gray;
            this.lbSongSinger.Location = new System.Drawing.Point(157, 47);
            this.lbSongSinger.Name = "lbSongSinger";
            this.lbSongSinger.Size = new System.Drawing.Size(346, 26);
            this.lbSongSinger.TabIndex = 14;
            this.lbSongSinger.Text = "Singer";
            // 
            // lbSongName
            // 
            this.lbSongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbSongName.Location = new System.Drawing.Point(154, 12);
            this.lbSongName.Name = "lbSongName";
            this.lbSongName.Size = new System.Drawing.Size(425, 35);
            this.lbSongName.TabIndex = 13;
            this.lbSongName.Text = "Name";
            // 
            // ptbSongImage
            // 
            this.ptbSongImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbSongImage.Location = new System.Drawing.Point(4, 3);
            this.ptbSongImage.Name = "ptbSongImage";
            this.ptbSongImage.Size = new System.Drawing.Size(144, 104);
            this.ptbSongImage.TabIndex = 12;
            this.ptbSongImage.TabStop = false;
            // 
            // LoveSongItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lbSongDate);
            this.Controls.Add(this.lbSongSinger);
            this.Controls.Add(this.lbSongName);
            this.Controls.Add(this.ptbSongImage);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnDisHeart);
            this.Controls.Add(this.btnCollect);
            this.Controls.Add(this.btnDownload);
            this.Name = "LoveSongItem";
            this.Size = new System.Drawing.Size(812, 106);
            ((System.ComponentModel.ISupportInitialize)(this.ptbSongImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public FontAwesome.Sharp.IconButton btnPlay;
        private FontAwesome.Sharp.IconButton btnDisHeart;
        private FontAwesome.Sharp.IconButton btnCollect;
        private FontAwesome.Sharp.IconButton btnDownload;
        private System.Windows.Forms.Label lbSongDate;
        private System.Windows.Forms.Label lbSongSinger;
        private System.Windows.Forms.Label lbSongName;
        private System.Windows.Forms.PictureBox ptbSongImage;
    }
}
