using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test9.Models
{
    public class Assign
    {
        [Key]
        public int AssignID { get; set; }
        [Required]
        public int CourseID { get; set; }
        [Required]
        public string Id { get; set; }

        public virtual Trainee Trainee { get; set; }
        public virtual Course Course { get; set; }
    }
}