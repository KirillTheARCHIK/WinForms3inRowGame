using _3inRowGame.Entities.Items;
using _3inRowGame.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3inRowGame.Entities
{
    public abstract class Item
    {
        public ItemPictureBox pictureBox;
        public int row;
        public int col;
        public Action<Item, Item> onSlideToNeighbourItem;
        public Item()
        {
            pictureBox = new ItemPictureBox(this);
            pictureBox.Size = new Size(Constants.itemSize, Constants.itemSize);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        string ResolveImagePath(string relativePath)
        {
            return Directory.GetCurrentDirectory() + "\\..\\..\\Images\\"+relativePath;
        }

        protected abstract string GetImagePath();

        public void Init()
        {
            pictureBox.Image = new Bitmap(ResolveImagePath(GetImagePath()));
        }
    }
}
