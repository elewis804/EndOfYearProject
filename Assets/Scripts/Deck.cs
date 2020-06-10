//possible to create a program that can add cards to gameplay by taking into account color, number / image, 
//and then placing it over a blank tempelate

using System;
using System.Collections.Generic;

namespace Uno_Interactions
{
    class Deck
    {
        public List<Card> deck = new List<Card>();
        public Deck()
        {
            for (int x = 0; x < 10; x++)
            {
                if (x == 0)
                {
                    deck.Add(new Card( (string)x.ToString(), "Blue", null));
                    deck.Add(new Card((string)x.ToString(),  "Red", null));
                    deck.Add(new Card((string)x.ToString(),  "Yellow", null));
                    deck.Add(new Card((string)x.ToString(),  "Green", null));
                }
                else
                {
                    for (int y = 0; y < 2; y++)
                    {
                        deck.Add(new Card((string)x.ToString(),  "Blue", null));
                        deck.Add(new Card((string)x.ToString(),  "Red", null));
                        deck.Add(new Card((string)x.ToString(),  "Yellow", null));
                        deck.Add(new Card((string)x.ToString(),  "Green", null));
                    }
                }
            }

            for (int x = 0; x < 2; x++)
            {
                deck.Add(new Card("Draw2",  "Blue", "+2"));
                deck.Add(new Card("Draw2", "Green", "+2"));
                deck.Add(new Card("Draw2", "Yellow", "+2"));
                deck.Add(new Card("Draw2", "Red", "+2"));

                deck.Add(new Card("Reverse", "Blue", "Reverse"));
                deck.Add(new Card("Reverse", "Red", "Reverse"));
                deck.Add(new Card("Reverse", "Green", "Reverse"));
                deck.Add(new Card("Reverse", "Yellow", "Reverse"));

                deck.Add(new Card("Skip", "Blue", "Skip"));
                deck.Add(new Card("Skip", "Red", "Skip"));
                deck.Add(new Card("Skip", "Yellow", "Skip"));
                deck.Add(new Card("Skip", "Green", "Skip"));
            }

            deck.Add(new Card("Draw4", null, "+4"));
            deck.Add(new Card("Draw4", null, "+4"));
            deck.Add(new Card("Draw4", null, "+4"));
            deck.Add(new Card("Draw4", null, "+4"));

            deck.Add(new Card("Draw2", null, "Wild"));
            deck.Add(new Card("Draw2", null, "Wild"));
            deck.Add(new Card("Draw2", null, "Wild"));
            deck.Add(new Card("Draw2", null, "Wild"));
        }

        public Card getRandomCard()
        {
            Random x = new Random();
            Card y = deck[x.Next(0, 108)];
            deck.Remove(y);
            return y;
        }

        
    }

}
