
//possible to create a program that can add cards to gameplay by taking into account color, number / image, 
//and then placing it over a blank tempelate

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Uno_Interactions
{
    class Player
    {
        public int score = 0;
        public List<Card> hand = new List<Card>();
        
        public Player(Deck d)
        {
            for (int x = 0; x < 7; x++)
            {
                Draw(d);
            }
        }

        public void Draw(Deck deck)
        {
            hand.Add(deck.getRandomCard());
        }


    }

}
