using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace red_resume.Models.UserDepMap
{
    public class UserDepMap
    {

        [Display(Name = "Id")]
        public int Id { get; set; }


        [Display(Name = "Status")]
        public Boolean Status { get; set; }

        [Required]
        [Display(Name = "User")]
        public User.User User { get; set; }

        [Required]
        [Display(Name = "Department")]
        public Department.Department Department { get; set; }
    }
}
