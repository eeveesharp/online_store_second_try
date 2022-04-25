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

        private readonly FileServices FileServices = new FileServices();

        public SingInServices(IIdentityServices identity)
        {
            _identity = identity;
        }

        public void Authorization()
        {
            User currentUser = new User(GetLogin(), GetPassword());            

            Validation.IsCheckSingIn(currentUser.Login, currentUser.Password);
        }

        private string GetLogin() => _identity.GetLoginFromSingIn();
        
        private string GetPassword() => _identity.GetPassword();
    }
}
