﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role RoleName { get; set; }

    }
}
