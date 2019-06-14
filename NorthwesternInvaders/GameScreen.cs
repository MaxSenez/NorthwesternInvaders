using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Xml;
using System.Media;

namespace NorthwesternInvaders
{
    public partial class GameScreen : UserControl
    {
        public int lives = 3, speed = 7, invSpeed = 1, xStart = 0, yStart = 0;
        public static int highscore = 0;
        public bool shoot = false, movingLeft, movingRight, invMoving = true,
            sheild, characterDraw = true;
        public Defender d;
        public Bullet bullet;
        public Rectangle beam = new Rectangle();
        public Pen box = new Pen(Color.Red, 3);
        public SolidBrush beamBrush = new SolidBrush(Color.Blue);
        public SolidBrush bulletBrush = new SolidBrush(Color.Red);
        List<Invader> invaders = new List<Invader>();
        List<Bullet> bullets = new List<Bullet>();
        Random invRand = new Random();

        //Sounds
        SoundPlayer alienDeath = new SoundPlayer(Properties.Resources.AlienDeath);
        SoundPlayer beamShot = new SoundPlayer(Properties.Resources.BeamShot);
        SoundPlayer bulletShot = new SoundPlayer(Properties.Resources.bulletShot);
        SoundPlayer deathSound = new SoundPlayer(Properties.Resources.DeathSound);
       

        string invaderDirection = "right";
        int downCounter = 0, bulletCounter = 50, randValue, bulletSpeed = 10,
            sheildTick = 0;


        public GameScreen()
        {
            InitializeComponent();

            d = new Defender(Width / 2, Height - 40, 40, 40);
            beam = new Rectangle(d.hb.X + 15, d.hb.Y + 10, 5, 10);

        }

