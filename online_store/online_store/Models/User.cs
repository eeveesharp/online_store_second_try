using System;
using System.Collections.Generic;
using System.Text;

namespace online_store.Models
{
    class User
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public User(string login, string password,string name,string lastName)
        {
            this.Login = login;

            this.Password = password;

            this.Name = name;

            this.LastName = lastName;
        }

        public User(string login,string password)
        {
            this.Login = login;

            this.Password = password;
        }
    }
}
