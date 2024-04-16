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

namespace _3inRowGame
{
    public partial class PlayForm : Form
    {
        int level;
        int leftPanelWidth;
        Size playFieldPanelSizePx;
        Size playFieldPanelSizeItems = new Size(10, 10);
        public PlayForm(int level)
        {
            this.level = level;
            InitializeComponent();
            Text = "Уровень " + level;
            leftPanelWidth = leftPanel.Width;
            playFieldPanelSizePx = new Size(
                playFieldPanelSizeItems.Width * Constants.itemSize,
                playFieldPanelSizeItems.Height * Constants.itemSize
                );
            playFieldPanel.Size = playFieldPanelSizePx;
            Width = leftPanelWidth + playFieldPanelSizePx.Width;
        }
    }
}
