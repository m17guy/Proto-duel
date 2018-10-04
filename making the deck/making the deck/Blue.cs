using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace making_the_deck
{
    class Blue:Card
    {
        static public List<Card> blueCards = new List<Card>();//the cards you make will go here
        public Blue(int CardNum, string[] CardAtributs)
        {
            //making the cards
            name = CardAtributs[CardNum];
            points = Convert.ToInt32(CardAtributs[CardNum + 1]);
            string[] WillBePrice = CardAtributs[CardNum + 2].Split(" ");
            for (int i = 0; i < coust.Length; i++)
            {
                coust[i] = Convert.ToInt32(WillBePrice[i]);
            }
            blueCards.Add(this);
        }

        
    }
}

