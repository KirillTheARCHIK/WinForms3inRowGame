using _3inRowGame.Controls;
using _3inRowGame.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3inRowGame.Controls
{
    public enum AuthPageMode
    {
        Auth,
        Registration,
    }
    public partial class AuthControl : UserControl
    {
        private AuthPageMode mode;
        private MainPage mainPage;
        public AuthControl(MainPage mainPage,AuthPageMode mode = AuthPageMode.Auth)
        {
            this.mainPage = mainPage;
            this.mode = mode;
            InitializeComponent();
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

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case AuthPageMode.Auth:
                    {
                        mainPage.CenterControl = new MainMenuControl(mainPage);
                        break;
                    }
                case AuthPageMode.Registration:
                    {
                        break;
                    }
            }
        }
    }
}
