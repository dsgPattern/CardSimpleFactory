using System;

namespace CardSimpleFactory
{
    public class MetalCard: Card
    {
        public MetalCard(int id, string userName, DateTime expirationDate, int ccv, string color)
            : base(id, userName, CardType.Metal, expirationDate, ccv, color)
        {
        }

        protected override void AddBenefits()
        {
            Benefits = "All in";
        }
    }
}
