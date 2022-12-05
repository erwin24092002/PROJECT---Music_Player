using FontAwesome.Sharp;
using Music_Player.Forms;
using Music_Player.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class fMainMenu : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private MyColors myColors = new MyColors();
        private Form currentChildForm;
        private Form currentMusicPlayer;
        private DataTable songs = new MySongs().Songs;
        public fMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 55);
            pMenu.Controls.Add(leftBorderBtn);
            
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private SongItem[] create_SongItems()
        {
            SongItem[] st = new SongItem[31];
            for (int i = 1; i <= 30; i++)
            {
                SongItem songItem = new SongItem(songs.Rows[i - 1]);
                st[i] = songItem;
                st[i].Tag = songs.Rows[i - 1];
                st[i].btnPlay.Tag = songs.Rows[i - 1];
                st[i].btnPlay.Click += btnPlay_Click;

                st[i].btnHeart.Tag = songs.Rows[i - 1];
                st[i].btnHeart.Click += btnHeart_Click;

                st[i].btnCollect.Tag = songs.Rows[i - 1];
                st[i].btnCollect.Click += btnCollect_Click;

                st[i].btnDownload.Tag = songs.Rows[i - 1];
                st[i].btnDownload.Click += btnDownload_Click;
            }
            return st;
        }

        private void ActivateButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();
                currentBtn = (IconButton)sender;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pChildForm.Controls.Add(childForm);
            pChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void OpenMusicPlayer(Form musicPlayer)
        {
            if (currentMusicPlayer != null)
            {
                currentMusicPlayer.Close();
            }
            currentMusicPlayer = musicPlayer;
            musicPlayer.Size = pSongPlayer.Size;
            musicPlayer.TopLevel = false;
            musicPlayer.FormBorderStyle = FormBorderStyle.None;
            musicPlayer.Dock = DockStyle.Fill;
            pSongPlayer.Controls.Add(musicPlayer);
            pSongPlayer.Tag = musicPlayer;
            musicPlayer.BringToFront();
            musicPlayer.Show();
        }

        private void btnSongs_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, myColors.RGBColors[0]);
            fSongs f = new fSongs(create_SongItems());
            OpenChildForm(f);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            OpenMusicPlayer(new fSongPlayer((DataRow)((IconButton)sender).Tag));
        }

        private void btnPlaylists_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, myColors.RGBColors[4]);
            OpenChildForm(new fPlaylists());
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            if (currentMusicPlayer != null)
            {
                currentMusicPlayer.Close();
            }
        }

        // Drag Form
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
            Application.Exit();
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            ((IconButton)sender).IconColor = Color.Gainsboro;
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            ((IconButton)sender).IconColor = Color.Red;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ptbLogo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private List<LoveSongItem> create_LoveSongItems()
        {
            List<LoveSongItem> loveSongItems = new List<LoveSongItem>();
            string filePath = "love_songs.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            foreach(string line in lines)
            {
                DataRow tmp_s = songs.Select("id='" + line + "'")[0];
                LoveSongItem tmp = new LoveSongItem(tmp_s);
                tmp.Tag = tmp_s;
                tmp.btnPlay.Tag = tmp_s;
                tmp.btnPlay.Click += btnPlay_Click;

                tmp.btnDisHeart.Tag = tmp_s;
                tmp.btnDisHeart.Click += btnDisHeart_Click;

                tmp.btnCollect.Tag = tmp_s;
                tmp.btnCollect.Click += btnCollect_Click;

                tmp.btnDownload.Tag = tmp_s;
                tmp.btnDownload.Click += btnDownload_Click;

                loveSongItems.Add(tmp);
            }
            return loveSongItems;
        }

        private void btnLoveSongs_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, myColors.RGBColors[1]);
            fLoveSongs f = new fLoveSongs(create_LoveSongItems());
            OpenChildForm(f);
        }
        private void btnHeart_Click(object sender, EventArgs e)
        {
            DataRow tmp_s = (DataRow)((IconButton)sender).Tag;
            string filePath = "love_songs.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            foreach(string line in lines)
            {
                if (tmp_s["id"].ToString() == line)
                    return;
            }
            lines.Add(tmp_s["id"].ToString());
            File.WriteAllLines(filePath, lines);
        }

        private void btnDisHeart_Click(object sender, EventArgs e)
        {
            DataRow tmp_s = (DataRow)((IconButton)sender).Tag;
            //MessageBox.Show(tmp_s["id"].ToString());
            string filePath = "love_songs.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            List<string> new_lines = new List<string>();
            foreach (string line in lines)
            {
                //MessageBox.Show(line);
                if (tmp_s["id"].ToString() == line)
                    continue;
                new_lines.Add(line);
            }
            File.WriteAllLines(filePath, new_lines);
            //ActivateButton(sender, myColors.RGBColors[1]);
            fLoveSongs f = new fLoveSongs(create_LoveSongItems());
            OpenChildForm(f);
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            DataRow tmp_s = (DataRow)((IconButton)sender).Tag;
            fDownload f = new fDownload(tmp_s);
            f.ShowDialog();
        }

        private void btnCollect_Click(object sender, EventArgs e)
        {
            DataRow tmp_s = (DataRow)((IconButton)sender).Tag;
            fAddCollection f = new fAddCollection(tmp_s);
            f.ShowDialog();
        }
    }
}
