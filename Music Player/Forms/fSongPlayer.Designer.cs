namespace Music_Player.Forms
{
    partial class fSongPlayer
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
            this.pControl = new System.Windows.Forms.Panel();
            this.pContent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pControl
            // 
            this.pControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControl.Location = new System.Drawing.Point(0, 0);
            this.pControl.Name = "pControl";
            this.pControl.Size = new System.Drawing.Size(360, 248);
            this.pControl.TabIndex = 0;
            // 
            // pContent
            // 
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Location = new System.Drawing.Point(0, 248);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(360, 325);
            this.pContent.TabIndex = 1;
            // 
            // fSongPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(360, 573);
            this.Controls.Add(this.pContent);
            this.Controls.Add(this.pControl);
            this.Name = "fSongPlayer";
            this.Text = "fSongPlayer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pControl;
        private System.Windows.Forms.Panel pContent;
    }
}