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
    public partial class fAddCollection : Form
    {
        private DataRow song;
        private Color[] rgbColors = new MyColors().RGBColors;
        public fAddCollection(DataRow s)
        {
            InitializeComponent();
            this.song = s;

            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            lbName.Text = song["name"].ToString();
            DirectoryInfo d = new DirectoryInfo(@"playlists");
            FileInfo[] Files = d.GetFiles("*.txt");
            foreach (FileInfo file in Files)
            {
                CheckBox cb = new CheckBox();
                cb.Text = file.Name.Split('.')[0];
                cb.Size = new Size(160, 30);
                cb.ForeColor = rgbColors[4];
                flpPlaylist.Controls.Add(cb);
            }
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
            foreach (CheckBox cb in flpPlaylist.Controls)
            {
                if (cb.Checked)
                {
                    string filePath = "playlists/" + cb.Text + ".txt";
                    List<string> lines = new List<string>();
                    lines = File.ReadAllLines(filePath).ToList();
                    lines.Add(song["id"].ToString());
                    File.WriteAllLines(filePath, lines);
                }
            }
            if (txbNewPlaylist.Text!="")
            {
                string filePath = "playlists/" + txbNewPlaylist.Text + ".txt";
                List<string> lines = new List<string>();
                lines.Add(song["id"].ToString());
                File.WriteAllLines(filePath, lines);
            }
            this.Close();
        }
    }
}
