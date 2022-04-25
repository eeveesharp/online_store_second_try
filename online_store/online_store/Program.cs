using online_store.Menus;
using online_store.Services;
using online_store.Pesources;
using System;

namespace online_store
{
    class Program
    {
        static void Main(string[] args)
        {
            FileServices fileServices = new FileServices();

            fileServices.ReadFile(ApplicationResources.UsersFileName);

            AuthMenu authMenu = new AuthMenu();           

            authMenu.Menu();
        }
    }
}
