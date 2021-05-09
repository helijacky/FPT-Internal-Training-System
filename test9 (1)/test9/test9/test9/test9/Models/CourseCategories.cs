using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test9.Models
{
    public class CourseCategories
    {
        [Key]
        public int CourseCatID { get; set; }


        public string CourseCatName { get; set; }
        public string CourseCatDes { get; set; }


        public virtual ICollection<Course> Courses { get; set; }

    }
}