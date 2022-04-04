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
        public void Menu()
        {
            bool isMenu = true;

            while (isMenu)
            {
                Console.WriteLine($"{ApplicationResources.AuthMenuSingIn}\n" +
               $"{ApplicationResources.AuthMenuSingUp}\n" +
               $"{ApplicationResources.AuthMenuExit}");

                Console.WriteLine(ApplicationResources.EnterMenuNumber);

                AuthMenuType authMenuType = (AuthMenuType)Validation.GetCorrectNumber();

                IIdentityServices identity = new IdentityServices();

                MainMenu mainMenu = new MainMenu();

                Console.Clear();

                switch (authMenuType)
                {
                    case AuthMenuType.First:
                        {
                            SingInServices singIn = new SingInServices(identity);

                            singIn.Authorization();

                            mainMenu.Menu();

                            break;
                        }
                    case AuthMenuType.Second:
                        {
                            SingUpServices singUp = new SingUpServices(identity);

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
