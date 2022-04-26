using online_store.Menus;
using online_store.Services;
using online_store.Pesources;
using System;
using online_store.Storage;
using online_store.Models;

namespace online_store
{
    class Program
    {
        static void Main(string[] args)
        {
            UserStorage.Users = FileServices<User>.ReadFile(UserStorage.Users, ApplicationResources.UsersFileName);

            AuthMenu authMenu = new AuthMenu();           

            authMenu.Menu();
        }
    }
}
