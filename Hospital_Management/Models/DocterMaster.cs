using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Hospital_Management.Models
{
    public class DocterMaster
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Docter ID"), Required(ErrorMessage ="Value required")]
        public string Docter_id { get; set; }
        [Display(Name = "Docter Name"), Required]
        public string Docter_Name { get; set; }
        [Display(Name = "Date Of Join"), Required]
        public Nullable<System.DateTime> DOG { get; set; }
        [Display(Name = "Total Years of Exp"), Required]
        public string Total_exeprience { get; set; }
        [Display(Name = "Age"), Required]
        public Nullable<int> Age { get; set; }
        [Display(Name = "Qualification"), Required]
        public string Qualification { get; set; }
        [Display(Name = "Fee"), Required]
        public Nullable<int> Free { get; set; }
        [Display(Name = "Working Hours"), Required]
        public string Working_hours { get; set; }
        [Display(Name = "Degination"), Required]
        public string Degination { get; set; }
    }
}