using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.PromotionEngine.Common
{
   public class UnitPrice
    {
        public string sku { get; set; }
        public int price { get; set; }
    }
    public class UnitPriceValues
    {
       public List<UnitPrice> UnitPrice { get; set; }
    }
}
