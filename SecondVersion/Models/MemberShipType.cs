using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecondVersion.Models
{
    public class MemberShipType
    {
        public int Id { get; set; }

        public int  SignUpFee { get; set; }

        public int DurationInMonths { get; set; }

        public int DiscountRate { get; set; }
    }
} 