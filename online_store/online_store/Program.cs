using online_store.Menus;
using online_store.Services;
using online_store.Pesources;
using System;
using online_store.Storage;
using online_store.Models;
using online_store.Interfaces;

namespace online_store
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = $"{ApplicationResources.NotSingIn}";

            UserStorage.Users = FileServices<User>.ReadFile(UserStorage.Users, ApplicationResources.UsersFileName);

            ProductStorage.Products = FileServices<Product>.ReadFile(ProductStorage.Products, ApplicationResources.ProductsFileName);

            IPrinter printer = new ConsolePrinter();

            IIdentityServices identity = new IdentityServices();

            AuthMenu authMenu = new AuthMenu(printer, identity);           

            authMenu.Menu();
        }
    }
}
