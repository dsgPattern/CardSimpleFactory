using System;

namespace CardSimpleFactory
{
    public abstract class Card
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public CardType Type { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Ccv { get; set; }
        public string Color { get; set; }

        public string Benefits { get; set; }

        protected Card(int id, string userName, CardType type, DateTime expirationDate, int ccv, string color)
        {
            AddBenefits();
        }

        protected abstract void AddBenefits();
    }
}
