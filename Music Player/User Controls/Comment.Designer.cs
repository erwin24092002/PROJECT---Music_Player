namespace Music_Player.User_Controls
{
    partial class Comment
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
            this.lbUserName = new System.Windows.Forms.Label();
            this.pStar = new System.Windows.Forms.Panel();
            this.lbComment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.BackColor = System.Drawing.Color.Transparent;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbUserName.Location = new System.Drawing.Point(3, 3);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(307, 19);
            this.lbUserName.TabIndex = 7;
            this.lbUserName.Text = "Name:";
            // 
            // pStar
            // 
            this.pStar.Location = new System.Drawing.Point(6, 21);
            this.pStar.Name = "pStar";
            this.pStar.Size = new System.Drawing.Size(311, 19);
            this.pStar.TabIndex = 8;
            // 
            // lbComment
            // 
            this.lbComment.BackColor = System.Drawing.Color.Transparent;
            this.lbComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComment.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbComment.Location = new System.Drawing.Point(3, 43);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(307, 19);
            this.lbComment.TabIndex = 9;
            this.lbComment.Text = "Comment";
            // 
            // Comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.lbComment);
            this.Controls.Add(this.pStar);
            this.Controls.Add(this.lbUserName);
            this.Margin = new System.Windows.Forms.Padding(10, 5, 3, 3);
            this.Name = "Comment";
            this.Size = new System.Drawing.Size(305, 67);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Panel pStar;
        private System.Windows.Forms.Label lbComment;
    }
}
