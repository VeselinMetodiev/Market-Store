using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    public class SilverCard : DiscountCard
    {
        public SilverCard(Owner owner, double turnover) 
            : base(owner, turnover)
        {
            this.DiscountRate = 0.02;
        }

        public override double GetCurrentDiscountRate()
        {
            if (this.Turnover > 300)
            {
                this.DiscountRate = 0.035;
            }
            return this.DiscountRate;
        }

        

        
    }
}
