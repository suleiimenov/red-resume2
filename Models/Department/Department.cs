﻿using System;
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
        public Organization.Organization Organization { get; set; }
    }
}
