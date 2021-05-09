using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test9.Models
{
    public class Trainee:ApplicationUser
    {
        public string Type { get; set; }
        public string WorkingPlace { get; set; }
        public string PhoneNum { get; set; }


        public virtual ICollection<Assign> Assign { get; set; }
    }
}