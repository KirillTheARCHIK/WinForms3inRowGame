using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3inRowGame.Entities.Items
{
    enum DefaultItemType
    {
        helm,
        treasure,
        clover,
        crown,
    }
    class DefaultItem : Item
    {
        public DefaultItem(DefaultItemType type) : base()
        {

        }
        protected override string GetImagePath()
        {
            
        }
    }
}
