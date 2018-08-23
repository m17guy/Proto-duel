using System;

namespace making_the_deck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
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
