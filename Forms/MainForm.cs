﻿using _3inRowGame.Pages;
using _3inRowGame.Utils;
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
        public MainForm()
        {
            InitializeComponent();
            Navigator.Init(navigatorPanel);
            Navigator.SetPage(new GamePage());
        }
    }
}
