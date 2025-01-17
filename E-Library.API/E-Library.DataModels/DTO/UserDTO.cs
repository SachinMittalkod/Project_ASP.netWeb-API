﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Library.DataModels.DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public int? MobileNo { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public int RoleId { get; set; }
    }
}
