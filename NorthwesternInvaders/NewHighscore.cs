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
using System.Media;

namespace NorthwesternInvaders
{
    public partial class NewHighscore : UserControl
    {
        public string name;
        Char letter = 'A';
        int select;
        int score;
        
        SoundPlayer newHighscore = new SoundPlayer(Properties.Resources.NewHighscore);
        public NewHighscore()
        {
            InitializeComponent();

            highscoreLabel.Text = "" + GameScreen.highscore.ToString("0000000");
            score = GameScreen.highscore;
            newHighscore.Play();
            select = 1;
        }

        private void NewHighscore_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (select < 4)
            {
                switch (e.KeyCode)
                {
                    case Keys.Down:
                        if (letter != 'Z')
                        {
                            letter++;
                        }
                        break;

                    case Keys.Up:
                        if (letter != 'A')
                        {
                            letter--;
                        }
                        break;

                    case Keys.Space:
                        select++;
                        letter = 'A';
                        break;
                }

                switch (select)
                {
                    case 1:
                        initial1.BackColor = Color.White;
                        initial1.ForeColor = Color.Black;
                        initial1.Text = "" + letter;
                        break;
                    case 2:
                        initial2.BackColor = Color.White;
                        initial2.ForeColor = Color.Black;
                        initial2.Text = "" + letter;
                        break;
                    case 3:
                        initial3.BackColor = Color.White;
                        initial3.ForeColor = Color.Black;
                        initial3.Text = "" + letter;
                        break;
                    default:
                        break;
                }
            }
            if (select >= 4)
            {
                name = initial1.Text + initial2.Text + initial3.Text;
                Score s = new Score(score, name);
                Form1.scores.Add(s);
                Form1.scores = Form1.scores.OrderByDescending(x => x.score ).ThenBy(x => x.name).ToList();

                if (Form1.scores.Count > 6)
                {
                    
                        Form1.scores.RemoveAt(6);
                    
                }
                scoreSave();
            }
        }

        void scoreSave()
        {
            XmlWriter writer = XmlWriter.Create("HighscoresXML.xml");
            writer.WriteStartElement("scores");
            foreach (Score s in Form1.scores)
            {
                writer.WriteStartElement("highscore");
                writer.WriteElementString("name", s.name);
                writer.WriteElementString("score", Convert.ToString(s.score));
                writer.WriteEndElement();

            }
            writer.WriteEndElement();

            writer.Close();

        }

        private void saveLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            MenuScreen ms = new MenuScreen();
            f.Controls.Remove(this);
            f.Controls.Add(ms);
            ms.Location = new Point((Width) / 2, (Height) / 2);
        }
    }
    
}