        public void InvaderSpawn()
        {
            for (int i = 0; i < 10; i++)
            {
                Invader inv = new Invader(xStart + (40 * i), 90 + yStart, 30, 30, false, "right", invSpeed);
                invaders.Add(inv);
            }

            for (int i = 0; i < 10; i++)
            {
                Invader inv = new Invader(xStart + (40 * i), 130 + yStart, 30, 30, false, "right", invSpeed);
                invaders.Add(inv);
            }

            for (int i = 0; i < 10; i++)
            {
                Invader inv = new Invader(xStart + (40 * i), 170 + yStart, 30, 30, false, "right", invSpeed);
                invaders.Add(inv);
            }

            for (int i = 0; i < 10; i++)
            {
                Invader inv = new Invader(xStart + (40 * i), 210 + yStart, 30, 30, false, "right", invSpeed);
                invaders.Add(inv);
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (invaders.Count == 0)
            {
                yStart = yStart + 50;
                InvaderSpawn();
            }

            foreach (Invader invader in invaders)
            {
                Rectangle invRec = new Rectangle(invader.x, invader.y, invader.width, invader.height);
                if (d.hb.IntersectsWith(invRec))
                {
                    lives = 0;
                }
            }


            sheildTick++;
            if (sheild == true)
            {
                if (sheildTick % 12 == 0)
                {
                    characterDraw = !characterDraw;
                }
                if (sheildTick == 52)
                {
                    sheild = false;
                }
            }
                                          
            bulletCounter--;
            if (bulletCounter == 0)
            {
                randValue = invRand.Next(0, invaders.Count);
                bullet = new Bullet(invaders[randValue].x + invaders[randValue].width / 2,
                    invaders[randValue].y + invaders[randValue].height, 5, 5, bulletSpeed);
                bullets.Add(bullet);
                bulletCounter = 35;
                bulletShot.Play();

            }
            foreach (Bullet b in bullets)
            {
                b.y = b.y + b.speed;
                b.hb.Y = b.y;
                b.hb.X = b.x;
            }


            #region Invader Movements
            downCounter++;
            if (invMoving == true)
            {
                foreach (Invader invader in invaders)
                {
                    invader.move(invSpeed, invaderDirection);
                }

                foreach (Invader invader in invaders)
                {
                    if (invader.x > 850 && invaderDirection == "right")
                    {
                        invaderDirection = "down";
                        downCounter = 0;
                        break;
                    }
                    else if (invader.x < 0 && invaderDirection == "left")
                    {
                        invaderDirection = "down";
                        downCounter = 0;
                        break;
                    }
                    else if (invaderDirection == "down" && downCounter == 5 && invader.x > 850)
                    {
                        invaderDirection = "left";
                    }
                    else if (invaderDirection == "down" && downCounter == 5 && invader.x < 0)
                    {
                        invaderDirection = "right";
                    }
                }
            }
            #endregion

            foreach (Invader invader in invaders)
            {
                Rectangle invRec = new Rectangle(invader.x, invader.y, invader.width, invader.height);
                if (beam.IntersectsWith(invRec))
                {
                    highscore = highscore + 100;
                    highscoreOutput.Text = "HIGHSCORE: " + highscore.ToString("0000000");
                    invaders.Remove(invader);
                    shoot = false;
                    beam.Y = d.hb.Y;
                    alienDeath.Play();
                    break;
                }

            }

            if (movingLeft == true)
            {
                d.move(speed, "left");
            }
            else if (movingRight == true)
            {
                d.move(speed, "right");
            }


            #region Player Collisions
            if (d.hb.X > Width - d.hb.Width)
            {
                d.hb.X = Width - d.hb.Width - 5;
                movingRight = false;
            }
            else if (d.hb.X < 0 + d.hb.Width)
            {
                d.hb.X = 0 + d.hb.Width + 5;
                movingLeft = false;

            }

            if (beam.Y < 0 - beam.Height)
            {
                shoot = false;
                beam.Y = d.hb.Y;
            }

            foreach (Bullet b in bullets)
            {
                if (b.hb.IntersectsWith(d.hb))
                {
                    bullets.Remove(b);
                    if (sheild == false)
                    {
                        lives--;
                        deathSound.Play();
                        sheild = true;
                        sheildTick = 0;
                        if (lives == 3)
                        {
                            life3Label.Visible = false;
                        }
                        else if (lives == 2)
                        {
                            life1Label.Visible = false;
                        }
                        else if (lives == 1)
                        {
                            life2Label.Visible = false;
                        }
                    }
                    break;
                }               

                if (b.y > Height)
                {
                    bullets.Remove(b);
                    break;
                }

            }

            #endregion

            if (lives == 0)
            {

                    if (highscore > Form1.scores[Form1.scores.Count-1].score)
                    {
                        gameTimer.Stop();
                        Form f = this.FindForm();
                        NewHighscore nhs = new NewHighscore();
                        f.Controls.Remove(this);
                        f.Controls.Add(nhs);
                        nhs.Location = new Point((Width) / 2, (Height) / 2);
                        nhs.Focus();
                    }
                    else
                    {
                        gameTimer.Stop();
                        Form f = this.FindForm();
                        GameOver go = new GameOver();
                        f.Controls.Remove(this);
                        f.Controls.Add(go);
                        go.Location = new Point((Width) / 2, (Height) / 2);
                        go.Focus();
                    }
            }

            if (shoot == true)
            {
                beam.Y = beam.Y - 20;
            }

            Refresh();
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    movingLeft = false;
                    break;
                case Keys.Right:
                    movingRight = false;
                    break;
            }
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    movingLeft = true;
                    movingRight = false;
                    break;
                case Keys.Right:
                    movingRight = true;
                    movingLeft = false;
                    break;
                case Keys.Space:

                    if (shoot == false)
                    {
                        shoot = true;
                        beam.X = d.hb.X;
                        beamShot.Play();
                    }
                    break;
            }

        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            if (characterDraw == true)
            {
                e.Graphics.DrawImage(Properties.Resources.Defender, d.hb);
            }

            foreach (Invader i in invaders)
            {
                e.Graphics.DrawImage(Properties.Resources.HuskieInvader, i.x, i.y, i.width, i.height);

            }
            foreach (Bullet b in bullets)  
            {
                e.Graphics.FillRectangle(bulletBrush, b.x, b.y, b.width, b.height);
            }

            if (shoot == true)
            {
                e.Graphics.FillRectangle(beamBrush, beam);
            }

        }

    }
}
