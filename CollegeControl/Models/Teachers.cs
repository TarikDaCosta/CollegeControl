using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CollegeControl.Models
{
    public class Teachers : Person
    {
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Salary { get; set; }
        [Display(Name = "Birthday")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public override DateTime Birth { get; set; }
    }
}