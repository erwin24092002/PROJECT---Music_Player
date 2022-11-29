using FontAwesome.Sharp;
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

            int num_star = Int32.Parse(song["star"].ToString());
            int w = 25;
            int h = 25;
            int cur_x = 346 / 2 - w * num_star / 2;
            int cur_y = 0;
            for (int i = 1; i <= num_star; i++)
            {
                IconPictureBox star = new IconPictureBox();
                star.IconChar = IconChar.Star;
                star.ForeColor = Color.Gold;
                star.Location = new Point(cur_x, cur_y);
                star.Size = new Size(w, h);
                pStar.Controls.Add(star);
                cur_x += w;
            }

            string filePath = "lyrics/" + song["name"].ToString() + ".txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            rtbDescription.Text = string.Join("\n", lines);
        }
    }
}
