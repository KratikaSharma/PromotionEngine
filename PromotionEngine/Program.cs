using PromotionEngine.PromotionEngine;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter SKUIDs");
                string skuID = Console.ReadLine();
                List<string> ids = skuID.Split(',').ToList();
                IPromotionType promotionType = new PromotionType();
                int _output = promotionType.CalculateCost(ids);
                Console.Write(_output);
                Console.ReadLine();
            }

        }
    }
}
