using System;
using System.Collections.Generic;
using System.IO;

namespace making_the_deck
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> TheDeck = new List<Card>();//all the cards will go here
            TestDeckContens(MakeCards("blue cards.txt", TheDeck, "blue"));
            Console.ReadKey();
        }
        static List<Card> MakeCards(string FileName, List<Card> MyList, string CardType)
        {
            FileStream file = new FileStream(FileName, FileMode.OpenOrCreate);
            file.Close();//never forget to close the stream
            string[] CardAtributs = File.ReadAllText(FileName).Split(Environment.NewLine);
            switch (CardType.ToLower())
            {
                case "blue":
                    for (int i = 0; i < CardAtributs.Length; i += 3)//3 reprosents the the number of card atributs that are being asined
                    {
                        Card a = new Blue(i, CardAtributs);
                    }
                    return Blue.blueCards;
                default:
                    Exception prob = new Exception("this type of card does not exist");
                    throw prob;
            }
        }
        static void TestDeckContens(List<Card> a)//for my testing
        {
            foreach (Card c in a)
            {
                Console.WriteLine(c.name);
                Console.WriteLine(c.points);
                foreach (int i in c.coust)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
        static Card[] ShafelTamar(Card[] a)
        {
            Random num = new Random();
            for (int z = 0; z < a.Length; z++)
            {
                a[z].randomnumber = num.Next(1, 1000);
            }
            Array.Sort(a, delegate (Card a1, Card b2) { return a1.randomnumber.CompareTo(b2.randomnumber); });
            return a;
        }
    }
}
