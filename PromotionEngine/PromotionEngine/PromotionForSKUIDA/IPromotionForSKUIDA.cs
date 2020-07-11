using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.PromotionEngine.PromotionForSKUIDA
{
    interface IPromotionForSKUIDA
    {
        void ApplyPromotion(List<string> skus,ref int calulation);
    }
}
