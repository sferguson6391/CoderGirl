﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CG.Models
{
    public static class UserData
    {
        static private List<User> users = new List<User>();

        public static List<User> GetAll()
        {
            return users;
        }

        public static void Add(User newUser)
        {
            users.Add(newUser);
        }

        public static User GetById(int id)
        {
            
            return users.Single(x => x.UserId == id);
        }
    }
}
