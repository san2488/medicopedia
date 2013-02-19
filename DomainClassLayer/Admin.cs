using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DomainClassLayer
{
    public class Admin
    {
        private int? adminId;
        private string username;
        private string adminName;

        public int? AdminId
        {
            get { return adminId; }
            set { adminId = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string AdminName
        {
            get { return adminName; }
            set { adminName = value; }
        }

    }
}

