using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace red_resume.Models.Task
{
    public class Task
    {


        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

<<<<<<< HEAD
        [Display(Name = "UserDepMapId")]
        public int UserDepMapId { get; set; }
        public UserDepMap.UserDepMap UserDepMap { get; set; }
=======
        [Display(Name = "UserDepMap")]
        public List<UserDepMap.UserDepMap> UserDepMap { get; set; }
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
    }
}
