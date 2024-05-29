using _3inRowGame.Forms;
using _3inRowGame.Pages;
using _3inRowGame.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3inRowGame.Controls
{
    public partial class GameModeControl : UserControl
    {
        private MainPage mainPage;
        public GameModeControl(MainPage mainPage)
        {
            this.mainPage = mainPage;
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            mainPage.CenterControl = new MainMenuControl(mainPage);
        }

        private void buttonModeUnique_Click(object sender, EventArgs e)
        {
            Navigator.SetPage(new GamePage());
        }

        private void buttonModePlaceUnique_Click(object sender, EventArgs e)
        {
            Navigator.SetPage(new GamePage());
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            Navigator.SetPage(new GamePage());
        }

        private void buttonModeFields_Click(object sender, EventArgs e)
        {
            Navigator.SetPage(new GamePage());
        }
    }
}
