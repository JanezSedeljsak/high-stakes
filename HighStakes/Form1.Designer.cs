namespace HighStakes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.options = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.ActualGame = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimeLeftt = new System.Windows.Forms.Label();
            this.Odstevanje = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.GameBorder = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.Button();
            this.Resume = new System.Windows.Forms.Button();
            this.BlurryBoi = new System.Windows.Forms.PictureBox();
            this.Alien = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.FinalScoreX = new System.Windows.Forms.Label();
            this.GunModel = new System.Windows.Forms.PictureBox();
            this.LeavorHome = new System.Windows.Forms.Button();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.BulletsLeft = new System.Windows.Forms.Label();
            this.ScoreBoard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ActualGame)).BeginInit();
            this.GameBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlurryBoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GunModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // options
            // 
            this.options.BackgroundImage = global::HighStakes.Properties.Resources.grunge_hexagon_pattern_by_imtabe_d7kzymb;
            this.options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.options.Cursor = System.Windows.Forms.Cursors.Hand;
            this.options.Location = new System.Drawing.Point(92, 334);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(180, 50);
            this.options.TabIndex = 1;
            this.options.UseVisualStyleBackColor = true;
            this.options.MouseUp += new System.Windows.Forms.MouseEventHandler(this.options_MouseUp);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.BackgroundImage = global::HighStakes.Properties.Resources.grunge_hexagon_pattern_by_imtabe_d7kzymbfff;
            this.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start.Location = new System.Drawing.Point(92, 278);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(180, 50);
            this.start.TabIndex = 0;
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // quit
            // 
            this.quit.BackgroundImage = global::HighStakes.Properties.Resources.grunge_hexagon_pattern_by_imtabe_ffffd7kzymb;
            this.quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quit.Location = new System.Drawing.Point(92, 390);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(180, 50);
            this.quit.TabIndex = 2;
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // ActualGame
            // 
            this.ActualGame.BackgroundImage = global::HighStakes.Properties.Resources.KITBASH3D_WARZ_IMG_03_1024x10241;
            this.ActualGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ActualGame.Cursor = System.Windows.Forms.Cursors.Default;
            this.ActualGame.Location = new System.Drawing.Point(140, 45);
            this.ActualGame.Name = "ActualGame";
            this.ActualGame.Size = new System.Drawing.Size(927, 474);
            this.ActualGame.TabIndex = 3;
            this.ActualGame.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimeLeftt
            // 
            this.TimeLeftt.AutoSize = true;
            this.TimeLeftt.BackColor = System.Drawing.Color.Transparent;
            this.TimeLeftt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TimeLeftt.Font = new System.Drawing.Font("OCR A Extended", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeftt.Location = new System.Drawing.Point(1011, 20);
            this.TimeLeftt.Name = "TimeLeftt";
            this.TimeLeftt.Size = new System.Drawing.Size(130, 47);
            this.TimeLeftt.TabIndex = 4;
            this.TimeLeftt.Text = "////";
            // 
            // Odstevanje
            // 
            this.Odstevanje.AutoSize = true;
            this.Odstevanje.BackColor = System.Drawing.Color.Transparent;
            this.Odstevanje.Font = new System.Drawing.Font("Impact", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Odstevanje.Location = new System.Drawing.Point(251, 65);
            this.Odstevanje.Name = "Odstevanje";
            this.Odstevanje.Size = new System.Drawing.Size(401, 117);
            this.Odstevanje.TabIndex = 5;
            this.Odstevanje.Text = "/////////";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // GameBorder
            // 
            this.GameBorder.BackColor = System.Drawing.Color.Transparent;
            this.GameBorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GameBorder.Controls.Add(this.Odstevanje);
            this.GameBorder.Cursor = System.Windows.Forms.Cursors.Cross;
            this.GameBorder.Location = new System.Drawing.Point(18, 126);
            this.GameBorder.Name = "GameBorder";
            this.GameBorder.Size = new System.Drawing.Size(422, 156);
            this.GameBorder.TabIndex = 6;
            this.GameBorder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameBorder_MouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(2000, 2000);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Restart.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.Location = new System.Drawing.Point(596, 345);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(150, 50);
            this.Restart.TabIndex = 9;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Resume
            // 
            this.Resume.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Resume.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resume.Location = new System.Drawing.Point(560, 345);
            this.Resume.Name = "Resume";
            this.Resume.Size = new System.Drawing.Size(150, 50);
            this.Resume.TabIndex = 10;
            this.Resume.Text = "Resume";
            this.Resume.UseVisualStyleBackColor = false;
            this.Resume.Click += new System.EventHandler(this.Resume_Click);
            // 
            // BlurryBoi
            // 
            this.BlurryBoi.BackColor = System.Drawing.Color.Transparent;
            this.BlurryBoi.BackgroundImage = global::HighStakes.Properties.Resources.blur3;
            this.BlurryBoi.Location = new System.Drawing.Point(291, 173);
            this.BlurryBoi.Name = "BlurryBoi";
            this.BlurryBoi.Size = new System.Drawing.Size(280, 182);
            this.BlurryBoi.TabIndex = 11;
            this.BlurryBoi.TabStop = false;
            // 
            // Alien
            // 
            this.Alien.BackColor = System.Drawing.Color.Transparent;
            this.Alien.BackgroundImage = global::HighStakes.Properties.Resources.portrait;
            this.Alien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Alien.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Alien.Location = new System.Drawing.Point(894, 235);
            this.Alien.Name = "Alien";
            this.Alien.Size = new System.Drawing.Size(122, 103);
            this.Alien.TabIndex = 12;
            this.Alien.TabStop = false;
            this.Alien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Alien_MouseClick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // FinalScoreX
            // 
            this.FinalScoreX.AutoSize = true;
            this.FinalScoreX.BackColor = System.Drawing.Color.Black;
            this.FinalScoreX.Font = new System.Drawing.Font("Bernard MT Condensed", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalScoreX.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FinalScoreX.Location = new System.Drawing.Point(453, 358);
            this.FinalScoreX.Name = "FinalScoreX";
            this.FinalScoreX.Size = new System.Drawing.Size(58, 44);
            this.FinalScoreX.TabIndex = 13;
            this.FinalScoreX.Text = "//";
            // 
            // GunModel
            // 
            this.GunModel.BackColor = System.Drawing.Color.Transparent;
            this.GunModel.BackgroundImage = global::HighStakes.Properties.Resources.GunMOdel;
            this.GunModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GunModel.Location = new System.Drawing.Point(850, 401);
            this.GunModel.Name = "GunModel";
            this.GunModel.Size = new System.Drawing.Size(166, 72);
            this.GunModel.TabIndex = 14;
            this.GunModel.TabStop = false;
            // 
            // LeavorHome
            // 
            this.LeavorHome.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LeavorHome.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeavorHome.Location = new System.Drawing.Point(576, 289);
            this.LeavorHome.Name = "LeavorHome";
            this.LeavorHome.Size = new System.Drawing.Size(150, 50);
            this.LeavorHome.TabIndex = 16;
            this.LeavorHome.Text = "Home";
            this.LeavorHome.UseVisualStyleBackColor = false;
            this.LeavorHome.Click += new System.EventHandler(this.LeavorHome_Click);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // BulletsLeft
            // 
            this.BulletsLeft.AutoSize = true;
            this.BulletsLeft.BackColor = System.Drawing.Color.Transparent;
            this.BulletsLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BulletsLeft.Font = new System.Drawing.Font("OCR A Extended", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BulletsLeft.Location = new System.Drawing.Point(596, 538);
            this.BulletsLeft.Name = "BulletsLeft";
            this.BulletsLeft.Size = new System.Drawing.Size(130, 47);
            this.BulletsLeft.TabIndex = 17;
            this.BulletsLeft.Text = "////";
            // 
            // ScoreBoard
            // 
            this.ScoreBoard.BackgroundImage = global::HighStakes.Properties.Resources.scoreboard1;
            this.ScoreBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScoreBoard.Location = new System.Drawing.Point(389, 401);
            this.ScoreBoard.Name = "ScoreBoard";
            this.ScoreBoard.Size = new System.Drawing.Size(100, 50);
            this.ScoreBoard.TabIndex = 19;
            this.ScoreBoard.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HighStakes.Properties.Resources.bckg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.Alien);
            this.Controls.Add(this.FinalScoreX);
            this.Controls.Add(this.ScoreBoard);
            this.Controls.Add(this.BulletsLeft);
            this.Controls.Add(this.GunModel);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Resume);
            this.Controls.Add(this.LeavorHome);
            this.Controls.Add(this.BlurryBoi);
            this.Controls.Add(this.GameBorder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TimeLeftt);
            this.Controls.Add(this.start);
            this.Controls.Add(this.options);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.ActualGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Form1";
            this.Text = "TheOsemGejm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActualGame)).EndInit();
            this.GameBorder.ResumeLayout(false);
            this.GameBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlurryBoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GunModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button options;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.PictureBox ActualGame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimeLeftt;
        private System.Windows.Forms.Label Odstevanje;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel GameBorder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button Resume;
        private System.Windows.Forms.PictureBox BlurryBoi;
        private System.Windows.Forms.PictureBox Alien;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label FinalScoreX;
        private System.Windows.Forms.PictureBox GunModel;
        private System.Windows.Forms.Button LeavorHome;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label BulletsLeft;
        private System.Windows.Forms.PictureBox ScoreBoard;
    }
}