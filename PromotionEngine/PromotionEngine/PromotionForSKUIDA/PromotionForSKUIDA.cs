using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.PromotionEngine.PromotionForSKUIDA
{
    public class PromotionForSkuIDA : IPromotionForSKUIDA
    {
        public void ApplyPromotion(List<string> skus, ref int calulation)
        {
            var countA = skus.FindAll(m => m == "A").Count;

            if(countA != 0)
            {
                int c = countA / 3;
                calulation += 130 * c;
                for(int i = 0; i <= c - 1; i++)
                {
                    skus.Remove("A");
                    skus.Remove("A");
                    skus.Remove("A");
                }
            }

        }
    }
}
