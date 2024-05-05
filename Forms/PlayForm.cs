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
    enum Direction
    {
        Up,
        Right,
        Down,
        Left
    }
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

        void SyncItemsPosition()
        {
            for (int i = 0; i < itemMatrix.Length; i++)
            {
                for (int j = 0; j < itemMatrix[i].Length; j++)
                {
                    var item = itemMatrix[i][j];
                    if (item != null)
                    {
                        item.col = i;
                        item.row = j;
                    }
                }
            }
            SuncItemsImages();
        }

        void SuncItemsImages()
        {
            for (int i = 0; i < itemMatrix.Length; i++)
            {
                for (int j = 0; j < itemMatrix[i].Length; j++)
                {
                    var item = itemMatrix[i][j];
                    if (item != null)
                    {
                        item.pictureBox.Location = new Point(
                            item.col * Constants.itemSize,
                            (itemMatrix[i].Length - 1 - item.row) * Constants.itemSize
                        );
                    }
                }
            }
        }

        async void GameTurn()
        {
            while (true)
            {
                await Task.Delay(300);
                if (SpawnTopRow())
                {
                    continue;
                }
                if (FallDown())
                {
                    continue;
                }
                if (CollapseItems())
                {
                    continue;
                }
                break;
            }
            MessageBox.Show("Stop");
        }

        bool FallDown()
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

        bool SpawnTopRow()
        {
            if (itemMatrix.All(col => col.Last() != null))
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

        void SpawnItem(Point point, Item item)
        {
            if (itemMatrix[point.X][point.Y] == null)
            {
                itemMatrix[point.X][point.Y] = item;
                playFieldPanel.Controls.Add(item.pictureBox);
            }
        }

        bool CollapseItems()
        {
            var findedItems = FindItemsRow();
            if (findedItems != null)
            {
                foreach (var item in findedItems)
                {
                    DeleteItem(item);
                }
                return true;
            }
            return false;
        }

        void DeleteItem(Item item)
        {
            itemMatrix[item.col][item.row] = null;
            playFieldPanel.Controls.Remove(item.pictureBox);
        }

        List<DefaultItem> FindItemsRow()
        {
            for (int startCol = 0; startCol < itemMatrix.Length; startCol++)
            {
                for (int startRow = 0; startRow < itemMatrix.Length; startRow++)
                {
                    var startItem = itemMatrix[startCol][startRow];
                    if (startItem is DefaultItem)
                    {
                        var startItemType = (startItem as DefaultItem).type;
                        for (int i = 0; i < 4; i++)
                        {
                            var itemsRow = PickItemsRow(startItemType, startCol, startRow, (Direction)i);
                            if (itemsRow != null)
                            {
                                return itemsRow;
                            }
                        }
                    }
                }
            }
            return null;
        }

        List<DefaultItem> PickItemsRow(DefaultItemType type, int startCol, int startRow, Direction direction)
        {
            var itemsRow = new List<DefaultItem>() { itemMatrix[startCol][startRow] as DefaultItem };
            switch (direction)
            {
                case Direction.Up:
                    {
                        if (itemMatrix[startCol].Length - startRow <= 3)
                        {
                            return null;
                        }
                        for (int row = startRow + 1; row < itemMatrix[startCol].Length; row++)
                        {
                            var item = itemMatrix[startCol][row];
                            if (item is DefaultItem && (item as DefaultItem).type == type)
                            {
                                itemsRow.Add(item as DefaultItem);
                                continue;
                            }
                            break;
                        }
                        break;
                    }
                case Direction.Right:
                    {
                        if (itemMatrix.Length - startCol <= 3)
                        {
                            return null;
                        }
                        for (int col = startCol + 1; col < itemMatrix.Length; col++)
                        {
                            var item = itemMatrix[col][startRow];
                            if (item is DefaultItem && (item as DefaultItem).type == type)
                            {
                                itemsRow.Add(item as DefaultItem);
                                continue;
                            }
                            break;
                        }
                        break;
                    }
                case Direction.Down:
                    {
                        if (startRow + 1 < 3)
                        {
                            return null;
                        }
                        for (int row = startRow - 1; row >= 0; row--)
                        {
                            var item = itemMatrix[startCol][row];
                            if (item is DefaultItem && (item as DefaultItem).type == type)
                            {
                                itemsRow.Add(item as DefaultItem);
                                continue;
                            }
                            break;
                        }
                        break;
                    }
                case Direction.Left:
                    {
                        if (startCol + 1 < 3)
                        {
                            return null;
                        }
                        for (int col = startCol - 1; col >= 0; col--)
                        {
                            var item = itemMatrix[col][startRow];
                            if (item is DefaultItem && (item as DefaultItem).type == type)
                            {
                                itemsRow.Add(item as DefaultItem);
                                continue;
                            }
                            break;
                        }
                        break;
                    }
            }
            return itemsRow.Count >= 3 ? itemsRow : null;
        }
    }
}
