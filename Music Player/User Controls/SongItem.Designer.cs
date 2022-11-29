namespace Music_Player.User_Controls
{
    partial class SongItem
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
            this.ptbSongImage = new System.Windows.Forms.PictureBox();
            this.lbSongName = new System.Windows.Forms.Label();
            this.lbSongSinger = new System.Windows.Forms.Label();
            this.lbSongDate = new System.Windows.Forms.Label();
            this.btnDownload = new FontAwesome.Sharp.IconButton();
            this.btnCollect = new FontAwesome.Sharp.IconButton();
            this.btnHeart = new FontAwesome.Sharp.IconButton();
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSongImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbSongImage
            // 
            this.ptbSongImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbSongImage.Location = new System.Drawing.Point(3, 3);
            this.ptbSongImage.Name = "ptbSongImage";
            this.ptbSongImage.Size = new System.Drawing.Size(144, 104);
            this.ptbSongImage.TabIndex = 0;
            this.ptbSongImage.TabStop = false;
            // 
            // lbSongName
            // 
            this.lbSongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbSongName.Location = new System.Drawing.Point(153, 12);
            this.lbSongName.Name = "lbSongName";
            this.lbSongName.Size = new System.Drawing.Size(425, 35);
            this.lbSongName.TabIndex = 1;
            this.lbSongName.Text = "Name";
            // 
            // lbSongSinger
            // 
            this.lbSongSinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongSinger.ForeColor = System.Drawing.Color.Gray;
            this.lbSongSinger.Location = new System.Drawing.Point(156, 47);
            this.lbSongSinger.Name = "lbSongSinger";
            this.lbSongSinger.Size = new System.Drawing.Size(346, 26);
            this.lbSongSinger.TabIndex = 2;
            this.lbSongSinger.Text = "Singer";
            // 
            // lbSongDate
            // 
            this.lbSongDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongDate.ForeColor = System.Drawing.Color.Gray;
            this.lbSongDate.Location = new System.Drawing.Point(156, 73);
            this.lbSongDate.Name = "lbSongDate";
            this.lbSongDate.Size = new System.Drawing.Size(346, 26);
            this.lbSongDate.TabIndex = 3;
            this.lbSongDate.Text = "Date";
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
            this.btnDownload.Location = new System.Drawing.Point(757, 36);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(40, 40);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.UseVisualStyleBackColor = true;
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
            this.btnCollect.Location = new System.Drawing.Point(707, 36);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.Size = new System.Drawing.Size(40, 40);
            this.btnCollect.TabIndex = 5;
            this.btnCollect.UseVisualStyleBackColor = true;
            // 
            // btnHeart
            // 
            this.btnHeart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHeart.FlatAppearance.BorderSize = 0;
            this.btnHeart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeart.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHeart.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnHeart.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHeart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHeart.IconSize = 45;
            this.btnHeart.Location = new System.Drawing.Point(659, 36);
            this.btnHeart.Name = "btnHeart";
            this.btnHeart.Size = new System.Drawing.Size(40, 40);
            this.btnHeart.TabIndex = 6;
            this.btnHeart.UseVisualStyleBackColor = true;
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
            this.btnPlay.Location = new System.Drawing.Point(609, 36);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(40, 40);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // SongItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnHeart);
            this.Controls.Add(this.btnCollect);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lbSongDate);
            this.Controls.Add(this.lbSongSinger);
            this.Controls.Add(this.lbSongName);
            this.Controls.Add(this.ptbSongImage);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(25, 20, 0, 3);
            this.Name = "SongItem";
            this.Size = new System.Drawing.Size(816, 110);
            ((System.ComponentModel.ISupportInitialize)(this.ptbSongImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbSongImage;
        private System.Windows.Forms.Label lbSongName;
        private System.Windows.Forms.Label lbSongSinger;
        private System.Windows.Forms.Label lbSongDate;
        private FontAwesome.Sharp.IconButton btnDownload;
        private FontAwesome.Sharp.IconButton btnCollect;
        private FontAwesome.Sharp.IconButton btnHeart;
        private FontAwesome.Sharp.IconButton btnPlay;
    }
}
