using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3inRowGame.Utils
{
    class Navigator
    {
        private static Panel navPanel;
        public static void Init(Panel panel)
        {
            navPanel = panel;
        }

        public static UserControl current;
        public static void SetPage(UserControl control)
        {
            if (navPanel == null)
            {
                throw new Exception("Navigator wasn't initialized");
            }
            current = control;
            navPanel.Controls.Clear();
            navPanel.Controls.Add(current);
            current.Size = new Size(navPanel.Width, navPanel.Height);
        }
    }
}
