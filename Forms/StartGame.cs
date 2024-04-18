using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _3inRowGame
{
    public partial class StartGame : Form
    {
        public StartGame()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Вы хотите покинуть игру", "Предупреждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void settings_Click(object sender, EventArgs e)
        {

        }
    }
}
