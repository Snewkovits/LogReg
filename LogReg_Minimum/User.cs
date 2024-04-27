using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogReg_Minimum
{
    internal class User
    {
        int id;
        string username;
        string email;
        string passwd;

        public User(int id, string username, string email, string passwd)
        {
            this.id = id;
            this.username = username;
            this.email = email;
            this.passwd = passwd;
        }

        public int getId() { return id; }
        public string getUsername() { return username; }
        public string getEmail() { return email; }
        public string getPassword() { return passwd; }
        public override string ToString()
        {
            return id + ":" + username + ":" + email;
        }
    }
}
