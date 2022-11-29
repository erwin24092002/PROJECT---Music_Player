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
    public partial class SongItem : UserControl
    {
        private DataRow song;
        public SongItem(DataRow s)
        {
            InitializeComponent();
            song = s;

            ResourceManager songImageManager = new ResourceManager("Music_Player.SongImages", Assembly.GetExecutingAssembly());
            ptbSongImage.BackgroundImage = (Image)songImageManager.GetObject(string.Join("_", song["name"].ToString().Split(' ')));
            ptbSongImage.BackgroundImageLayout = ImageLayout.Zoom;

            lbSongName.Text = song["name"].ToString();
            lbSongSinger.Text = song["singer"].ToString();
            lbSongDate.Text = song["date"].ToString();
        }
    }
}
