using _3inRowGame.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3inRowGame.Controls
{
    public partial class MainMenuControl : UserControl
    {
        private MainPage mainPage;
        public MainMenuControl(MainPage mainPage)
        {
            this.mainPage = mainPage;
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            mainPage.CenterControl = new GameModeControl(mainPage);
        }

        private void buttonChangeUser_Click(object sender, EventArgs e)
        {
            mainPage.CenterControl = new AuthControl(mainPage);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void buttonBonuses_Click(object sender, EventArgs e)
        {

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
        }
    }
}
