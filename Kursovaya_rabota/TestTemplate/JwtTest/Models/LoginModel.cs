using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kursovaya_work.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Required field")]
        [DisplayName("Login")]
        public string Username { get; set; }
        [DisplayName("Password")]
        [Required(ErrorMessage = "Required field")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
