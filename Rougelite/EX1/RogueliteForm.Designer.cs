namespace EX1
{
    partial class RogueliteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RogueliteForm));
            this.inventoryScreen = new EX1.InventoryScreen();
            this.combatScreen = new EX1.CombatScreen();
            this.mainMenu = new EX1.MainMenu();
            this.gameOver = new EX1.GameOver();
            this.SuspendLayout();
            // 
            // inventoryScreen
            // 
            this.inventoryScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inventoryScreen.BackgroundImage")));
            this.inventoryScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventoryScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryScreen.Location = new System.Drawing.Point(0, 0);
            this.inventoryScreen.Name = "inventoryScreen";
            this.inventoryScreen.Roguelite = null;
            this.inventoryScreen.Size = new System.Drawing.Size(858, 472);
            this.inventoryScreen.TabIndex = 1;
            this.inventoryScreen.Visible = false;
            // 
            // combatScreen
            // 
            this.combatScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("combatScreen.BackgroundImage")));
            this.combatScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.combatScreen.Location = new System.Drawing.Point(0, 0);
            this.combatScreen.Name = "combatScreen";
            this.combatScreen.Roguelite = null;
            this.combatScreen.Size = new System.Drawing.Size(826, 479);
            this.combatScreen.TabIndex = 0;
            this.combatScreen.Visible = false;
            // 
            // mainMenu
            // 
            this.mainMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainMenu.BackgroundImage")));
            this.mainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Roguelite = null;
            this.mainMenu.Size = new System.Drawing.Size(858, 472);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Visible = false;
            // 
            // gameOver
            // 
            this.gameOver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameOver.BackgroundImage")));
            this.gameOver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameOver.Location = new System.Drawing.Point(0, 0);
            this.gameOver.Name = "gameOver";
            this.gameOver.Roguelite = null;
            this.gameOver.Size = new System.Drawing.Size(858, 472);
            this.gameOver.TabIndex = 3;
            this.gameOver.Visible = false;
            // 
            // RogueliteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(858, 472);
            this.Controls.Add(this.combatScreen);
            this.Controls.Add(this.gameOver);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.inventoryScreen);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "RogueliteForm";
            this.Text = "Roguelite";
            this.ResumeLayout(false);

        }

        #endregion

        private CombatScreen combatScreen;
        private InventoryScreen inventoryScreen;
        private MainMenu mainMenu;
        private GameOver gameOver;
    }
}

