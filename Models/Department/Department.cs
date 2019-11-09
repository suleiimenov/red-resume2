using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace red_resume.Models.Department
{
    public class Department
    {


        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }


        [Display(Name = "Organization")]
<<<<<<< HEAD
        public Organization.Organization Organization { get; set; }
=======
        public List<Organization.Organization> Organization { get; set; }
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
    }
}
