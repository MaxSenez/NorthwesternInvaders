namespace NorthwesternInvaders
{
    partial class GameOver
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
            this.returnMenuButton = new System.Windows.Forms.Button();
            this.highscoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnMenuButton
            // 
            this.returnMenuButton.BackgroundImage = global::NorthwesternInvaders.Properties.Resources.returnImage;
            this.returnMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnMenuButton.Location = new System.Drawing.Point(389, 448);
            this.returnMenuButton.Name = "returnMenuButton";
            this.returnMenuButton.Size = new System.Drawing.Size(153, 52);
            this.returnMenuButton.TabIndex = 0;
            this.returnMenuButton.UseVisualStyleBackColor = true;
            this.returnMenuButton.Click += new System.EventHandler(this.returnMenuButton_Click);
            // 
            // highscoreLabel
            // 
            this.highscoreLabel.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.highscoreLabel.Location = new System.Drawing.Point(261, 310);
            this.highscoreLabel.Name = "highscoreLabel";
            this.highscoreLabel.Size = new System.Drawing.Size(425, 98);
            this.highscoreLabel.TabIndex = 1;
            this.highscoreLabel.Text = "0000000";
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::NorthwesternInvaders.Properties.Resources.GameOverScreen;
            this.Controls.Add(this.highscoreLabel);
            this.Controls.Add(this.returnMenuButton);
            this.Name = "GameOver";
            this.Size = new System.Drawing.Size(900, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returnMenuButton;
        private System.Windows.Forms.Label highscoreLabel;
    }
}
