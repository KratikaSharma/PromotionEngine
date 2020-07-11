using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace PromotionEngine.PromotionEngine.PromotionForSKUCD
{
    class PromotionForSkuCD : IPromotionSkuCD
    {
        public void ApplyPromotion(List<string> skus, ref int calulation)
        {
            int cCount = skus.FindAll(m => m == "C").Count();
            int dCount = skus.FindAll(m => m == "D").Count();
            int finaldic = 0;
            if(cCount <= dCount)
            {
                finaldic = cCount;
            }
            if(cCount >= dCount)
            {
                finaldic = dCount;
            }
            if(finaldic != 0)
            {
                calulation += 30 * finaldic;
                for(int i = 0; i <= finaldic-1; i++)
                {
                    skus.Remove("C");
                    skus.Remove("D");
                }
            }
        }
    }
}
