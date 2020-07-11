using PromotionEngine.PromotionEngine.PromotionForSKUCD;
using PromotionEngine.PromotionEngine.PromotionForSKUIDA;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.PromotionEngine
{
    public class PromotionType : IPromotionType
    {
        public int CalculateCost(List<string> skus)
        {
            int calculate = 0;

            //Promotion for SKU A
            calculate = PromotionForSkuIdA(skus, calculate);

            //Promotion for SKU c and D
            calculate = PromotionForSkuIDB(skus, calculate);

            //Final Calculation
            calculate = FinalCost(skus, calculate);

            return calculate;
        }

        private static int FinalCost(List<string> skus, int calculate)
        {
            IFInalCalculation finalCalculation = new FinalCalculation();
            int finalCost = finalCalculation.ProcessFinalBill(skus, ref calculate);
            return finalCost;
        }

        private static int PromotionForSkuIDB(List<string> skus, int calculate)
        {
            IPromotionSkuCD promotionSkuCD = new PromotionForSkuCD();
            promotionSkuCD.ApplyPromotion(skus, ref calculate);
            return calculate;
        }

        private static int PromotionForSkuIdA(List<string> skus, int calculate)
        {
            IPromotionForSKUIDA promotionForSKUIDA = new PromotionForSkuIDA();
            promotionForSKUIDA.ApplyPromotion(skus, ref calculate);
            return calculate;
        }
    }
}
