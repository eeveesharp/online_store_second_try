using online_store.Interfaces;
using online_store.Pesources;
using online_store.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace online_store
{
    static class Validation
    {
        public static int GetCorrectNumber()
        {
            int number;

            while (!int.TryParse(Console.ReadLine(),out number))
            {
                Console.WriteLine(ApplicationResources.IsValid);
            }

            return number;
        }

        public static bool IsCheckSingIn(string login, string password)
        {
            bool isSingIn = true;

            for (int i = 0; i < UserStorage.Users.Count; i++)
            {
                if (UserStorage.Users[i].Login == login 
                    && UserStorage.Users[i].Password == password)
                {
                    isSingIn = false;
                }
            }

            return isSingIn;
        }

        public static bool IsCheckSingUp(string login)
        {
            bool isLogin = true;

            for (int i = 0; i < UserStorage.Users.Count; i++)
            {
                if (UserStorage.Users[i].Login == login)
                {
                    isLogin = false;

                    Console.WriteLine(ApplicationResources.UsersIsFind);

                    return isLogin;
                }
            }

            return isLogin;
        }
    }
}
