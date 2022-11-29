﻿namespace Music_Player.Forms
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
            this.pHeader = new System.Windows.Forms.Panel();
            this.pControl = new System.Windows.Forms.Panel();
            this.pContent = new System.Windows.Forms.Panel();
            this.btnReview = new FontAwesome.Sharp.IconButton();
            this.btnDiscription = new FontAwesome.Sharp.IconButton();
            this.ptbSongImage = new System.Windows.Forms.PictureBox();
            this.pHeader.SuspendLayout();
            this.pControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSongImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pHeader
            // 
            this.pHeader.Controls.Add(this.ptbSongImage);
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(378, 230);
            this.pHeader.TabIndex = 2;
            // 
            // pControl
            // 
            this.pControl.Controls.Add(this.btnReview);
            this.pControl.Controls.Add(this.btnDiscription);
            this.pControl.Location = new System.Drawing.Point(0, 230);
            this.pControl.Name = "pControl";
            this.pControl.Size = new System.Drawing.Size(378, 44);
            this.pControl.TabIndex = 3;
            // 
            // pContent
            // 
            this.pContent.Location = new System.Drawing.Point(0, 274);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(378, 350);
            this.pContent.TabIndex = 4;
            // 
            // btnReview
            // 
            this.btnReview.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReview.FlatAppearance.BorderSize = 0;
            this.btnReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReview.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReview.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReview.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReview.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReview.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReview.IconSize = 32;
            this.btnReview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReview.Location = new System.Drawing.Point(190, 3);
            this.btnReview.Name = "btnReview";
            this.btnReview.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReview.Size = new System.Drawing.Size(173, 38);
            this.btnReview.TabIndex = 3;
            this.btnReview.Text = "Review";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnDiscription
            // 
            this.btnDiscription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDiscription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscription.FlatAppearance.BorderSize = 0;
            this.btnDiscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscription.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscription.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDiscription.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDiscription.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDiscription.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDiscription.IconSize = 32;
            this.btnDiscription.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscription.Location = new System.Drawing.Point(15, 3);
            this.btnDiscription.Name = "btnDiscription";
            this.btnDiscription.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDiscription.Size = new System.Drawing.Size(175, 38);
            this.btnDiscription.TabIndex = 2;
            this.btnDiscription.Text = "Discription";
            this.btnDiscription.UseVisualStyleBackColor = true;
            this.btnDiscription.Click += new System.EventHandler(this.btnDiscription_Click);
            // 
            // ptbSongImage
            // 
            this.ptbSongImage.Location = new System.Drawing.Point(12, 12);
            this.ptbSongImage.Name = "ptbSongImage";
            this.ptbSongImage.Size = new System.Drawing.Size(354, 174);
            this.ptbSongImage.TabIndex = 0;
            this.ptbSongImage.TabStop = false;
            // 
            // fSongPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(378, 623);
            this.Controls.Add(this.pContent);
            this.Controls.Add(this.pControl);
            this.Controls.Add(this.pHeader);
            this.Name = "fSongPlayer";
            this.Text = "fSongPlayer";
            this.pHeader.ResumeLayout(false);
            this.pControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbSongImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Panel pControl;
        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.PictureBox ptbSongImage;
        private FontAwesome.Sharp.IconButton btnReview;
        private FontAwesome.Sharp.IconButton btnDiscription;
    }
}