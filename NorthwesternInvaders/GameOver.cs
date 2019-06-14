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
    public partial class GameOver : UserControl
    {
       
        public GameOver()
        {
            InitializeComponent();
       
            highscoreLabel.Text = "" + GameScreen.highscore.ToString("0000000");
        }



        private void returnMenuButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            MenuScreen ms = new MenuScreen();
            f.Controls.Remove(this);
            f.Controls.Add(ms);
            ms.Location = new Point((Width) / 2, (Height) / 2);
        }
    }
}
