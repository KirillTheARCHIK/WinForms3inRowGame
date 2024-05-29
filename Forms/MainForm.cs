using _3inRowGame.Forms;
using _3inRowGame.Pages;
using _3inRowGame.Utils;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3inRowGame
{
    public partial class MainForm : Form
    {
        public static List<int> user;
        public MainForm(ILogger<MainForm> logger)
        {
            Program.logger = logger;
            InitializeComponent();
            Navigator.Init(navigatorPanel);
            Navigator.SetPage(new MainPage());
            Navigator.current.Size = new Size(Width, Height);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            Navigator.current.Size = new Size(Width, Height);
        }
    }
}
