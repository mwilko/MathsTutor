using System;
using System.Collections.Generic;

namespace CMP1903M_A01_2223
{
    public class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        public int Value { get; set; }
        public Suits Suit { get; set; }

        public enum Suits
        {
            Hearts = 0,
            Diamonds,
            Clubs,
            Spades
        }

        public string CardValue
        {
            get
            {
                string identity = "";
                switch (Value)
                {
                    case (1):
                        identity = "Ace";
                        break;
                    case (11):
                        identity = "Jack";
                        break;
                    case (12):
                        identity = "Queen";
                        break;
                    case (13):
                        identity = "King";
                        break;
                    default:
                        identity = Value.ToString();
                        break;

                }
                return identity;
            }
        }

        public string Identity
        {
            get
            {
                return CardValue + " of " + Suit.ToString();
            }
        }

        public Card(int value, Suits suit)
        {
            this.Value = value;
            this.Suit = suit;
        }
    }
}
