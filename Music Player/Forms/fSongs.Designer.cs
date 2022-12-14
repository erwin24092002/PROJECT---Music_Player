namespace Music_Player.Forms
{
    partial class fSongs
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
            this.pSearch = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbHigh = new System.Windows.Forms.CheckBox();
            this.cbMedium = new System.Windows.Forms.CheckBox();
            this.cbLow = new System.Windows.Forms.CheckBox();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.cbUSUK = new System.Windows.Forms.CheckBox();
            this.cbKPop = new System.Windows.Forms.CheckBox();
            this.cbCPop = new System.Windows.Forms.CheckBox();
            this.cbJPop = new System.Windows.Forms.CheckBox();
            this.cbVPop = new System.Windows.Forms.CheckBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.flpSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.pSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbType.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSearch
            // 
            this.pSearch.Controls.Add(this.groupBox1);
            this.pSearch.Controls.Add(this.gbType);
            this.pSearch.Controls.Add(this.btnSearch);
            this.pSearch.Controls.Add(this.txbSearch);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSearch.Location = new System.Drawing.Point(0, 0);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(765, 90);
            this.pSearch.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.cbHigh);
            this.groupBox1.Controls.Add(this.cbMedium);
            this.groupBox1.Controls.Add(this.cbLow);
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(464, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 49);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hot";
            // 
            // cbHigh
            // 
            this.cbHigh.AutoSize = true;
            this.cbHigh.Checked = true;
            this.cbHigh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHigh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbHigh.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHigh.Location = new System.Drawing.Point(203, 24);
            this.cbHigh.Name = "cbHigh";
            this.cbHigh.Size = new System.Drawing.Size(65, 22);
            this.cbHigh.TabIndex = 2;
            this.cbHigh.Text = "High";
            this.cbHigh.UseVisualStyleBackColor = true;
            this.cbHigh.CheckedChanged += new System.EventHandler(this.SelectChange);
            // 
            // cbMedium
            // 
            this.cbMedium.AutoSize = true;
            this.cbMedium.Checked = true;
            this.cbMedium.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMedium.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedium.Location = new System.Drawing.Point(104, 24);
            this.cbMedium.Name = "cbMedium";
            this.cbMedium.Size = new System.Drawing.Size(88, 22);
            this.cbMedium.TabIndex = 1;
            this.cbMedium.Text = "Medium";
            this.cbMedium.UseVisualStyleBackColor = true;
            this.cbMedium.CheckedChanged += new System.EventHandler(this.SelectChange);
            // 
            // cbLow
            // 
            this.cbLow.AutoSize = true;
            this.cbLow.Checked = true;
            this.cbLow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLow.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLow.Location = new System.Drawing.Point(26, 24);
            this.cbLow.Name = "cbLow";
            this.cbLow.Size = new System.Drawing.Size(60, 22);
            this.cbLow.TabIndex = 0;
            this.cbLow.Text = "Low";
            this.cbLow.UseVisualStyleBackColor = true;
            this.cbLow.CheckedChanged += new System.EventHandler(this.SelectChange);
            // 
            // gbType
            // 
            this.gbType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbType.Controls.Add(this.cbUSUK);
            this.gbType.Controls.Add(this.cbKPop);
            this.gbType.Controls.Add(this.cbCPop);
            this.gbType.Controls.Add(this.cbJPop);
            this.gbType.Controls.Add(this.cbVPop);
            this.gbType.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbType.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbType.Location = new System.Drawing.Point(33, 37);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(408, 49);
            this.gbType.TabIndex = 2;
            this.gbType.TabStop = false;
            this.gbType.Text = "Type";
            // 
            // cbUSUK
            // 
            this.cbUSUK.AutoSize = true;
            this.cbUSUK.Checked = true;
            this.cbUSUK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUSUK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbUSUK.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUSUK.Location = new System.Drawing.Point(322, 24);
            this.cbUSUK.Name = "cbUSUK";
            this.cbUSUK.Size = new System.Drawing.Size(75, 22);
            this.cbUSUK.TabIndex = 4;
            this.cbUSUK.Text = "USUK";
            this.cbUSUK.UseVisualStyleBackColor = true;
            this.cbUSUK.CheckedChanged += new System.EventHandler(this.SelectChange);
            // 
            // cbKPop
            // 
            this.cbKPop.AutoSize = true;
            this.cbKPop.Checked = true;
            this.cbKPop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbKPop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbKPop.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKPop.Location = new System.Drawing.Point(248, 24);
            this.cbKPop.Name = "cbKPop";
            this.cbKPop.Size = new System.Drawing.Size(69, 22);
            this.cbKPop.TabIndex = 3;
            this.cbKPop.Text = "KPop";
            this.cbKPop.UseVisualStyleBackColor = true;
            this.cbKPop.CheckedChanged += new System.EventHandler(this.SelectChange);
            // 
            // cbCPop
            // 
            this.cbCPop.AutoSize = true;
            this.cbCPop.Checked = true;
            this.cbCPop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCPop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCPop.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCPop.Location = new System.Drawing.Point(174, 24);
            this.cbCPop.Name = "cbCPop";
            this.cbCPop.Size = new System.Drawing.Size(68, 22);
            this.cbCPop.TabIndex = 2;
            this.cbCPop.Text = "CPop";
            this.cbCPop.UseVisualStyleBackColor = true;
            this.cbCPop.CheckedChanged += new System.EventHandler(this.SelectChange);
            // 
            // cbJPop
            // 
            this.cbJPop.AutoSize = true;
            this.cbJPop.Checked = true;
            this.cbJPop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbJPop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbJPop.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJPop.Location = new System.Drawing.Point(100, 24);
            this.cbJPop.Name = "cbJPop";
            this.cbJPop.Size = new System.Drawing.Size(65, 22);
            this.cbJPop.TabIndex = 1;
            this.cbJPop.Text = "JPop";
            this.cbJPop.UseVisualStyleBackColor = true;
            this.cbJPop.CheckedChanged += new System.EventHandler(this.SelectChange);
            // 
            // cbVPop
            // 
            this.cbVPop.AutoSize = true;
            this.cbVPop.Checked = true;
            this.cbVPop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVPop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbVPop.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVPop.Location = new System.Drawing.Point(26, 24);
            this.cbVPop.Name = "cbVPop";
            this.cbVPop.Size = new System.Drawing.Size(68, 22);
            this.cbVPop.TabIndex = 0;
            this.cbVPop.Text = "VPop";
            this.cbVPop.UseVisualStyleBackColor = true;
            this.cbVPop.CheckedChanged += new System.EventHandler(this.SelectChange);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 33;
            this.btnSearch.Location = new System.Drawing.Point(105, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txbSearch
            // 
            this.txbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.txbSearch.Location = new System.Drawing.Point(146, 4);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(517, 34);
            this.txbSearch.TabIndex = 0;
            this.txbSearch.TextChanged += new System.EventHandler(this.SelectChange);
            // 
            // flpSongs
            // 
            this.flpSongs.AutoScroll = true;
            this.flpSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.flpSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSongs.Location = new System.Drawing.Point(0, 90);
            this.flpSongs.Name = "flpSongs";
            this.flpSongs.Size = new System.Drawing.Size(765, 383);
            this.flpSongs.TabIndex = 1;
            // 
            // fSongs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(765, 473);
            this.Controls.Add(this.flpSongs);
            this.Controls.Add(this.pSearch);
            this.Name = "fSongs";
            this.Text = "fSongs";
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSearch;
        public System.Windows.Forms.FlowLayoutPanel flpSongs;
        private System.Windows.Forms.TextBox txbSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.CheckBox cbVPop;
        private System.Windows.Forms.CheckBox cbUSUK;
        private System.Windows.Forms.CheckBox cbKPop;
        private System.Windows.Forms.CheckBox cbCPop;
        private System.Windows.Forms.CheckBox cbJPop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbHigh;
        private System.Windows.Forms.CheckBox cbMedium;
        private System.Windows.Forms.CheckBox cbLow;
    }
}