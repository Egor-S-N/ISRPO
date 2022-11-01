using System;
using Card;

namespace Deck
{
    public class Deck
    {
        // private List<Card.Card> cards = new List<Card.Card>(10);
        private Card.Card []cards;

        public Deck()
        {
        //  this.cards = new List<Card.Card>(10); 
        cards = new Card.Card[10];

        }
        public void SetCard(int number, Card.Card value)
        {
            cards[number] = value;
        }
        public Card.Card GetCard(int number){
            return cards[number];
        }


        public void Shuffle(){
                Random rnd = new Random();
            for (int i = cards.Count() - 1; i >=1; i --)
            {
                int j = rnd.Next(i + 1);
 
                Card.Card tmp = cards[j];
                cards[j] = cards[i];
                cards[i] = tmp;
            }
        }        
    }       
}