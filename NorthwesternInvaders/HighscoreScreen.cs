using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace NorthwesternInvaders
{
    public partial class HighscoreScreen : UserControl
    {
        public HighscoreScreen()
        {
            InitializeComponent();

            foreach (Score score in Form1.scores)
            {
                highscore1.Text += score.name + " " + score.score.ToString("0000000") + "\n";
            }           

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
