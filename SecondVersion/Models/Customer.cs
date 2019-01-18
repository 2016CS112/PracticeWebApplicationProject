using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SecondVersion.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public String Name { get; set; }

        public bool IsSubNewLetter { get; set; }

        public MemberShipType MemberShipType { get; set; }

        [Display(Name= "MemberShipType")]
        public int MemberShipTypeId { get; set; }
        [Display(Name = "Date_of_Bith")]
        public DateTime DateOfBirth { get; set; }
    }
}