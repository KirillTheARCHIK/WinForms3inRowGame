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
                    return "armor_soldier_ninja_avatar_wheel_war_warrior_helm_game_icon_262426.png";
                case DefaultItemType.treasure:
                    return "crown_game_sports_console_controller_sport_video_play_gaming_icon_262443.png";
                case DefaultItemType.map:
                    return "treasure_box_secret_prize_award_rich_coin_gold_game_icon_262449.png";
                case DefaultItemType.skull:
                    return "video_game_console_controller_sport_joystick_shamrock_treasure_icon_262438.png";
                default:
                    return "";
            }
        }
    }
}
