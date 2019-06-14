namespace NorthwesternInvaders
{
    partial class NewHighscore
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
            this.label1 = new System.Windows.Forms.Label();
            this.initial1 = new System.Windows.Forms.Label();
            this.initial2 = new System.Windows.Forms.Label();
            this.initial3 = new System.Windows.Forms.Label();
            this.highscoreLabel = new System.Windows.Forms.Label();
            this.saveLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(62, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(773, 140);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW HIGHSCORE!!!";
            // 
            // initial1
            // 
            this.initial1.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initial1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.initial1.Location = new System.Drawing.Point(168, 230);
            this.initial1.Name = "initial1";
            this.initial1.Size = new System.Drawing.Size(136, 189);
            this.initial1.TabIndex = 1;
            this.initial1.Text = "A";
            // 
            // initial2
            // 
            this.initial2.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initial2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.initial2.Location = new System.Drawing.Point(376, 230);
            this.initial2.Name = "initial2";
            this.initial2.Size = new System.Drawing.Size(136, 189);
            this.initial2.TabIndex = 2;
            this.initial2.Text = "A";
            // 
            // initial3
            // 
            this.initial3.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initial3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.initial3.Location = new System.Drawing.Point(583, 230);
            this.initial3.Name = "initial3";
            this.initial3.Size = new System.Drawing.Size(136, 189);
            this.initial3.TabIndex = 3;
            this.initial3.Text = "A";
            // 
            // highscoreLabel
            // 
            this.highscoreLabel.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.highscoreLabel.Location = new System.Drawing.Point(113, 126);
            this.highscoreLabel.Name = "highscoreLabel";
            this.highscoreLabel.Size = new System.Drawing.Size(666, 104);
            this.highscoreLabel.TabIndex = 5;
            this.highscoreLabel.Text = "0000000";
            this.highscoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveLabel
            // 
            this.saveLabel.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveLabel.Location = new System.Drawing.Point(320, 450);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(247, 88);
            this.saveLabel.TabIndex = 6;
            this.saveLabel.Text = "SAVE";
            this.saveLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveLabel.Click += new System.EventHandler(this.saveLabel_Click);
            // 
            // NewHighscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.saveLabel);
            this.Controls.Add(this.highscoreLabel);
            this.Controls.Add(this.initial3);
            this.Controls.Add(this.initial2);
            this.Controls.Add(this.initial1);
            this.Controls.Add(this.label1);
            this.Name = "NewHighscore";
            this.Size = new System.Drawing.Size(900, 600);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.NewHighscore_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label initial1;
        private System.Windows.Forms.Label initial2;
        private System.Windows.Forms.Label initial3;
        private System.Windows.Forms.Label highscoreLabel;
        private System.Windows.Forms.Label saveLabel;
    }
}
