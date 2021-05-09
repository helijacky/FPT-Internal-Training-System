using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test9.Models
{
    public class Trainer:ApplicationUser
    {
        public string Education { get; set; }
        public string Language { get; set; }
        public string ExpDetails { get; set; }
        public string Department { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Course> Course { get; set; }
    }
}