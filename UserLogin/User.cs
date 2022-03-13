﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string facNum { get; set; }
        public int userRole { get; set; }
        public DateTime isActive { get; set; }
        public DateTime created;

        public User(string username, string password, string facNum, int userRole, DateTime created, DateTime isActive)
        {
            this.username = username;
            this.password = password;
            this.facNum = facNum;
            this.userRole = userRole;
            this.created = created;
            this.isActive = isActive;
        }

        public override string ToString()
        {
            return username + " " + facNum + " " + userRole;
        }
    }
}
