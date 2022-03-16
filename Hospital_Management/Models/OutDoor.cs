using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;

namespace Hospital_Management.Models
{
    public class OutDoor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Outer ID"), Required]
        public string Outer_ID { get; set; }
        [Display(Name = "Date"), Required]
        public Nullable<System.DateTime> Date { get; set; }
        [Display(Name = "Patient Id"), Required]
        public string Patient_Id { get; set; }
        [Display(Name = "Docter Name"), Required]
        public string Docter_Name { get; set; }
        [Display(Name = "Comment") ]
        public string Comment { get; set; }
        [Display(Name = "Docter fee"), Required]
        public Nullable<decimal> Docter_fee { get; set; }
        [Display(Name = "Reistration fee"), Required]
        public Nullable<decimal> Reg_fee { get; set; }
        [Display(Name = "Other fee")]
        public Nullable<decimal> Other_dorfee { get; set; }
        [Display(Name = "Office")]
        public string Office { get; set; }

    }
}