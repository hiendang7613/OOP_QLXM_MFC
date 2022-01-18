using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLXM.DTO
{
    class Account
    {

        public string Username { get ; set; }
        public string Password { get; set; }

        public Account()
        {
            this.Username = "";
            this.Password = "";
        }

        public Account(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }


    }
}
