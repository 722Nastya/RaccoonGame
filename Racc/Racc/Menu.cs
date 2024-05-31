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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void LoadGame(object sender, EventArgs e)
        {
            GameScreen_lev1 gameWindow = new GameScreen_lev1();
            gameWindow.Show();
        }

        private void LoadHelp(object sender, EventArgs e)
        {
            HelpScreen hepWindow = new HelpScreen();
            hepWindow.Show();
        }
    }
}