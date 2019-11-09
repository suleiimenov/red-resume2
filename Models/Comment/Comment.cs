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


<<<<<<< HEAD
        [Display(Name = "TaskId")]
        public int TaskId { get; set; }
        public Task.Task Task { get; set; }
=======
        [Display(Name = "Task")]
        public List<Task.Task> Task { get; set; }
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
    }
}
