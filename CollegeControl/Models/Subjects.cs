using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CollegeControl.Models
{
    public class Subjects
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        
        [Display(Name = "Course")]
        public int CoursesId { get; set; }

        [Display(Name = "Teacher")]
        public int TeachersId { get; set; }
        public virtual Courses Courses { get; set; }
        public virtual Teachers Teachers { get; set; }
        public virtual ICollection<Student> Student { get; set; }
        public virtual ICollection<Grades> Grades { get; set; }
        //public virtual ICollection<Teachers> Teachers { get; set; }
    }
}