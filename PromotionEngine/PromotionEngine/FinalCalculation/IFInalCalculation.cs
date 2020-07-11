using PromotionEngine.PromotionEngine.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.PromotionEngine
{
    interface IFInalCalculation
    {
        UnitPriceValues GetUnitPriceForSKUs();

        int ProcessFinalBill(List<string> skus, ref int calulation);

    }
}
