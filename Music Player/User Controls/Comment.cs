using FontAwesome.Sharp;
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
    public partial class Comment : UserControl
    {
        private Color[] rgbColors;
        public Comment(string comment)
        {
            InitializeComponent();
            rgbColors = new MyColors().RGBColors;
            string[] info = comment.Split(',');
            lbUserName.Text = info[0];

            int num_star = Int32.Parse(info[1]);
            int w = 20;
            int h = 20;
            int cur_x = 0;
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

            lbComment.Text = info[2];
            
        }

        private void Button_Hover(object sender, EventArgs e)
        {
            ((IconButton)sender).IconColor = rgbColors[0];
        }
        private void Button_Leave(object sender, EventArgs e)
        {
            ((IconButton)sender).IconColor = Color.Gainsboro;
        }
    }
}
