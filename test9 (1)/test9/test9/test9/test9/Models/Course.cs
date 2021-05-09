using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test9.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }

        public string CourseName { get; set; }
        public string CourseDes { get; set; }


        public int CourseCatID { get; set; }



        public string Id { get; set; }
        public virtual Trainer Trainer { get; set; }



        public virtual CourseCategories CourseCategories { get; set; }
    }
}