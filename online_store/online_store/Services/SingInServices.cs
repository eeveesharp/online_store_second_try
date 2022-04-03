using online_store.Interfaces;
using online_store.Models;
using online_store.Pesources;
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
            User currentUser = new User(GetLogin(), GetPassword());

            Validation.IsCheckSingIn(currentUser.Login, currentUser.Password);
        }

        private string GetLogin() => _identity.GetLogin();
        
        private string GetPassword() => _identity.GetPassword();
    }
}
