using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace red_resume.Models.UserRoleMap
{
    public class UserRoleMap
    {
        [Display(Name = "Id")]
        public int Id { get; set; }


        [Display(Name = "User")]
        public List<User.User> User { get; set; }

        [Display(Name = "Role")]
        public List<Role.Role> Role { get; set; }
    }
}
