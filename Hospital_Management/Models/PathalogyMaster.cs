using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Hospital_Management.Models
{
    public class PathalogyMaster
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Test Name"), Required]
        public string Test_Name { get; set; }
        [Display(Name = "Fee"), Required]
        public Nullable<int> Ammout { get; set; }
        [Display(Name = "Requard Time"), Required]
        public string Requard_time { get; set; }
        [Display(Name = "Test Id"), Required]
        public string Tset_ID { get; set; }
        [Display(Name = "Type"), Required]
        public string Type { get; set; }
        [Display(Name = "Is Available"), Required]
        public bool status { get; set; }
    }
}