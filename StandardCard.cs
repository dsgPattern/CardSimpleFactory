using System;

namespace CardSimpleFactory
{
    public class StandardCard: Card
    {
        public StandardCard(int id, string userName, DateTime expirationDate, int ccv, string color) 
            : base(id, userName, CardType.Standard, expirationDate, ccv, color)
        {

        }


        protected override void AddBenefits()
        {
            Benefits = "10.000 limit";
        }
    }
}
