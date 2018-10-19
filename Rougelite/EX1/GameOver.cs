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
    public partial class GameOver : UserControl
    {
        private RogueliteForm _roguelite;
        public GameOver()
        {
            InitializeComponent();
        }
        string message1 = "Doom has taken you...";
        string message2 = "You have fallen out of favor with the Unicorn Gods";
        string message3 = "But that's okay... The Unicorn got away";

        public RogueliteForm Roguelite
        {
            get { return _roguelite; }
            set { _roguelite = value; }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            _roguelite.SwitchScreens(ScreenId.MAIN_MENU);
        }
        public async void ShowMessage(string message, Label label)
        {
            label.Text = "";
            foreach (char c in message)
            {
                label.Text += c;
                await Task.Delay(100);
            }
        }

        private void btnMainMenu_VisibleChanged(object sender, EventArgs e)
        {
            ShowMessage(message1, lblFinalQuip);
            ShowMessage(message2, lblFinalQuip2);
            ShowMessage(message3, lblFinalQuip3);
        }
    }
}
