namespace Music_Player.User_Controls
{
    partial class Playlist
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
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            this.lbPlaylistName = new System.Windows.Forms.Label();
            this.flpSonglist = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnRemove.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnRemove.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemove.IconSize = 25;
            this.btnRemove.Location = new System.Drawing.Point(358, 7);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(35, 28);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.MouseLeave += new System.EventHandler(this.btnRemove_MouseLeave);
            this.btnRemove.MouseHover += new System.EventHandler(this.btnRemove_MouseHover);
            // 
            // lbPlaylistName
            // 
            this.lbPlaylistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaylistName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.lbPlaylistName.Location = new System.Drawing.Point(3, 3);
            this.lbPlaylistName.Name = "lbPlaylistName";
            this.lbPlaylistName.Size = new System.Drawing.Size(388, 35);
            this.lbPlaylistName.TabIndex = 14;
            this.lbPlaylistName.Text = "Name";
            this.lbPlaylistName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpSonglist
            // 
            this.flpSonglist.AllowDrop = true;
            this.flpSonglist.AutoScroll = true;
            this.flpSonglist.Cursor = System.Windows.Forms.Cursors.Default;
            this.flpSonglist.Location = new System.Drawing.Point(3, 41);
            this.flpSonglist.Name = "flpSonglist";
            this.flpSonglist.Size = new System.Drawing.Size(394, 118);
            this.flpSonglist.TabIndex = 15;
            // 
            // Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.flpSonglist);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbPlaylistName);
            this.Margin = new System.Windows.Forms.Padding(25, 20, 3, 3);
            this.Name = "Playlist";
            this.Size = new System.Drawing.Size(396, 164);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnRemove;
        private System.Windows.Forms.Label lbPlaylistName;
        public System.Windows.Forms.FlowLayoutPanel flpSonglist;
    }
}
