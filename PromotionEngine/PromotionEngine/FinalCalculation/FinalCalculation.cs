using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PromotionEngine.PromotionEngine.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace PromotionEngine.PromotionEngine
{
   public class FinalCalculation : IFInalCalculation
    {
        public UnitPriceValues GetUnitPriceForSKUs()
        {
            var binDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var rootDirectory = Path.GetFullPath(Path.Combine(binDirectory));
            var fileData = File.ReadAllText(Path.Combine(rootDirectory, $@"Resources\UnitPricePerSKU.json"));
            var data = JsonConvert.DeserializeObject<UnitPriceValues>(fileData);
            return data;
        }

        public int ProcessFinalBill(List<string> skus,ref int calulation)
        {
            int finalCost = 0;
            UnitPriceValues unitPrices = GetUnitPriceForSKUs();
            foreach(var v in skus)
            {
                finalCost += unitPrices.UnitPrice.Find(m => m.sku == v).price;
            }
            finalCost += calulation;
            return finalCost;

        }
    }
}
