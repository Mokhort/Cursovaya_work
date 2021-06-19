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
    public class EditUserModel
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "Reqiured field")]
        [DisplayName("New login")]
        public string Username { get; set; }

        [DisplayName("New name")]
        public string Name { get; set; }

        [DisplayName("New lastname")]
        public string LastName { get; set; }

        [DisplayName("New password")]
        public string NewPassword { get; set; }

        [DisplayName("New passport")]
        public string Passport { get; set; }
        [DisplayName("Permission")]
        public UserRole Role { get; set; }
        [DisplayName("Download avatar")]
        [DataType(DataType.Upload)]
        public IFormFile Avatar { get; set; }
    }
}
