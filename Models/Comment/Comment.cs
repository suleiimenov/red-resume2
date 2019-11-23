using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace red_resume.Models.Comment
{
    public class Comment
    {

        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Comment")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Task")]
        public Tasks.Tasks Task { get; set; }
    }
}
