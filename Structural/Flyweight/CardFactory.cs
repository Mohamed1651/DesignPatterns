using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class CardFactory
    {
        private Dictionary<string, Card> _cards = new Dictionary<string, Card>();

        public Card GetCard(Rank rank, Suit suit)
        {
            string rankString = rank.ToString();
            string suitString = suit.ToString();
            if (!_cards.ContainsKey(rankString + suitString))
            {
                _cards[rankString + suitString] = new Card(rankString, suitString);
            }

            return _cards[rankString + suitString];
        }
    }
}
