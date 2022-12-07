using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player.User_Controls
{
    public partial class Playlist : UserControl
    {
        private FileInfo file;
        private DataTable songs = new MySongs().Songs;
        private Color[] rgbColors = new MyColors().RGBColors;
        public Playlist(FileInfo fi)
        {
            InitializeComponent();
            file = fi;

            lbPlaylistName.Text = file.Name.Split('.')[0];
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
        }

        private void btnRemove_MouseLeave(object sender, EventArgs e)
        {
            ((IconButton)sender).IconColor = rgbColors[4];
        }

        private void btnRemove_MouseHover(object sender, EventArgs e)
        {
            ((IconButton)sender).IconColor = Color.Red;
        }
    }
}
