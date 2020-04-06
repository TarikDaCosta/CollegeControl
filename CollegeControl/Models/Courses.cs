using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CollegeControl.Models
{
    public class Courses
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public String Name { get; set; }
        public virtual ICollection<Subjects> Subjects { get; set; }
        public virtual ICollection<Student> Student { get; set; }
        public virtual ICollection<Grades> Grades { get; set; }
    }
}