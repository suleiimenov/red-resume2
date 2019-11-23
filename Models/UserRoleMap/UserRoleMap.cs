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


        [Required]
        [Display(Name = "User")]
        public User.User User { get; set; }

        [Required]
        [Display(Name = "Role")]
        public Role.Role Role { get; set; }
    }
}
