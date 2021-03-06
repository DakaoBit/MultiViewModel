﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MultiViewModel.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please Enter Email")]
        [EmailAddress(ErrorMessage = "Please Enter Formal Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}