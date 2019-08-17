using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace HighStakes
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public double FiniScore = 0; //končni rezultat kok dobiš 
        private int preverjanje = 0; //ka naj nardi na scoreboard
        private static int GunPos = 0; //gun efekt
        private int x = Screen.PrimaryScreen.Bounds.Height;  //visina
        private int y = Screen.PrimaryScreen.Bounds.Width;   //sirina
        private Random random = new Random(); //random generator
        private int xPOS = 0; //naključen položaj pajdota
        private int yPOS = 0; //naključen položaj pajdota      
        private static int hider = 0;    //za homescreen objects skrivat
        private int timer = 0;   //pač cajt ti kaže
        private int score = 0;   //šteje dokler ne prideš do 40
        private int cajt = 7;    //odštevanje do game start
        private int bullets = 60; //metki kolk jih še maš

        //ko je konc game al pa če klikneš home
        private void LeaveGame()
        {
            this.ScoreBoard.BackgroundImage = global::HighStakes.Properties.Resources.scoreboard1;
            this.Alien.Visible = false;
            hider = 0;
            this.HomeScreen();
            this.timer1.Stop();
            this.timer3.Stop();
            this.GameBorder.Visible = false;
            this.BackgroundImage = global::HighStakes.Properties.Resources.bckg3;
            this.ActualGame.Location = new System.Drawing.Point(0, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ActualGame.Size = new System.Drawing.Size(1280, 720);
            this.TimeLeftt.Visible = false;
            this.BulletsLeft.Visible = false;
            this.WindowState = FormWindowState.Normal;
            int panelScore = 100 - timer;
            if (preverjanje == 0)
            {
                FiniScore = (100 - timer) + (bullets * 1.2) + 39;
                FiniScore = Math.Ceiling(FiniScore);
                this.FinalScoreX.Text = "" + FiniScore;
                ScoreBoard.Visible = true;
                this.FinalScoreX.Visible = true;
            }
            else if (preverjanje == 1)
            {
                this.FinalScoreX.Visible = true;
                FiniScore = score;
                this.FinalScoreX.Text = "" + FiniScore;
                ScoreBoard.Visible = true;
            }
            else if (preverjanje == 2)
            {
                this.ScoreBoard.Visible = false;
            }
            this.GunModel.Visible = false;
        }
        //za začet gejm
        private void StartGame()
        {
            this.ScoreBoard.BackgroundImage = global::HighStakes.Properties.Resources.scoreboard1;
            this.preverjanje = 0;
            this.bullets = 60;
            this.cajt = 7;
            this.score = 0;
            this.timer = 0;
            this.BackgroundImage = global::HighStakes.Properties.Resources.KITBASH3D_WARZ_IMG_03_1024x1024; ;
            hider = 1;
            this.HomeScreen();
            this.ActualGame.Show();
            this.timer2.Start();
            this.ActualGame.Location = new System.Drawing.Point(0, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(y, x);
            this.ActualGame.Size = new System.Drawing.Size(y, x);
            this.WindowState = FormWindowState.Maximized;
            this.TimeLeftt.Visible = true;
            this.BulletsLeft.Visible = false;
            this.GameBorder.Visible = true;
            this.GameBorder.Location = new System.Drawing.Point(120, 120);
            this.GameBorder.Size = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width - 240, Screen.PrimaryScreen.Bounds.Height - 240);
            this.TimeLeftt.Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width - 300, 10);
            this.BulletsLeft.Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width - 1200, Screen.PrimaryScreen.Bounds.Height - 120);
            this.TimeLeftt.Text = " Time: " + timer + "\n" + "Score: " + score;
            this.BulletsLeft.Text = "Bullets left " + bullets + " /60";
            this.FinalScoreX.Visible = false;
            this.ScoreBoard.Visible = false;
        }
        //začetni zaslon nč takiga
        private void HomeScreen()
        {
            this.ScoreBoard.BackgroundImage = global::HighStakes.Properties.Resources.scoreboard1;
            if (hider == 0)
            {
                this.start.Show();
                this.options.Show();
                this.quit.Show();
                this.TimeLeftt.Visible = false;
                this.BulletsLeft.Visible = false;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.ClientSize = new System.Drawing.Size(1280, 720);
                this.ActualGame.Size = new System.Drawing.Size(1280, 720);
                this.WindowState = FormWindowState.Normal;
                this.ActualGame.Visible = false;
            }
            else if (hider == 1)
            {
                this.start.Hide();
                this.options.Hide();
                this.quit.Hide();
            }
        }
        //kar se naloži na startup
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ScoreBoard.BackgroundImage = global::HighStakes.Properties.Resources.scoreboard1;
            this.preverjanje = 0;
            this.LeavorHome.Visible = false;
            this.FinalScoreX.Visible = true;
            this.ScoreBoard.Size = new System.Drawing.Size(400, 160);
            this.ScoreBoard.Location = new System.Drawing.Point(300, 280);
            this.ScoreBoard.Visible = true;
            this.timer3.Stop();
            this.BackgroundImage = global::HighStakes.Properties.Resources.bckg3;
            this.Alien.Visible = false;
            if (preverjanje == 0)
            {
                FiniScore = (100 - timer) + (bullets * 1.2) + 39;
                FiniScore = Math.Ceiling(FiniScore);
                this.FinalScoreX.Text = "" + FiniScore;
                ScoreBoard.Visible = true;
                this.FinalScoreX.Visible = true;
            }
            else if (preverjanje == 1)
            {
                this.FinalScoreX.Visible = true;
                FiniScore = score;
                this.FinalScoreX.Text = "" + FiniScore;
                ScoreBoard.Visible = true;
            }
            else if (preverjanje == 2)
            {
                this.ScoreBoard.Visible = false;
            }
            this.FinalScoreX.Visible = false;
            this.ScoreBoard.Visible = false;
            this.start.Show();
            this.options.Show();
            this.quit.Show();
            this.ActualGame.Hide();
            this.BlurryBoi.Visible = false;
            this.Resume.Visible = false;
            this.Restart.Visible = false;
            this.Alien.Size = new System.Drawing.Size(200, 300);
            this.ActualGame.Location = new System.Drawing.Point(0, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ActualGame.Size = new System.Drawing.Size(1280, 720);
            this.WindowState = FormWindowState.Normal;
            this.TimeLeftt.Visible = false;
            this.BulletsLeft.Visible = false;
            this.Odstevanje.Visible = false;
            this.GameBorder.Visible = false;
            this.GunModel.Visible = false;
            this.GunModel.Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width - 900, Screen.PrimaryScreen.Bounds.Height - 240);
            this.GunModel.Size = new System.Drawing.Size(900, 240);
            this.Odstevanje.Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width / 2)-200, (Screen.PrimaryScreen.Bounds.Height / 2)-20);
        }
        //za ugasnat button
        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //za začet gejm button
        private void start_Click(object sender, EventArgs e)
        {
            this.ScoreBoard.BackgroundImage = global::HighStakes.Properties.Resources.scoreboard1;
            this.StartGame();
        }
        //button za prepoznavanje ESC
        private void CreateButton()
        {
            this.button1 = new Button();
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.ForeColor = BackColor;
            this.button1.Location = new Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.button1.TabIndex = 0;
            this.button1.Text = "";
            this.button1.UseVisualStyleBackColor = true;
            this.Controls.Add(button1);
        }
        //če pritisnemo na temu buttonu ESC
        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ScoreBoard.BackgroundImage = global::HighStakes.Properties.Resources.scoreboard1;
            if (ActualGame.Visible == true && GameBorder.Visible == true)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Escape))
                {
                    if (cajt > 0)
                        timer2.Stop();
                    else
                        timer1.Stop();
                        timer3.Stop();
                    //blur
                    this.BlurryBoi.Location = new System.Drawing.Point(0, 0);
                    this.BlurryBoi.Size = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                    this.BlurryBoi.Visible = true;
                    //leave game button
                    this.LeavorHome.Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width / 2) - 300, (Screen.PrimaryScreen.Bounds.Height / 2) + 30);
                    this.LeavorHome.Size = new System.Drawing.Size(180, 50);
                    this.LeavorHome.Visible = true;
                    //resume button
                    this.Resume.Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width / 2) - 100, (Screen.PrimaryScreen.Bounds.Height / 2)+30);
                    this.Resume.Size = new System.Drawing.Size(180, 50);
                    this.Resume.Visible = true;
                    //restart button
                    this.Restart.Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width / 2) + 100, (Screen.PrimaryScreen.Bounds.Height / 2)+30);
                    this.Restart.Size = new System.Drawing.Size(180, 50);
                    this.Restart.Visible = true;
                    this.Alien.Visible = false;
                    //gun
                    this.GunModel.Visible = false;
                    this.BulletsLeft.Visible = false;
                }
            }
        }
        //vrnitev v igro (resume)
        private void Resume_Click(object sender, EventArgs e)
        {
            if (cajt > 0)
            {
                this.timer2.Start();
            }
            else
            {
                this.timer1.Start();
                this.timer3.Start();
            }
            this.LeavorHome.Visible = false;
            this.Resume.Visible = false;
            this.Restart.Visible = false;
            this.BlurryBoi.Visible = false;
        }
        //ponovni začetek igre
        private void Restart_Click(object sender, EventArgs e)
        {
            this.LeavorHome.Visible = false;
            this.Resume.Visible = false;
            this.Restart.Visible = false;
            this.BlurryBoi.Visible = false;
            this.StartGame();
        }
        //domač zaslon (prekinitev igre)
        private void LeavorHome_Click(object sender, EventArgs e)
        {
            preverjanje = 2;
            this.LeavorHome.Visible = false;
            this.Resume.Visible = false;
            this.Restart.Visible = false;
            this.BlurryBoi.Visible = false;
            hider = 0;
            this.FinalScoreX.Visible = false;
            if (preverjanje == 0)
            {
                FiniScore = (100 - timer) + (bullets * 1.2) + 39;
                FiniScore = Math.Ceiling(FiniScore);
                this.FinalScoreX.Text = "" + FiniScore;
                ScoreBoard.Visible = true;
                this.FinalScoreX.Visible = true;
            }
            else if (preverjanje == 1)
            {
                this.FinalScoreX.Visible = true;
                FiniScore = score;
                this.FinalScoreX.Text = "" + FiniScore;
                ScoreBoard.Visible = true;
            }
            else if (preverjanje == 2)
            {
                this.ScoreBoard.Visible = false;
            }
            this.HomeScreen();
            this.LeaveGame();
            MessageBox.Show("Didn't finish the GAME!");
        }
        //odštevanje od 3
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            this.ScoreBoard.BackgroundImage = global::HighStakes.Properties.Resources.scoreboard1;
            if (Odstevanje.Visible == false)
                this.Odstevanje.Visible = true;
            int x = cajt - 2;
            cajt--;
            this.timer2.Interval = 1000;
            if (cajt > 4)
            {
                Odstevanje.Text = "Get Ready!";
                this.Odstevanje.Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width / 2) - 350, (Screen.PrimaryScreen.Bounds.Height / 2) - 150);
            }
            else if (cajt > 1 && cajt < 5)
            {
                Odstevanje.Text = "" + x;
                this.Odstevanje.Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width / 2) - 150, (Screen.PrimaryScreen.Bounds.Height / 2) - 150);
            }
            else if (cajt > 0 && cajt < 2)
            {
                Odstevanje.Text = "GO!";
                this.Odstevanje.Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width / 2) - 170, (Screen.PrimaryScreen.Bounds.Height / 2) - 150);
            }
            else if (cajt <= 0)
            {
                this.Odstevanje.Text = "";
                this.timer2.Stop();
                this.timer1.Start();
                this.timer3.Start();
                this.Odstevanje.Visible = false;
            }
        }
        //zadetek pajdota
        private void Alien_MouseClick(object sender, MouseEventArgs e)
        {
            bullets--;
            GunPos = 1;
            if (GunPos == 1)
            {
                timer4.Start();
            }
            SoundPlayer osem = new SoundPlayer("Explosion2.wav");
            //bodyshot
            if ( MousePosition.X > xPOS + 40 && MousePosition.X < xPOS + 150 && MousePosition.Y > yPOS + 80 && MousePosition.Y < yPOS+260)
            {
                score++;
                osem.Play();
            }
            //headshot
            else if (MousePosition.Y < yPOS + 80 && MousePosition.Y > yPOS + 10 && MousePosition.X > xPOS + 70 && MousePosition.X < xPOS + 100)
            {
                score++;
                osem.Play();
            }
            //roke al pač frame zadaneš
            else
            {
                SoundPlayer Miiss = new SoundPlayer("lasr.wav");
                Miiss.Play();
            }
            this.TimeLeftt.Text = " Time: " + timer + "\n" + "Score: " + score;
            this.BulletsLeft.Text = "Bullets left " + bullets + " /60";
        }
        //če falimo pajdota
        private void GameBorder_MouseClick(object sender, MouseEventArgs e)
        {
            if(cajt <= 0)
            {
                GunPos = 1;
                if(GunPos==1)
                {
                    timer4.Start();
                }
                bullets--;
                this.TimeLeftt.Text = " Time: " + timer + "\n" + "Score: " + score;
                this.BulletsLeft.Text = "Bullets left " + bullets + " /60";
                SoundPlayer Miiss = new SoundPlayer("lasr.wav");
                Miiss.Play();
            }
        }
        //gun effect
        private void timer4_Tick(object sender, EventArgs e)
        {
            GunPos++;
            this.TimeLeftt.Text = " Time: " + timer + "\n" + "Score: " + score;
            this.BulletsLeft.Text = "Bullets left " + bullets + " /60";
            this.timer3.Interval = 1000;
            this.GunModel.Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width - 900, Screen.PrimaryScreen.Bounds.Height - 300);
            if (GunPos>=4)
            {
                timer4.Stop();
                this.GunModel.Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width - 900, Screen.PrimaryScreen.Bounds.Height - 240);
            }
        }
        //info button
        private void options_MouseUp(object sender, MouseEventArgs e)
        {
            ScoreBoard.Visible = true;
            //left click
            if (e.Button == MouseButtons.Left)
            {
                FinalScoreX.Visible = false;
                this.ScoreBoard.BackgroundImage = global::HighStakes.Properties.Resources.bcvgggggg;
            }
            //right click
            else if(e.Button == MouseButtons.Right)
            {
                FinalScoreX.Visible = true;
                this.ScoreBoard.BackgroundImage = global::HighStakes.Properties.Resources.scoreboard1;
            }
            else
            {
                FinalScoreX.Visible = false;
                ScoreBoard.Visible = false;
            }
        }
        //timer al pa štoparca
        private void timer3_Tick(object sender, EventArgs e)
        {
            this.timer3.Interval = 1000;
            timer++;
            this.TimeLeftt.Text = " Time: " + timer + "\n" + "Score: " + score;
            this.BulletsLeft.Text = "Bullets left " + bullets + " /60";

        }
        //prestavljanje pajdota
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BulletsLeft.Visible = true;
            this.GunModel.Visible = true;
            this.Restart.Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width / 2) + 0, (Screen.PrimaryScreen.Bounds.Height / 2) + 30);
            this.Restart.Size = new System.Drawing.Size(200, 50);
            this.Alien.Visible = false;
            this.Alien.BackgroundImage = global::HighStakes.Properties.Resources.portrait;
            this.xPOS = random.Next(125, Screen.PrimaryScreen.Bounds.Width - 423);
            this.yPOS = random.Next(125, Screen.PrimaryScreen.Bounds.Height - 423);
            this.Alien.Location = new System.Drawing.Point(xPOS, yPOS);
            this.Alien.Visible = true;
            this.TimeLeftt.Visible = true;
            if (score < 11)
                this.timer1.Interval = 1000;
            else if (score > 10 && score < 21)
                this.timer1.Interval = 900;
            else if (score > 20 && score < 31)
                this.timer1.Interval = 800;
            else if (score > 30 && score < 36)
                this.timer1.Interval = 700;
            else if (score > 35 && score < 41)
                this.timer1.Interval = 620;
            this.BulletsLeft.Text = "Bullets left " + bullets + " /60";
            this.TimeLeftt.Text = " Time: " + timer + "\n" + "Score: " + score;
            if (timer >= 100 || score>=40 || bullets<=0)
            {
                this.ScoreBoard.BackgroundImage = global::HighStakes.Properties.Resources.scoreboard1;
                if (score < 40)
                    preverjanje = 1;
                else
                {
                    if (preverjanje == 0)
                    {
                        FiniScore = (100 - timer) + (bullets * 1.2)+39;
                        FiniScore = Math.Ceiling(FiniScore);
                        this.FinalScoreX.Text = "" + FiniScore;
                        ScoreBoard.Visible = true;
                        this.FinalScoreX.Visible = true;
                    }
                    else if (preverjanje == 1)
                    {
                        this.FinalScoreX.Visible = true;
                        FiniScore = score;
                        this.FinalScoreX.Text = "" + FiniScore;
                        ScoreBoard.Visible = true;
                    }
                    else if (preverjanje == 2)
                    {
                        this.ScoreBoard.Visible = false;
                    }
                }
                this.LeaveGame();
            }
        }
    }
}