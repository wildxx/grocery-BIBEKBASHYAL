﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace grocery.Models.ViewModel
{
    public class ChangePasswordViewModel
    {
        public string username { get; set; }
        [Required]
        public string OldPassword { get; set; }
        [Required]
        public string NewPassword { get; set; }
        [Compare("NewPassword", ErrorMessage = "Password Mismatch")]
        public string ConfirmNew { get; set; }
    }
}