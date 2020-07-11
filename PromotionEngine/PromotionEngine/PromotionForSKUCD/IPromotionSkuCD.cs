using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.PromotionEngine.PromotionForSKUCD
{
    interface IPromotionSkuCD
    {
        void ApplyPromotion(List<string> skus, ref int calulation);
    }
}
