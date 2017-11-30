using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probability
{
    //Deck of cards probability problem.
    //P(n)
    public class CardDeck
    {
        const double SUITS = 4;
        const double TYPES = 13;
        const double COUNT = TYPES * SUITS; //52

        public double ProbabilityOfAJack()
        {
            //P(Jack)

            double probabilityOfJack = SUITS / COUNT; // 4/52
            return probabilityOfJack;
        }

        public double ProbabilityOfHeart()
        {
            double hearts = TYPES * 1 / COUNT;

            return hearts;
        }

        public double ProbabilityOfHeartOrJack()
        {
            //P(Heart or Jack)
            
            double r = (TYPES + SUITS) -1 / COUNT; //-1 is for the overlap

            return r;
        }
    }
}
