using System;
using Card;
using Deck;

namespace Program
{
    public class Program{
        public static void Main()
        {
            System.Console.WriteLine("hello");
            Deck.Deck deck = new Deck.Deck();
            for(int i = 0; i < 10; i ++)
            {
                Card.Card card = new Card.Card(i.ToString(), i.ToString());
                deck.SetCard(i, card);

                System.Console.Write($"{card}\t");

            }
            deck.Shuffle();

            System.Console.WriteLine("-----------------------------");

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine(deck.GetCard(i));
            }

                 
        }
    }
}