﻿using online_store.Interfaces;
using online_store.Pesources;
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
            return false;
        }

        public static bool IsCheckSingUp(string login)
        {
            return false;
        }
    }
}