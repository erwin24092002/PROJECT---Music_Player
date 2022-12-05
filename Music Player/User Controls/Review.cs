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
    public partial class Review : UserControl
    {
        private DataRow song;
        private Color[] rgbColors;
        public Review(DataRow s)
        {
            InitializeComponent();
            song = s;
            rgbColors = new MyColors().RGBColors;

            RenderReview();
        }
        private void RenderReview()
        {
            flpReviews.Controls.Clear();
            string filePath = "comments/" + song["name"].ToString() + ".txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                Comment comment = new Comment(line);
                flpReviews.Controls.Add(comment);
            }
        }
        private void Button_Hover(object sender, EventArgs e)
        {
            ((IconButton)sender).IconColor = rgbColors[0];
            ((IconButton)sender).ForeColor = rgbColors[0];
        }
        private void Button_Leave(object sender, EventArgs e)
        {
            ((IconButton)sender).IconColor = Color.Gainsboro;
            ((IconButton)sender).ForeColor = Color.Gainsboro;
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            if (txbUserName.Text == "" || rtbComment.Text == "")
                MessageBox.Show("You need to enter full information!");
            else
            {
                string filePath = "comments/" + song["name"] + ".txt";
                List<string> comments = new List<string>();
                comments = File.ReadAllLines(filePath).ToList();
                comments.Add(txbUserName.Text + "," + nmrUserStar.Value.ToString() + "," + rtbComment.Text);
                File.WriteAllLines(filePath, comments.ToArray());
                rtbComment.Text = "";
                RenderReview();
            }
        }
    }
}
