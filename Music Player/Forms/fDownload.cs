using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player.Forms
{
    public partial class fDownload : Form
    {
        DataRow song;
        public fDownload(DataRow s)
        {
            InitializeComponent();
            song = s;

            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            this.txbAddress.Text = System.IO.Directory.GetCurrentDirectory();
            lbName.Text = song["name"].ToString();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pTitleChileForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            ((IconButton)sender).IconColor = Color.Gainsboro;
        }
        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            ((IconButton)sender).IconColor = Color.Red;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txbAddress.Text == "")
                MessageBox.Show("Empty path!");
            else
            {
                string sourceFile = @"song_mp4/" + song["name"].ToString() + ".mp4";
                string destinationFile = txbAddress.Text + "/" + song["name"].ToString() + ".mp4";
                try
                {
                    File.Copy(sourceFile, destinationFile, true);
                    MessageBox.Show("Successfully download the song!");
                    this.Close();
                }
                catch (IOException iox)
                {
                    MessageBox.Show("Non-existent path!");
                }
            }
        }
    }
}
