using online_store.Interfaces;
using online_store.Models;
using online_store.Pesources;
using online_store.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace online_store.Services
{
    class SingInServices
    {
        private readonly IIdentityServices _identity;

        public SingInServices(IIdentityServices identity)
        {
            _identity = identity;
        }

        public void Authorization()
        {
            UserStorage.CurrentUser = new User(GetLogin(), GetPassword());

            while (Validation.IsCheckSingIn(UserStorage.CurrentUser.Login, UserStorage.CurrentUser.Password))
            {
                Console.WriteLine(ApplicationResources.ErrorSingIn);

                UserStorage.CurrentUser = new User(GetLogin(), GetPassword());
            }

            Console.Title = $"User: {UserStorage.CurrentUser.Login}";
        }

        private string GetLogin() => _identity.GetLoginFromSingIn();
        
        private string GetPassword() => _identity.GetPassword();
    }
}
