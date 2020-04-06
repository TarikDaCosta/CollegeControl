using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CollegeControl.Models
{
    public class Grades
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public decimal Grade { get; set; }
        [Display(Name = "Subject")]
        public int SubjectsId { get; set; }
        [Display(Name = "Student")]
        public int StudentId { get; set; }
        public virtual Subjects Subjects { get; set; }
        public virtual Student Student { get; set; }
    }
}