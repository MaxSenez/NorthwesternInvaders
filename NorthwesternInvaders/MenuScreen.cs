using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwesternInvaders
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            GameScreen gs = new GameScreen();
            f.Controls.Remove(this);
            f.Controls.Add(gs);
            gs.Location = new Point((Width) / 2, (Height) / 2);
            gs.Focus();
        }

        private void highscoreButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            HighscoreScreen hs = new HighscoreScreen();
            f.Controls.Remove(this);
            f.Controls.Add(hs);
            hs.Location = new Point((Width) / 2, (Height) / 2);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Form1.close();
        }
    }
}
