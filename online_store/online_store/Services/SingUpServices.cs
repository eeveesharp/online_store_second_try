using online_store.Interfaces;
using online_store.Models;
using online_store.Pesources;
using online_store.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace online_store.Services
{
    class SingUpServices
    {
        private readonly IIdentityServices _identity;

        public SingUpServices(IIdentityServices identity)
        {
            this._identity = identity;
        }

        public void Registration()
        {
            User user = new User(GetLogin(), 
                GetPassword(), 
                GetName(), 
                GetLastName());

            UserStorage.Users.Add(user);

            FileServices<User>.WriteFile(UserStorage.Users, ApplicationResources.UsersFileName);                
        }

        private string GetLogin() => _identity.GetLoginFromSingUp();

        private string GetPassword() => _identity.GetPassword();

        private string GetName() => _identity.GetName();

        private string GetLastName() => _identity.GetLastName();
    }
}
