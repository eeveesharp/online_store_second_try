using online_store.Interfaces;
using online_store.Pesources;
using online_store.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace online_store.Services
{
    class ConsolePrinter : IPrinter
    {
        public void ShowCatalog()
        {
            for (int i = 0; i < ProductStorage.Products.Count; i++)
            {
                Console.WriteLine($"ID:{ProductStorage.Products[i].ID}\n " +
                    $"NAME:{ProductStorage.Products[i].Name}\n " +
                    $"PRICE:{ProductStorage.Products[i].Price}\n " +
                    $"QUANTITY:{ProductStorage.Products[i].Quantity}\n " +
                    $"DESCRIPTION:\n{ProductStorage.Products[i].Description}");

                Console.WriteLine(ApplicationResources.Line);
            }            
        }

        public void ShowPointMainMenu()
        {
            Console.WriteLine($"{ApplicationResources.MainMenuShowCatalog}\n" +
                    $"{ApplicationResources.MainMenuSearchProduct}\n" +
                    $"{ApplicationResources.MainMenuShowBasket}\n" +
                    $"{ApplicationResources.MainMenuShowHistory}\n" +
                    $"{ApplicationResources.MainMenuLogOut}");
        }

        public void ShowPointAuthMenu()
        {
            Console.WriteLine($"{ApplicationResources.AuthMenuSingIn}\n" +
              $"{ApplicationResources.AuthMenuSingUp}\n" +
              $"{ApplicationResources.AuthMenuExit}");
        }
    }
}
