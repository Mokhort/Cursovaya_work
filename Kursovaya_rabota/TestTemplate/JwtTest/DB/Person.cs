using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursovaya_work.DB
{
    public enum UserRole
    {
        Admin = 0,
        Moderator = 1,
        User = 2
    }

    public class Person
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public UserRole Role { get; set; }
        public string Avatar { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
       // public string Email { get; set; }
        public string Passport { get; set; }
        public virtual List<Flight> Flight { get; set; }
       
    }
}
