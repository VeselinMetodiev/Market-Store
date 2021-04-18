
using System;

namespace MarketStore
{
    public class GoldCard : DiscountCard
    {
        public GoldCard(Owner owner, double turnover) 
            : base(owner, turnover)
        {
            this.DiscountRate = 0.02;
        }

        public override double GetCurrentDiscountRate()
        {
            if (this.Turnover > 100)
            {
                this.DiscountRate = Math.Min((0.02 + (this.Turnover / 100) * 0.01), 0.1);
            }
            return this.DiscountRate;
        }

        

       
    }
}
