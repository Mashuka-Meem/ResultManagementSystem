using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResultManagementSystem.Models
{
    public class Login
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This Field is required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "This Field is required")]
        public int ActorId { get; set; }
    }



    public class LoginList
    {
        public List<Login> LoginAll { get; set; }
    }
}
