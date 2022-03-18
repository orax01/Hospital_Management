using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Hospital_Management.Models
{
    public class Indoor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Record Number"), Required]
        public string Record_No { get; set; }
        [Display(Name = "Out Door Id"), Required]
        public string OutDoorID { get; set; }
        [Display(Name = "Paitent Id"), Required]
        public string PaitentId { get; set; }
        [Display(Name = "Addmiction Date"), Required]
        public Nullable<System.DateTime> Admiction_Date { get; set; }
        [Display(Name = "Cabin No"), Required]
        public string Cabin_No { get; set; }
        [Display(Name = "Out Door Docter Name"), Required]
        public string OutDoorDocter { get; set; }
        [Display(Name = "Consolt Docter"), Required]
        public string Consoltant_Docter { get; set; }
        [Display(Name = "Indoor No"), Required]
        public string INdoor_No { get; set; }
        [Display(Name = "Provisional degination"), Required]
        public string Provisional_deg { get; set; }
        [Display(Name = "Comment"), Required]
        public string Comment { get; set; }
        [Display(Name = "Paitent Namr"), Required]
        public string Paitent_Name { get; set; }
        [Display(Name = "Opperaction Date"), Required]
        public Nullable<System.DateTime> Date_Opperaton { get; set; }
        [Display(Name = "Sex"), Required]
        public string Sex { get; set; }
    }
}