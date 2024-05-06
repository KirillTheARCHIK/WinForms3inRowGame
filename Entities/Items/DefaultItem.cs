using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3inRowGame.Entities.Items
{
    enum DefaultItemType
    {
        anchor,
        treasure,
        map,
        skull,
    }
    class DefaultItem : Item
    {
       public DefaultItemType type;
        public DefaultItem(DefaultItemType type) : base()
        {
            this.type = type;
        }
        protected override string GetImagePath()
        {
            switch (type)
            {
                case DefaultItemType.anchor:
                    return "ItemAnchor.png";
                case DefaultItemType.treasure:
                    return "ItemTreasure.png";
                case DefaultItemType.map:
                    return "ItemMap.png";
                case DefaultItemType.skull:
                    return "ItemSkull.png";
                default:
                    return "";
            }
        }
    }
}
