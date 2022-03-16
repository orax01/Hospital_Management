using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Hospital_Management.Models
{
    public class OutDoorPatient
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Patient Id"), Required]
        public string Patient_Id { get; set; }
        [Display(Name = "Patient Name"), Required]
        public string Patient_Name { get; set; }
        [Display(Name = "Date of Join"), Required]
        public Nullable<System.DateTime> Patient_DOJ { get; set; }
        [Display(Name = "Date OF barth"), Required]
        public Nullable<System.DateTime> Patient_DOB { get; set; }
        [Display(Name = "Age"), Required]
        public Nullable<decimal> Patient_Age { get; set; }
        [Display(Name = "Address"), Required]
        public string Patient_Address { get; set; }
        [Display(Name = "Mobile No."), Required]

        public string Patient_MobileNo { get; set; }
        [Display(Name = "Mail Id"), Required]
        public string Patient_EmailId { get; set; }
        [Display(Name = "Type"), Required]
        public string type { get; set; }
        [Display(Name = "Sex"), Required]
        public string sex { get; set; }
        [Display(Name = "Hight"), Required]
        public string Hight { get; set; }
        [Display(Name = "Weight"), Required]
        public string Weight { get; set; }
        [Display(Name = "BP"), Required]
        public string BP { get; set; }
        [Display(Name = "Care of"), Required]
        public string Care_of { get; set; }
        [Display(Name = "Care of Name"), Required]
        public string Care_of_Name { get; set; }

        [Display(Name = "OutDoor ID"), Required]
        public string Outer_ID { get; set; }
        [Display(Name = "Date"), Required]
        public Nullable<System.DateTime> Date { get; set; }
        [Display(Name = "Docter Name"), Required]
        public string Docter_Name { get; set; }
        [Display(Name = "Comment")]
        public string Comment { get; set; }
        [Display(Name = "Docter fee"), Required]
        public decimal Docter_fee { get; set; }
        [Display(Name = "Reistration fee"), Required]
        public decimal Reg_fee { get; set; }
        [Display(Name = "Other fee")]
        public Nullable<decimal> Other_dorfee { get; set; }
        [Display(Name = "Office")]
        public string Office { get; set; }

    }
}