
using System;

namespace MarketStore
{
    public abstract class DiscountCard
    {
        
        private Owner owner;
        private double turnover;
        private double discountRate;

        public Owner Owner { get; private set; }

        public double Turnover { get => this.turnover;
            protected set {
                if(value < 0)
                {
                    throw new ArgumentException("Turnover cannot be less than 0");
                }
                this.turnover = value;
            }
        }
        public double DiscountRate { get => this.discountRate;
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Discount rate cannot be less than 0");
                }
                this.discountRate = value;
            }
        }
        

        public DiscountCard(Owner owner, double turnover)
        {
            this.Owner = owner;
            this.Turnover = turnover;
        }

        public abstract double GetCurrentDiscountRate();

        public double getTotalPurchaseValue(double valuePurchase)
        {
            return valuePurchase - getDiscount(valuePurchase);
        }

        public double getDiscount(double valuePurchase)
        {
            return valuePurchase * GetCurrentDiscountRate();
        }


    }
}
