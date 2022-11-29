namespace Music_Player.User_Controls
{
    partial class Review
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
            this.flpReviews = new System.Windows.Forms.FlowLayoutPanel();
            this.lbSongSinger = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.nmrUserStar = new System.Windows.Forms.NumericUpDown();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUserStar)).BeginInit();
            this.SuspendLayout();
            // 
            // flpReviews
            // 
            this.flpReviews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(78)))));
            this.flpReviews.Location = new System.Drawing.Point(16, -1);
            this.flpReviews.Name = "flpReviews";
            this.flpReviews.Size = new System.Drawing.Size(346, 271);
            this.flpReviews.TabIndex = 0;
            // 
            // lbSongSinger
            // 
            this.lbSongSinger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lbSongSinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongSinger.ForeColor = System.Drawing.Color.Gray;
            this.lbSongSinger.Location = new System.Drawing.Point(16, 275);
            this.lbSongSinger.Name = "lbSongSinger";
            this.lbSongSinger.Size = new System.Drawing.Size(58, 23);
            this.lbSongSinger.TabIndex = 6;
            this.lbSongSinger.Text = "Name:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(255, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Stars:";
            // 
            // txbUserName
            // 
            this.txbUserName.BackColor = System.Drawing.Color.Gainsboro;
            this.txbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.Location = new System.Drawing.Point(71, 272);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(163, 27);
            this.txbUserName.TabIndex = 8;
            // 
            // nmrUserStar
            // 
            this.nmrUserStar.BackColor = System.Drawing.Color.Gainsboro;
            this.nmrUserStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrUserStar.Location = new System.Drawing.Point(307, 272);
            this.nmrUserStar.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmrUserStar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrUserStar.Name = "nmrUserStar";
            this.nmrUserStar.Size = new System.Drawing.Size(55, 27);
            this.nmrUserStar.TabIndex = 9;
            this.nmrUserStar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rtbComment
            // 
            this.rtbComment.BackColor = System.Drawing.Color.Gainsboro;
            this.rtbComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbComment.Location = new System.Drawing.Point(19, 303);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(343, 36);
            this.rtbComment.TabIndex = 10;
            this.rtbComment.Text = "";
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.rtbComment);
            this.Controls.Add(this.nmrUserStar);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSongSinger);
            this.Controls.Add(this.flpReviews);
            this.Name = "Review";
            this.Size = new System.Drawing.Size(378, 350);
            ((System.ComponentModel.ISupportInitialize)(this.nmrUserStar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpReviews;
        private System.Windows.Forms.Label lbSongSinger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.NumericUpDown nmrUserStar;
        private System.Windows.Forms.RichTextBox rtbComment;
    }
}
