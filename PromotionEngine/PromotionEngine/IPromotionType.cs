using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.PromotionEngine
{
    interface IPromotionType
    {
        int CalculateCost(List<string> skus);
    }
}
