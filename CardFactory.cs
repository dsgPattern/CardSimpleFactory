using System;

namespace CardSimpleFactory
{
    public static class CardFactory
    {
        public static Card MakeCard(int id, string userName, CardType type, DateTime expirationDate, int ccv,
            string color)
        {
            switch (type)
            {
                case CardType.Standard:
                    return new StandardCard(id, userName, expirationDate, ccv, color);
                case CardType.Premium:
                    return new PremiumCard(id, userName, expirationDate, ccv, color);
                case CardType.Metal:
                    return new MetalCard(id, userName, expirationDate, ccv, color);
                case CardType.Virtual:
                // try it yourself
                case CardType.OneTime:
                    //try it yourself
                default:
                    return null;
            }
        }
    }
}
