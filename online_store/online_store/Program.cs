using online_store.Menus;
using System;

namespace online_store
{
    class Program
    {
        static void Main(string[] args)
        {
            AuthMenu authMenu = new AuthMenu();           

            authMenu.Menu();
        }
    }
}
