namespace NorthwesternInvaders
{
    partial class MenuScreen
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
            this.exitButton = new System.Windows.Forms.Button();
            this.highscoreButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.menuScreenBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.menuScreenBG)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Image = global::NorthwesternInvaders.Properties.Resources.exitImage;
            this.exitButton.Location = new System.Drawing.Point(384, 458);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 66);
            this.exitButton.TabIndex = 4;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // highscoreButton
            // 
            this.highscoreButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.highscoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highscoreButton.Image = global::NorthwesternInvaders.Properties.Resources.highscoresImage;
            this.highscoreButton.Location = new System.Drawing.Point(269, 348);
            this.highscoreButton.Name = "highscoreButton";
            this.highscoreButton.Size = new System.Drawing.Size(364, 68);
            this.highscoreButton.TabIndex = 3;
            this.highscoreButton.UseVisualStyleBackColor = false;
            this.highscoreButton.Click += new System.EventHandler(this.highscoreButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Image = global::NorthwesternInvaders.Properties.Resources.playImage;
            this.playButton.Location = new System.Drawing.Point(380, 242);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(138, 66);
            this.playButton.TabIndex = 2;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // menuScreenBG
            // 
            this.menuScreenBG.Image = global::NorthwesternInvaders.Properties.Resources.MenuScreen;
            this.menuScreenBG.Location = new System.Drawing.Point(0, 0);
            this.menuScreenBG.Name = "menuScreenBG";
            this.menuScreenBG.Size = new System.Drawing.Size(900, 600);
            this.menuScreenBG.TabIndex = 1;
            this.menuScreenBG.TabStop = false;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.highscoreButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.menuScreenBG);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(900, 600);
            ((System.ComponentModel.ISupportInitialize)(this.menuScreenBG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox menuScreenBG;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button highscoreButton;
        private System.Windows.Forms.Button exitButton;
    }
}
