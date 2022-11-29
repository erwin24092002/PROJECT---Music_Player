using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player.User_Controls
{
    public partial class Description : UserControl
    {
        private DataRow song;
        public Description(DataRow s)
        {
            InitializeComponent();
            song = s;

            lbSongName.Text = song["name"].ToString();
            lbSongSinger.Text = "Singer: " + song["singer"].ToString();
            lbSongDate.Text = "Date: " + song["date"].ToString();
        }
    }
}
