﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racc
{
    public partial class lose : Form
    {
        public lose()
        {
            InitializeComponent();
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            GameScreen_lev1 gameWindow = new GameScreen_lev1();

            gameWindow.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
