﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace red_resume.Models.Role
{
    public class Role
    {


        [Display(Name = "Id")]
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        
    }
}
