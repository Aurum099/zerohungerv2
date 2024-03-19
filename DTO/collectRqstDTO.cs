using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using zerohungerv2.EF;

namespace zerohungerv2.DTO
{
    public class collectRqstDTO
    {
        public int C_ID { get; set; }
        public int R_ID { get; set; }
        public int E_ID { get; set; }
        public int MAX_PRESERVE_TIME { get; set; }
        public string STATUS { get; set; }
        public string FOOD_NAME { get; set; }

        public virtual NGO_EMP NGO_EMP { get; set; }
        public virtual RESTAURANT RESTAURANT { get; set; }
    }
}