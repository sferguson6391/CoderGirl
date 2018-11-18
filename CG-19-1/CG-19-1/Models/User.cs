﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CG.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Verify { get; set; }
        public DateTime UserDateTime { get; set; }
        public int UserId { get; set; }
        private static int nextId = 1;

        public User()
        {
            UserId = nextId;
            nextId++;
            UserDateTime = DateTime.Now;
        }
    }
}
