using Music_Player.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player.Forms
{
    public partial class fSongPlayer : Form
    {
        private DataRow song;
        public fSongPlayer(DataRow s)
        {
            InitializeComponent();
            this.song = s;

            ResourceManager songImageManager = new ResourceManager("Music_Player.SongImages", Assembly.GetExecutingAssembly());
            ptbSongImage.BackgroundImage = (Image)songImageManager.GetObject(string.Join("_", song["name"].ToString().Split(' ')));
            ptbSongImage.BackgroundImageLayout = ImageLayout.Zoom;

        }

        private void btnDiscription_Click(object sender, EventArgs e)
        {
            pContent.Controls.Clear();
            pContent.Controls.Add(new Description(song));
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            pContent.Controls.Clear();
        }
    }
}
