using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DomainClassLayer
{
    public class AuthTable
    {
        private string username;
        private string password;
        private int? role;
        private int? userId;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public int? Role
        {
            get { return role; }
            set { role = value; }
        }
        public int? UserId
        {
            get { return userId; }
            set { userId = value; }
        }

    }
}
