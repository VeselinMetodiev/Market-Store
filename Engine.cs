using System;

namespace MarketStore
{
   public class Engine
    {
        public Engine()
        {

        }

        public void Run()
        {
            Owner bronzeCardOwner = new Owner("Bronze card:", 150);
            DiscountCard bronzeCard = new BronzeCard(bronzeCardOwner, 0);
            double purchaseValue = bronzeCardOwner.PurchaseValue;
            Console.WriteLine(bronzeCardOwner.Name);
            Console.WriteLine($"Purchase value: ${purchaseValue:f2}");
            Console.WriteLine($"Discount Rate: {bronzeCard.GetCurrentDiscountRate() * 100:f1}%");
            Console.WriteLine($"Discount: ${bronzeCard.getDiscount(purchaseValue):f2}");
            Console.WriteLine($"Total: ${bronzeCard.getTotalPurchaseValue(purchaseValue):f2}");
            Console.WriteLine();

            Owner silverCardOwner = new Owner("Silver card:", 850);
            DiscountCard silverCard = new SilverCard(silverCardOwner, 600);
            purchaseValue = silverCardOwner.PurchaseValue;
            Console.WriteLine("Silver card:");
            Console.WriteLine($"Purchase value: ${purchaseValue:f2}");
            Console.WriteLine($"Discount Rate: {silverCard.GetCurrentDiscountRate() * 100:f1}%");
            Console.WriteLine($"Discount: ${silverCard.getDiscount(purchaseValue):f2}");
            Console.WriteLine($"Total: ${silverCard.getTotalPurchaseValue(purchaseValue):f2}");
            Console.WriteLine();

            Owner goldCardOwner = new Owner("Gold card:", 1300);
            DiscountCard goldCard = new GoldCard(goldCardOwner, 1500);
            purchaseValue = goldCardOwner.PurchaseValue;
            Console.WriteLine("Bronze card:");
            Console.WriteLine($"Purchase value: ${purchaseValue:f2}");
            Console.WriteLine($"Discount Rate: {goldCard.GetCurrentDiscountRate() * 100:f1}%");
            Console.WriteLine($"Discount: ${goldCard.getDiscount(purchaseValue):f2}");
            Console.WriteLine($"Total: ${goldCard.getTotalPurchaseValue(purchaseValue):f2}");

            
        }
    }
}
