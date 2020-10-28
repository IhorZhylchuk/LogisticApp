using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Logistic_2.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "No Email entered!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "No password entered!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords don't match!")]
        public string ConfirmPassword { get; set; }
    }
}
