﻿using System;
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
    public partial class Review : UserControl
    {
        private DataRow song;
        public Review(DataRow s)
        {
            InitializeComponent();
            song = s;


        }
    }
}