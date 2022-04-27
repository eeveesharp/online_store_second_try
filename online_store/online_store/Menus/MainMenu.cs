using online_store.Enums;
using online_store.Interfaces;
using online_store.Pesources;
using System;
using System.Collections.Generic;
using System.Text;

namespace online_store.Menus
{
    class MainMenu
    {
        private readonly IPrinter _printer;

        public MainMenu(IPrinter printer)
        {
            _printer = printer;
        }

        public void Menu()
        {
            bool isMenu = true;           

            while (isMenu)
            {
                _printer.ShowPointMainMenu();

                Console.WriteLine(ApplicationResources.EnterMenuNumber);

                MainMenuType mainMenuType = (MainMenuType)Validation.GetCorrectNumber();

                switch (mainMenuType)
                {
                    case MainMenuType.First:
                        {
                            _printer.ShowCatalog();

                            break;
                        }                      
                    case MainMenuType.Second:
                        {
                            break;
                        }
                    case MainMenuType.Third:
                        {
                            break;
                        }

                    case MainMenuType.Fourth:
                        {
                            break;
                        }

                    case MainMenuType.Fiveth:
                        {
                            Console.Clear();

                            Console.Title = $"{ApplicationResources.NotSingIn}";

                            return;
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
