using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DomainClassLayer
{
    public class Users
    {
        private int? userId;
        private string username;
        private string userFullName;
        private string userEmailId;
        private bool? userGender;
        private DateTime? userDOB;
        private string userAreaOfInterest;

        public int? UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string UserFullName
        {
            get { return userFullName; }
            set { userFullName = value; }
        }
        public string UserEmailId
        {
            get { return userEmailId; }
            set { userEmailId = value; }
        }
        public bool? UserGender
        {
            get { return userGender; }
            set { userGender = value; }
        }
        public DateTime? UserDOB
        {
            get { return userDOB; }
            set { userDOB = value; }
        }
        public string UserAreaOfInterest
        {
            get { return userAreaOfInterest; }
            set { userAreaOfInterest = value; }
        }

    }
}
