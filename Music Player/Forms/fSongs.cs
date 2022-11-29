using Music_Player.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player.Forms
{
    public partial class fSongs : Form
    {
        private DataTable songs = new MySongs().Songs;
        public fSongs()
        {
            InitializeComponent();
            RenderSongs();
        }
        private void RenderSongs()
        {
            foreach (DataRow song in songs.Rows)
            {
                SongItem songItem = new SongItem(song);
                flpSongs.Controls.Add(songItem);
            }
        }
    }
}
