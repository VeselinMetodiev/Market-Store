
using System;

namespace MarketStore
{
    public class Owner
    {
        private string name;
        private double purchaseValue;
  
        public Owner(string name, double purchasingValue)
        {
            this.Name = name;
            this.PurchaseValue = purchasingValue;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public double PurchaseValue
        {
            get => this.purchaseValue;

            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Purchase value cannot be a negative number");
                }
                this.purchaseValue = value;
            }
        }
    }
}
