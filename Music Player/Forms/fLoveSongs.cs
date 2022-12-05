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
    public partial class fLoveSongs : Form
    {
        List<LoveSongItem> love_songs;
        public fLoveSongs(List<LoveSongItem> lsi)
        {
            InitializeComponent();
            love_songs = lsi;
            RenderSongs();
        }

        private void RenderSongs()
        {
            flpSongs.Controls.Clear();
            for (int i=0; i<love_songs.Count; i++)
            {
                DataRow song = (DataRow)love_songs[i].Tag;
                if (!(song["name"].ToString().ToLower().Contains(txbSearch.Text.ToLower()) || song["singer"].ToString().ToLower().Contains(txbSearch.Text.ToLower())))
                    continue;
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

                flpSongs.Controls.Add(love_songs[i]);
            }
        }
        private void SelectChange(object sender, EventArgs e)
        {
            RenderSongs();
        }


    }
}
