using Kursovaya_work.DB;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kursovaya_work.Models
{
    public class UserModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Required field")]
        [DisplayName("Login")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Required field")]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required field")]
        [DisplayName("LastName")]
        public string LastName { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Required field")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Passport")]
        [Required(ErrorMessage = "Required field")]
        public string Passport { get; set; }


        [DisplayName("Permission")]
        public UserRole Role { get; set; }
        [DisplayName("Avatar")]
        [DataType(DataType.Upload)]
        public IFormFile Avatar { get; set; }
        
        public List<AddressModel> Addres { get; set; }
    }
}
