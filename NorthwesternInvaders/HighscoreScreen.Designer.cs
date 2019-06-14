namespace NorthwesternInvaders
{
    partial class HighscoreScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighscoreScreen));
            this.highscore1 = new System.Windows.Forms.Label();
            this.returnMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // highscore1
            // 
            this.highscore1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscore1.ForeColor = System.Drawing.SystemColors.Control;
            this.highscore1.Location = new System.Drawing.Point(295, 197);
            this.highscore1.Name = "highscore1";
            this.highscore1.Size = new System.Drawing.Size(317, 344);
            this.highscore1.TabIndex = 0;
            this.highscore1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // returnMenuButton
            // 
            this.returnMenuButton.BackgroundImage = global::NorthwesternInvaders.Properties.Resources.returnImage;
            this.returnMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnMenuButton.Location = new System.Drawing.Point(697, 532);
            this.returnMenuButton.Name = "returnMenuButton";
            this.returnMenuButton.Size = new System.Drawing.Size(153, 52);
            this.returnMenuButton.TabIndex = 1;
            this.returnMenuButton.UseVisualStyleBackColor = true;
            this.returnMenuButton.Click += new System.EventHandler(this.returnMenuButton_Click);
            // 
            // HighscoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.returnMenuButton);
            this.Controls.Add(this.highscore1);
            this.Name = "HighscoreScreen";
            this.Size = new System.Drawing.Size(900, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label highscore1;
        private System.Windows.Forms.Button returnMenuButton;
    }
}
