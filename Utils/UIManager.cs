using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3inRowGame
{
    class UIManager
    {


        public static void exitButton()
        {
          var result =  MessageBox.Show("Вы желаете покинуть игру?", "Предупреждение!", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes) 
            {
                exit();
            }
        }

        public static void exit()
        {
            Application.Exit();
        }

       
    }
}
