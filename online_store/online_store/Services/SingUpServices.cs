using online_store.Interfaces;
using online_store.Models;
using online_store.Pesources;
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
            User currentUser = new User(GetLogin(), GetPassword(), GetName(), GetLastName());

            Validation.IsCheckSingIn(currentUser.Login, currentUser.Password);
        }

        private string GetLogin() => _identity.GetLogin();

        private string GetPassword() => _identity.GetPassword();

        private string GetName() => _identity.GetName();

        private string GetLastName() => _identity.GetLastName();
    }
}
