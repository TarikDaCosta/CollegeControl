using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CollegeControl.Models
{
    public class Student : Person
    {
        public int Registration { get; set; }
        [Display(Name = "Birthday")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public override DateTime Birth { get; set; }
        public virtual ICollection<Courses> Courses { get; set; }
        public virtual ICollection<Subjects> Subjects { get; set; }
    }
}