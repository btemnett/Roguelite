using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class RogueliteForm : Form
    {
        private Game _currentGame;
        private string _saveGamePath;

        public RogueliteForm()
        {
            InitializeComponent();

            mainMenu.Roguelite = this;
            combatScreen.Roguelite = this;
            inventoryScreen.Roguelite = this;
            gameOver.Roguelite = this;

            mainMenu.Visible = true;
        }
        public Game CurrentGame
        {
            get { return _currentGame; }
            set { _currentGame = value; }
        }
        public string SaveGamePath
        {
            get { return _saveGamePath; }
            set { _saveGamePath = value; }
        }

        public void SwitchScreens(ScreenId screen)
        {
            mainMenu.Visible = false;
            combatScreen.Visible = false;
            inventoryScreen.Visible = false;
            gameOver.Visible = false;

            switch (screen)
            {
                case ScreenId.MAIN_MENU:
                    mainMenu.Visible = true;
                    break;
                case ScreenId.COMBAT:
                    combatScreen.Visible = true;
                    break;
                case ScreenId.INVENTORY:
                    inventoryScreen.Visible = true;
                    break;
                case ScreenId.GAME_OVER:
                    gameOver.Visible = true;
                    break;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
