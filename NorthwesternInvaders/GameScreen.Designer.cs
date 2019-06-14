namespace NorthwesternInvaders
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.highscoreOutput = new System.Windows.Forms.Label();
            this.life1Label = new System.Windows.Forms.Label();
            this.life2Label = new System.Windows.Forms.Label();
            this.life3Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 16;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // highscoreOutput
            // 
            this.highscoreOutput.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreOutput.ForeColor = System.Drawing.SystemColors.Control;
            this.highscoreOutput.Location = new System.Drawing.Point(274, 20);
            this.highscoreOutput.Name = "highscoreOutput";
            this.highscoreOutput.Size = new System.Drawing.Size(370, 50);
            this.highscoreOutput.TabIndex = 3;
            this.highscoreOutput.Text = "HIGHSCORE: 0000000";
            // 
            // life1Label
            // 
            this.life1Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.life1Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.life1Label.Image = ((System.Drawing.Image)(resources.GetObject("life1Label.Image")));
            this.life1Label.Location = new System.Drawing.Point(829, 34);
            this.life1Label.Name = "life1Label";
            this.life1Label.Size = new System.Drawing.Size(25, 25);
            this.life1Label.TabIndex = 2;
            // 
            // life2Label
            // 
            this.life2Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.life2Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.life2Label.Image = ((System.Drawing.Image)(resources.GetObject("life2Label.Image")));
            this.life2Label.Location = new System.Drawing.Point(775, 34);
            this.life2Label.Name = "life2Label";
            this.life2Label.Size = new System.Drawing.Size(25, 25);
            this.life2Label.TabIndex = 1;
            // 
            // life3Label
            // 
            this.life3Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.life3Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.life3Label.Image = global::NorthwesternInvaders.Properties.Resources.Defender;
            this.life3Label.Location = new System.Drawing.Point(718, 34);
            this.life3Label.Name = "life3Label";
            this.life3Label.Size = new System.Drawing.Size(25, 25);
            this.life3Label.TabIndex = 0;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.highscoreOutput);
            this.Controls.Add(this.life1Label);
            this.Controls.Add(this.life2Label);
            this.Controls.Add(this.life3Label);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(900, 600);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label life3Label;
        private System.Windows.Forms.Label life2Label;
        private System.Windows.Forms.Label life1Label;
        private System.Windows.Forms.Label highscoreOutput;
    }
}
