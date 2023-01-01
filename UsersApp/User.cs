using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp
{
    class User
    {
        private int id { get; set; }
        private string login { get; set; }
        private string pass { get; set; }
        private string email { get; set; }

        public User() { }

        public User(string login, string pass, string email)
        {
            this.login = login;
            this.pass = pass;
            this.email = email;
        }

    }
}
