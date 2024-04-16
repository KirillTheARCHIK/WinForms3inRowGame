﻿using _3inRowGame.Utils;
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
    abstract class Item
    {
        PictureBox pictureBox;
        public Item()
        {
            pictureBox = new PictureBox();
            pictureBox.Size = new Size(Constants.itemSize, Constants.itemSize);
            pictureBox.Image = new Bitmap(ResolveImagePath(GetImagePath()));
        }

        string ResolveImagePath(string relativePath)
        {
            return Directory.GetCurrentDirectory() + "\\..\\..\\Images\\"+relativePath;
        }

        protected abstract string GetImagePath();
    }
}
