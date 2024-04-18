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
        DefaultItemType type;
        public DefaultItem(DefaultItemType type) : base()
        {
            this.type = type;
        }
        protected override string GetImagePath()
        {
            switch (type)
            {
                case DefaultItemType.anchor:
                    break;
                case DefaultItemType.treasure:
                    break;
                case DefaultItemType.map:
                    break;
                case DefaultItemType.skull:
                    break;
                default:
                    break;
            }
            return "armor_soldier_ninja_avatar_wheel_war_warrior_helm_game_icon_262426.png";
        }
    }
}
