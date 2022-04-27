using online_store.Enums;
using online_store.Interfaces;
using online_store.Pesources;
using online_store.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace online_store.Menus
{
    class AuthMenu
    {
        private readonly IPrinter _printer;

        private readonly IIdentityServices _identity;

        public AuthMenu(IPrinter printer, IIdentityServices identity)
        {
            _printer = printer;

            _identity = identity;
        }

        public void Menu()
        {           
            bool isMenu = true;

            while (isMenu)
            {
                _printer.ShowPointAuthMenu();

                Console.WriteLine(ApplicationResources.EnterMenuNumber);

                AuthMenuType authMenuType = (AuthMenuType)Validation.GetCorrectNumber();             

                MainMenu mainMenu = new MainMenu(_printer);

                Console.Clear();

                switch (authMenuType)
                {
                    case AuthMenuType.First:
                        {
                            SingInServices singIn = new SingInServices(_identity);

                            singIn.Authorization();

                            mainMenu.Menu();

                            break;
                        }
                    case AuthMenuType.Second:
                        {
                            SingUpServices singUp = new SingUpServices(_identity);

                            singUp.Registration();

                            break;
                        }
                    case AuthMenuType.Third:
                        {
                            Environment.Exit(0);

                            break;
                        }
                    default:
                        {
                            Console.WriteLine(ApplicationResources.IsValid);

                            break;
                        }
                }
            }         
        }
    }
}
