using System;
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
    public partial class HelpScreen : Form
    {
        public HelpScreen()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void LoadMenu(object sender, EventArgs e)
        {
            Menu gameWindow = new Menu();

            gameWindow.Show();
        }
    }
}
