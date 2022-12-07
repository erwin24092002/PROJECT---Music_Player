using FontAwesome.Sharp;
using Music_Player.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Music_Player.Forms
{
    public partial class fPlaylists : Form
    {
        private List<Playlist> playlists;
        public fPlaylists(List<Playlist> pl)
        {
            InitializeComponent();
            this.playlists = pl;

            RenderPlaylist();
        }

        private void RenderPlaylist()
        {
            flpPlaylists.Controls.Clear();
            foreach(Playlist playlist in playlists)
            {
                if (!((FileInfo)(playlist.Tag)).Name.Split('.')[0].ToLower().Contains(txbSearch.Text.ToLower()))
                    continue;
               
                flpPlaylists.Controls.Add(playlist);
            }
        }
        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            RenderPlaylist();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string fileName = ((FileInfo)(((IconButton)sender).Tag)).Name;
            File.Delete(@"playlists/" + fileName);
            RenderPlaylist();
        }
    }
}
