using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace NorthwesternInvaders
{
    public partial class Form1 : Form
    {
        public static Form1 f;
        public static List<Score> scores = new List<Score>();

        public Form1()
        {
            InitializeComponent();

            loadScore();
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);
            ms.Location = new Point((Width) / 2, (Height) / 2);
            f = this;
            
        }
        public static void close()
        {
            f.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;            
        }

        void loadScore()
        {

            XmlReader reader = XmlReader.Create("HighscoresXML.xml");
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    string name;
                    int score;

                    name = reader.ReadString();
                    reader.ReadToNextSibling("score");
                    score = Convert.ToInt16(reader.ReadString());

                    Score s = new Score(score, name);

                    if (s.name != null)
                    {
                        scores.Add(s);
                    }
                }
            }
            reader.Close();
        }
    }
}
