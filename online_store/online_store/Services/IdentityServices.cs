using online_store.Interfaces;
using online_store.Models;
using online_store.Pesources;
using System;
using System.Collections.Generic;
using System.Text;

namespace online_store.Services
{
    class IdentityServices : IIdentityServices
    {
        public string GetLoginFromSingIn()
        {
            Console.WriteLine(ApplicationResources.EnterLogin);

            string login = Console.ReadLine();

            Console.Clear();

            return login;
        }

        public string GetLoginFromSingUp()
        {
            string login = string.Empty;

            do
            {
                Console.WriteLine(ApplicationResources.EnterLogin);

                login = Console.ReadLine();

            } while (!Validation.IsCheckSingUp(login));

            Console.Clear();

            return login;
        }

        public string GetPassword()
        {
            Console.WriteLine(ApplicationResources.EnterPassword);

            string password = Console.ReadLine();

            Console.Clear();

            return password;
        }

        public string GetName()
        {
            Console.WriteLine(ApplicationResources.EnterName);

            string name = Console.ReadLine();

            Console.Clear();

            return name;
        }

        public string GetLastName()
        {
            Console.WriteLine(ApplicationResources.EnterLastName);

            string lastName = Console.ReadLine();

            Console.Clear();

            return lastName;
        }       
    }
}
