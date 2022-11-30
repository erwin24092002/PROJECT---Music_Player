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
using System.Windows.Markup;

namespace Music_Player.Forms
{
    public partial class fSongs : Form
    {
        private DataTable songs = new MySongs().Songs;
        private SongItem[] songItems;
        public fSongs(SongItem[] st)
        {
            InitializeComponent();
            this.songItems = st;
            RenderSongs();
        }
        private void RenderSongs()
        {
            flpSongs.Controls.Clear();
            foreach (DataRow song in songs.Select("name like '%" + txbSearch.Text + "%' OR singer like '%" + txbSearch.Text + "%'"))
            {
                if (!cbVPop.Checked && song["type"].ToString() == "VPop")
                    continue;
                if (!cbJPop.Checked && song["type"].ToString() == "JPop")
                    continue;
                if (!cbCPop.Checked && song["type"].ToString() == "CPop")
                    continue;
                if (!cbKPop.Checked && song["type"].ToString() == "KPop")
                    continue;
                if (!cbUSUK.Checked && song["type"].ToString() == "USUK")
                    continue;
                if (!cbLow.Checked && Int16.Parse(song["star"].ToString()) <= 2)
                    continue;
                if (!cbMedium.Checked && Int16.Parse(song["star"].ToString()) == 3)
                    continue;
                if (!cbHigh.Checked && Int16.Parse(song["star"].ToString()) >= 4)
                    continue;

                int id = Int32.Parse(song["id"].ToString());
                flpSongs.Controls.Add(songItems[id]);
            }
        }

        private void SelectChange(object sender, EventArgs e)
        {
            RenderSongs();
        }
    }
}
