using _3inRowGame.Controls;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3inRowGame.Forms
{
    public partial class MainPage : UserControl
    {
        private Control centerControl;
        public Control CenterControl
        {
            get
            {
                return centerControl;
            }
            set
            {
                this.centerControl = value;
                if (flowLayoutPanelCenter.Controls.Count > 1)
                {
                    flowLayoutPanelCenter.Controls.RemoveAt(1);
                }
                flowLayoutPanelCenter.Controls.Add(centerControl);
            }
        }
        public MainPage()
        {
            InitializeComponent();
            CenterControl = new AuthControl(this);
            CenterPanel();
        }

        void CenterPanel()
        {
            flowLayoutPanelCenter.Margin = new Padding((this.Width - centerControl.Width) / 2, 100, 0, 100);
            label1.Margin = new Padding((flowLayoutPanelCenter.Width - label1.Width) / 2, 0, 0, 0);
        }

        private void MainPage_SizeChanged(object sender, EventArgs e)
        {
            //Program.logger.LogInformation(this.Width.ToString() + ";" + centerControl.Width.ToString());
            CenterPanel();
        }
    }
}
