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

        [Display(Name = "UserId")]
        public int UserId { get; set; }
        public User.User User { get; set; }

        [Display(Name = "DepartmentId")]
        public int DepartmentId { get; set; }
        public Department.Department Department { get; set; }
    }
}
