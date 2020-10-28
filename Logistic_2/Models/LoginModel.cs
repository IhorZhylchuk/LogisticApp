using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Logistic_2.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "This field is required!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
