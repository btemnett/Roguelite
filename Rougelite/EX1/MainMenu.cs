using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class MainMenu : UserControl
    {
        private RogueliteForm _roguelite;

        public MainMenu()
        {
            InitializeComponent();
        }
        string introMessage =
            "It is a dark and stormy night. The skies have lost all of their " +
            "Rainbows. The Unicorn Gods are in turmoil for DOOM has entered " +
            "their domain. Slaughter ensues as DOOM cares not for the beauty " +
            "of a Unicorn... At the end of the night DOOM departs the Unicorn " +
            "God's world thinking all have perished, but... one Unicorn God " +
            "remains..." + "\r\n" +
            "Hit Play to enter DOOM's world and avenge your brethren!";

        public RogueliteForm Roguelite
        {
            get { return _roguelite; }
            set { _roguelite = value; }
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            _roguelite.CurrentGame = new Game();

            CharacterFactory characterFactory = new CharacterFactory();
            Character hero = characterFactory.SpawnPlayer();
            _roguelite.CurrentGame.Player = hero;
            _roguelite.SaveGamePath = null;
            _roguelite.SwitchScreens(ScreenId.COMBAT);
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            OpenFileDialog dLog = new OpenFileDialog();
            dLog.Filter = "Save Game (*.sav)|*.sav";
            if (dLog.ShowDialog() == DialogResult.OK)
            {
                string path = dLog.FileName;
                _roguelite.SaveGamePath = path;
                _roguelite.CurrentGame = Game.LoadGame(path);
                _roguelite.SwitchScreens(ScreenId.INVENTORY);
            }
        }

        private void MainMenu_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                ShowIntroMessage(introMessage);
            }
            
        }
        public async void ShowIntroMessage(string message)
        {
            lblIntro.Text = "";
            foreach (char c in message)
            {
                lblIntro.Text += c;
                await Task.Delay(100);
            }
        }
    }
}
