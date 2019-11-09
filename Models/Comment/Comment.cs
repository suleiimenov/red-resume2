using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace red_resume.Models.Comment
{
    public class Comment
    {

        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Comment")]
        public string Name { get; set; }


        [Display(Name = "Task")]
        public List<Task.Task> Task { get; set; }
    }
}
