using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3inRowGame.Entities.Items
{
    public class ItemPictureBox : PictureBox
    {
        public Item parent;

        public ItemPictureBox(Item parent)
        {
            this.parent = parent;
        }
    }
}
