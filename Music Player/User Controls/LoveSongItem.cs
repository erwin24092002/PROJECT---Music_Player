using FontAwesome.Sharp;
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

namespace Music_Player.User_Controls
{
    public partial class LoveSongItem : UserControl
    {
        private DataRow song;
        private Color[] rgbColors;
        public LoveSongItem(DataRow s)
        {
            InitializeComponent();
            song = s;
            rgbColors = new MyColors().RGBColors;

            ResourceManager songImageManager = new ResourceManager("Music_Player.SongImages", Assembly.GetExecutingAssembly());
            ptbSongImage.BackgroundImage = (Image)songImageManager.GetObject(string.Join("_", song["name"].ToString().Split(' ')));
            ptbSongImage.BackgroundImageLayout = ImageLayout.Zoom;

            lbSongName.Text = song["name"].ToString();
            lbSongSinger.Text = song["singer"].ToString();
            lbSongDate.Text = song["date"].ToString();

            btnPlay.Tag = song;
        }
        private void Button_Hover(object sender, EventArgs e)
        {
            ((IconButton)sender).IconColor = rgbColors[1];
        }
        private void Button_Leave(object sender, EventArgs e)
        {
            ((IconButton)sender).IconColor = Color.Gainsboro;
        }
    }
}
