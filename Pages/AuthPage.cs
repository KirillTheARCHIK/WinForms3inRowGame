using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3inRowGame.Pages
{
    enum AuthPageMode
    {
        Auth,
        Registration,
    }
    public partial class AuthPage : UserControl
    {
        private AuthPageMode mode;
        public AuthPage()
        {
            InitializeComponent();
            mode = AuthPageMode.Auth;
            RefreshPage();
        }
        private void RefreshPage()
        {
            switch (mode)
            {
                case AuthPageMode.Auth:
                    {
                        labelTitle.Text = "Вход";
                        break;
                    }
                case AuthPageMode.Registration:
                    {
                        labelTitle.Text = "Регистрация";
                        break;
                    }
            }
        }
    }
}
