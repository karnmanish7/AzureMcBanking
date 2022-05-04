using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerBanking.API.Models
{
    public class Login
    {
        [Required(ErrorMessage="Username Require")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Password Require")]
        public string Password { get; set; }
    }
}
