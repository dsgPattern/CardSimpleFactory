using System;

namespace CardSimpleFactory
{
    public class PremiumCard: Card
    {
        public PremiumCard(int id, string userName, DateTime expirationDate, int ccv, string color) 
            : base(id, userName, CardType.Premium, expirationDate, ccv, color)
        {
        }

        protected override void AddBenefits()
        {
            Benefits = "100.000 limit and travel insurance";
        }
    }
}
