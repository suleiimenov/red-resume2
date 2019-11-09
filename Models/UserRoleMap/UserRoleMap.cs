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


<<<<<<< HEAD
        [Display(Name = "UserId")]
        public int userId { get; set; }
        public User.User User { get; set; }

        [Display(Name = "RoleId")]
        public int roleId { get; set; }
        public Role.Role Role { get; set; }
=======
        [Display(Name = "User")]
        public List<User.User> User { get; set; }

        [Display(Name = "Role")]
        public List<Role.Role> Role { get; set; }
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
    }
}
