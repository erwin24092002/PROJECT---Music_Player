namespace Music_Player.User_Controls
{
    partial class Description
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
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lbSongDate = new System.Windows.Forms.Label();
            this.lbSongSinger = new System.Windows.Forms.Label();
            this.lbSongName = new System.Windows.Forms.Label();
            this.pStar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDescription.Location = new System.Drawing.Point(16, 105);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(346, 233);
            this.rtbDescription.TabIndex = 0;
            this.rtbDescription.Text = "";
            // 
            // lbSongDate
            // 
            this.lbSongDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongDate.ForeColor = System.Drawing.Color.Gray;
            this.lbSongDate.Location = new System.Drawing.Point(16, 84);
            this.lbSongDate.Name = "lbSongDate";
            this.lbSongDate.Size = new System.Drawing.Size(346, 18);
            this.lbSongDate.TabIndex = 6;
            this.lbSongDate.Text = "Date";
            // 
            // lbSongSinger
            // 
            this.lbSongSinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongSinger.ForeColor = System.Drawing.Color.Gray;
            this.lbSongSinger.Location = new System.Drawing.Point(16, 60);
            this.lbSongSinger.Name = "lbSongSinger";
            this.lbSongSinger.Size = new System.Drawing.Size(346, 18);
            this.lbSongSinger.TabIndex = 5;
            this.lbSongSinger.Text = "Singer";
            // 
            // lbSongName
            // 
            this.lbSongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbSongName.Location = new System.Drawing.Point(16, 5);
            this.lbSongName.Name = "lbSongName";
            this.lbSongName.Size = new System.Drawing.Size(346, 28);
            this.lbSongName.TabIndex = 4;
            this.lbSongName.Text = "Name";
            this.lbSongName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pStar
            // 
            this.pStar.Location = new System.Drawing.Point(16, 36);
            this.pStar.Name = "pStar";
            this.pStar.Size = new System.Drawing.Size(346, 21);
            this.pStar.TabIndex = 7;
            // 
            // Description
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.pStar);
            this.Controls.Add(this.lbSongDate);
            this.Controls.Add(this.lbSongSinger);
            this.Controls.Add(this.lbSongName);
            this.Controls.Add(this.rtbDescription);
            this.Name = "Description";
            this.Size = new System.Drawing.Size(378, 350);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lbSongDate;
        private System.Windows.Forms.Label lbSongSinger;
        private System.Windows.Forms.Label lbSongName;
        private System.Windows.Forms.Panel pStar;
    }
}
