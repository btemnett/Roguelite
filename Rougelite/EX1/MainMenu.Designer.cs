namespace EX1
{
    partial class MainMenu
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
            this.lblGameName = new System.Windows.Forms.Label();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.lblIntro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.BackColor = System.Drawing.Color.Transparent;
            this.lblGameName.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.ForeColor = System.Drawing.Color.Red;
            this.lblGameName.Location = new System.Drawing.Point(103, 52);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(358, 33);
            this.lblGameName.TabIndex = 0;
            this.lblGameName.Text = "The Tale of the Doomed Unicorn";
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.Location = new System.Drawing.Point(696, 399);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(75, 23);
            this.btnPlayGame.TabIndex = 1;
            this.btnPlayGame.Text = "Play";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.Location = new System.Drawing.Point(696, 444);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(75, 23);
            this.btnLoadGame.TabIndex = 2;
            this.btnLoadGame.Text = "Load Game";
            this.btnLoadGame.UseVisualStyleBackColor = true;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // lblIntro
            // 
            this.lblIntro.BackColor = System.Drawing.Color.Transparent;
            this.lblIntro.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.ForeColor = System.Drawing.Color.Red;
            this.lblIntro.Location = new System.Drawing.Point(72, 103);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(713, 293);
            this.lblIntro.TabIndex = 3;
            this.lblIntro.Text = "lntro";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EX1.Properties.Resources.Doom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.lblGameName);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(810, 502);
            this.VisibleChanged += new System.EventHandler(this.MainMenu_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.Label lblIntro;
    }
}
