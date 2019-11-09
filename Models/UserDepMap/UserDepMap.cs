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

        [Display(Name = "User")]
        public List<User.User> User { get; set; }

        [Display(Name = "Department")]
        public List<Department.Department> Department { get; set; }
    }
}
