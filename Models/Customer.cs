﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectMgt.Models
{
    public class Customer
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}