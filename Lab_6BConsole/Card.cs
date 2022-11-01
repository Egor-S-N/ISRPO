using System;

namespace Card
{
    public class Card
    {
        private string suit = "";
        private string rank = "";
        private Card()
        {
            suit = "";
            rank = "";
        }

        public Card(string suit, string rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        public override string ToString()
        {
            return $"rank: {rank} suit {suit}\n";
        }       

    }
}