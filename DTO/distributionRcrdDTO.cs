using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using zerohungerv2.EF;

namespace zerohungerv2.DTO
{
    public class distributionRcrdDTO
    {
        public int D_ID { get; set; }
        public int F_ID { get; set; }
        public System.DateTime DISTRIBUTE_DATE { get; set; }
        public string RECIPIENT { get; set; }
        public int QT_DISTRIBUTE { get; set; }

        public virtual FOOD_ITEM FOOD_ITEM { get; set; }
    }
}