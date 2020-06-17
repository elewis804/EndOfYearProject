
//possible to create a program that can add cards to gameplay by taking into account color, number / image, 
//and then placing it over a blank tempelate

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Uno_Interactions
{
    public class Player : MonoBehaviour
    {

        public int score = 0;
        public List<Card> hand = new List<Card>();
        public Deck deck;

        void Start()
        {

        }

        public void Update()
        {

        }

        public void SetDeck(Deck d)
        {
            this.deck = d;
        }


        public void DrawHand(Deck d)
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
