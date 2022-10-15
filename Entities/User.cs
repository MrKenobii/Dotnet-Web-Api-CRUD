﻿using System;
using System.Collections.Generic;

#nullable disable

namespace User.Entities
{
    public partial class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
