using System;

namespace CardSimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here we don't care about the actual card type instance(StandardCard, PremiumCard...).
            // we care only that we create a card of a specific CardType, that we can use later on
            // 
            Card card = CardFactory.MakeCard(1, "user", CardType.Standard, DateTime.MaxValue, 123, "red");
            Console.WriteLine($"Created a specific {card.GetType()} with {card.Benefits}");
            card = CardFactory.MakeCard(1, "user", CardType.Premium, DateTime.MaxValue, 123, "red");
            Console.WriteLine($"Created a specific {card.GetType()} with {card.Benefits}");

            if (card is Card)
            {
                Console.WriteLine($"Meanwhile, all instaces are of Card base type");
            }

            Console.ReadLine();
        }
    }
}
