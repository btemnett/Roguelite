namespace EX1
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
            this.lblFinalGameOver = new System.Windows.Forms.Label();
            this.lblFinalQuip = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.lblFinalQuip2 = new System.Windows.Forms.Label();
            this.lblFinalQuip3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFinalGameOver
            // 
            this.lblFinalGameOver.AutoSize = true;
            this.lblFinalGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblFinalGameOver.Location = new System.Drawing.Point(22, 11);
            this.lblFinalGameOver.Name = "lblFinalGameOver";
            this.lblFinalGameOver.Size = new System.Drawing.Size(281, 55);
            this.lblFinalGameOver.TabIndex = 0;
            this.lblFinalGameOver.Text = "Game Over";
            // 
            // lblFinalQuip
            // 
            this.lblFinalQuip.AutoSize = true;
            this.lblFinalQuip.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalQuip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalQuip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblFinalQuip.Location = new System.Drawing.Point(25, 84);
            this.lblFinalQuip.Name = "lblFinalQuip";
            this.lblFinalQuip.Size = new System.Drawing.Size(467, 25);
            this.lblFinalQuip.TabIndex = 1;
            this.lblFinalQuip.Text = "You\'ve fallen out of favor with the Unicorn Gods";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(677, 413);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMainMenu.TabIndex = 2;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.VisibleChanged += new System.EventHandler(this.btnMainMenu_VisibleChanged);
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // lblFinalQuip2
            // 
            this.lblFinalQuip2.AutoSize = true;
            this.lblFinalQuip2.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalQuip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalQuip2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblFinalQuip2.Location = new System.Drawing.Point(25, 117);
            this.lblFinalQuip2.Name = "lblFinalQuip2";
            this.lblFinalQuip2.Size = new System.Drawing.Size(209, 25);
            this.lblFinalQuip2.TabIndex = 3;
            this.lblFinalQuip2.Text = "Doom has taken you";
            // 
            // lblFinalQuip3
            // 
            this.lblFinalQuip3.AutoSize = true;
            this.lblFinalQuip3.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalQuip3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalQuip3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblFinalQuip3.Location = new System.Drawing.Point(25, 152);
            this.lblFinalQuip3.Name = "lblFinalQuip3";
            this.lblFinalQuip3.Size = new System.Drawing.Size(347, 25);
            this.lblFinalQuip3.TabIndex = 4;
            this.lblFinalQuip3.Text = "but thats ok... the unicorn got away";
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EX1.Properties.Resources.GameOver;
            this.Controls.Add(this.lblFinalQuip3);
            this.Controls.Add(this.lblFinalQuip2);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.lblFinalQuip);
            this.Controls.Add(this.lblFinalGameOver);
            this.Name = "GameOver";
            this.Size = new System.Drawing.Size(798, 488);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFinalGameOver;
        private System.Windows.Forms.Label lblFinalQuip;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label lblFinalQuip2;
        private System.Windows.Forms.Label lblFinalQuip3;
    }
}
