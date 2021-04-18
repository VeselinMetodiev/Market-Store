
namespace MarketStore
{
    public class BronzeCard : DiscountCard
    {
        public BronzeCard(Owner owner, double turnover) 
            : base(owner, turnover)
        {
            this.DiscountRate = 0;
        }

        public override double GetCurrentDiscountRate()
        {
            if (this.Turnover >= 100 && this.Turnover <= 300)
            {
                this.DiscountRate = 0.01;
            }
            else if (this.Turnover > 300)
            {
                this.DiscountRate = 0.025;
            }

            return this.DiscountRate;
        }
    }
}
