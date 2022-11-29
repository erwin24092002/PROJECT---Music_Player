using FontAwesome.Sharp;
using Music_Player.User_Controls;
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

namespace Music_Player.Forms
{
    public partial class fSongPlayer : Form
    {
        private DataRow song;
        private Color[] rgbColors;
        private Panel bottomBorderBtn;
        private IconButton currentBtn;
        public fSongPlayer(DataRow s)
        {
            InitializeComponent();
            this.song = s;
            rgbColors = new MyColors().RGBColors;

            bottomBorderBtn = new Panel();
            bottomBorderBtn.Size = new Size(172, 5);
            pControl.Controls.Add(bottomBorderBtn);

            ResourceManager songImageManager = new ResourceManager("Music_Player.SongImages", Assembly.GetExecutingAssembly());
            ptbSongImage.BackgroundImage = (Image)songImageManager.GetObject(string.Join("_", song["name"].ToString().Split(' ')));
            ptbSongImage.BackgroundImageLayout = ImageLayout.Zoom;

            pContent.Controls.Clear();
            pContent.Controls.Add(new Description(song));
        }

        private void ActivateButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();
                currentBtn = (IconButton)sender;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;

                bottomBorderBtn.BackColor = color;
                bottomBorderBtn.Location = new Point(currentBtn.Location.X, currentBtn.Location.Y);
                bottomBorderBtn.Visible = true;
                bottomBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.IconColor = Color.Gainsboro;
            }
        }

        private void btnDiscription_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, rgbColors[0]);
            pContent.Controls.Clear();
            pContent.Controls.Add(new Description(song));
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, rgbColors[0]);
            pContent.Controls.Clear();
            pContent.Controls.Add(new Review(song));
        }
    }
}
