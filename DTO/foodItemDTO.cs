using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using zerohungerv2.EF;

namespace zerohungerv2.DTO
{
    public class foodItemDTO
    {
        public int F_ID { get; set; }
        public int C_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public int QUANTITY { get; set; }
        public System.DateTime EXPIRY { get; set; }

        public virtual COLLECT_RQST COLLECT_RQST { get; set; }
    }
}