using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarket_AD0484
{
    class user
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public user(string username, string password)
        {
            UserName = username;
            Password = password;
        }
    }
}
