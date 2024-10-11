﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BLL.ModelVM
{
    public class LogInViewModel
    {
        [Required(ErrorMessage = "email is required")]
        [EmailAddress(ErrorMessage = "invalid email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "remember me")]
        public bool RememberMe { get; set; }
    }
}
