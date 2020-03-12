using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chatapp
{
    class users
    {
        String id;
        String username;
        String password;
        String email;

        public users(string id, string username,string password, string email)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.email = email;
        }
    }
}
