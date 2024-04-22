using _3inRowGame.Entities;
using _3inRowGame.Entities.Items;
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
        Random rand = new Random();

        string mode;
        int leftPanelWidth;
        Size playFieldPanelSizePx;
        Size playFieldPanelSizeItems = new Size(10, 10);
        Item[][] itemMatrix;
        public PlayForm(string mode)
        {
            InitializeComponent();
            this.mode = mode;
            Text = "Режим " + mode;
            leftPanelWidth = leftPanel.Width;
            playFieldPanelSizePx = new Size(
                playFieldPanelSizeItems.Width * Constants.itemSize,
                playFieldPanelSizeItems.Height * Constants.itemSize
                );
            playFieldPanel.Size = playFieldPanelSizePx;
            Width = leftPanelWidth + playFieldPanelSizePx.Width;

            itemMatrix = new Item[playFieldPanelSizeItems.Width][];
            for (int i = 0; i < playFieldPanelSizeItems.Height; i++)
            {
                itemMatrix[i] = new Item[playFieldPanelSizeItems.Height];
            }

            GameTurn();
        }

        public void SyncItemsPosition()
        {
            for (int i = 0; i < itemMatrix.Length; i++)
            {
                for (int j = 0; j < itemMatrix[i].Length; j++)
                {
                    var item = itemMatrix[i][j];
                    if (item != null)
                    {
                        item.pictureBox.Location = new Point(
                            i * Constants.itemSize,
                            (itemMatrix[i].Length - 1 - j) * Constants.itemSize
                            );
                    }
                }
            }
        }

        public void GameTurn()
        {
            while (true)
            {
                if (SpawnTopRow())
                {
                    continue;
                }
                if (FallDown())
                {
                    continue;
                }
                break;
            }
        }

        public bool FallDown()
        {
            if (itemMatrix.All((col) => col.All(item => item != null)))
            {
                return false;
            }
            foreach (var column in itemMatrix)
            {
                Array.Sort(column, delegate (Item a, Item b)
                {
                    if (a == null)
                    {
                        return 1;
                    }
                    else if (b == null)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                });
            }
            SyncItemsPosition();
            return true;
        }

        public bool SpawnTopRow()
        {
            if (itemMatrix.All(col=>col.Last()!=null))
            {
                return false;
            }
            for (int x = 0; x < playFieldPanelSizeItems.Width; x++)
            {
                var newItem = new DefaultItem((DefaultItemType)rand.Next(4));
                newItem.Init();
                SpawnItem(
                    new Point(x, itemMatrix[x].Length - 1),
                   newItem
                    );
            }
            SyncItemsPosition();
            return true;
        }

        public void SpawnItem(Point point, Item item)
        {
            if (itemMatrix[point.X][point.Y] == null)
            {
                itemMatrix[point.X][point.Y] = item;
                playFieldPanel.Controls.Add(item.pictureBox);
            }
        }
    }
}
