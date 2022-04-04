using online_store.Enums;
using online_store.Pesources;
using System;
using System.Collections.Generic;
using System.Text;

namespace online_store.Menus
{
    class MainMenu
    {
        public void Menu()
        {
            bool isMenu = true;           

            while (isMenu)
            {
                Console.WriteLine($"{ApplicationResources.MainMenuShowCatalog}\n" +
                    $"{ApplicationResources.MainMenuSearchProduct}\n" +
                    $"{ApplicationResources.MainMenuShowBasket}\n" +
                    $"{ApplicationResources.MainMenuShowHistory}\n" +
                    $"{ApplicationResources.MainMenuLogOut}");

                Console.WriteLine(ApplicationResources.EnterMenuNumber);

                MainMenuType mainMenuType = (MainMenuType)Validation.GetCorrectNumber();

                switch (mainMenuType)
                {
                    case MainMenuType.First:
                        {
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
