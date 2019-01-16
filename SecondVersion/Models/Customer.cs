using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecondVersion.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public bool IsSubNewLetter { get; set; }

        public MemberShipType MemberShipType { get; set; }

        public int MemberShipTypeId { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}