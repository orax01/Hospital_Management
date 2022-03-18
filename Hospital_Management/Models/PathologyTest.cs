using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Hospital_Management.Models
{
    public class PathologyTest
    {
        public int Id { get; set; }
        [Display(Name = "Test Id"), Required]
        public string Test_id { get; set; }
        [Display(Name = "Test Name"), Required]
        public string Test_Name { get; set; }
        [Display(Name = "Paitent Id"), Required]
        public string Paitent_Id { get; set; }
        [Display(Name = "Outdoor Id"), Required]
        public string Outdoor_Id { get; set; }
        [Display(Name = "Type"), Required]
        public string Type { get; set; }
        [Display(Name = "Fee"), Required]
        public Nullable<int> Fee { get; set; }
        [Display(Name = "Date"), Required]
        public Nullable<System.DateTime> Date { get; set; }
        [Display(Name = "Test By"), Required]
        public string Test_by { get; set; }
    }
}